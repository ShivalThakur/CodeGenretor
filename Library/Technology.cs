using SearchFile.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SearchFile
{

    public class Technology
    {
        Technologies currentTechnology;
        public Technology(Technologies tech)
        {
            currentTechnology = tech;
        }
        public CurrentTechnology GetCurrentTechnology()
        {
            switch (currentTechnology)
            {
                case Technologies.AspNet:
                    {
                        return new AspNet(null);

                    }
                //case Technologies.AspMVC:
                //    {
                //        break;
                //    }
                //case Technologies.Angular:
                //    {
                //        break;
                //    }
                default:
                    return null;
            }
        }

    }
    public enum Technologies
    {
        AspNet,
        AspMVC,
        Angular
    }
    public class AspNet : CurrentTechnology
    {
        IDataBase IDb;
        public AspNet(DataSet ds)
        {
            colData = ds;
            IDb = Form1.IDb;
        }
        public override string GenerateView(string spName)
        {
            OperationsDB oDb = new OperationsDB();
            DataSet ds= oDb.ExecuteProcedureToGetColumns(spName);
            return ds.Tables[0].Rows[0][0].ToString();

            //throw new NotImplementedException();
        }

        public override string GenerateServerCode()
        {
            return "Cs Code";
        }
    }
    class OperationsDB
    {

        DataSet ds = null;
        IDataBase db;
        public OperationsDB()
        {
            db = Form1.IDb;
        }
        public OperationsDB(IDataBase dbType)
        {
            db = dbType;
        }
        public DataSet ExecuteProcedureToGetColumns(string spName)
        {
            return db.ExecuteProcedureToGetColumns(spName);
        }
    }
    class SqlServer : IDataBase
    {
        EasyDbcl db = null;
        public SqlServer()
        {
            db = new EasyDbcl();
        }
        public DataSet ExecuteSql(string sql)
        {
            return null;
            // throw new NotImplementedException();
        }

        public DataSet ExecuteProcedureToGetColumns(string spName)
        {
            return db.GetDataset(@"select p.name ParameterName,t.name ParameterType,p.max_length from sys.all_parameters p
Join sys.types t on  t.user_type_id = p.user_type_id
where  p.object_id =object_id('" + spName + "');");
        }
        public string SqlDataType(string comingDataType)
        {
            string returndatatype = "";
            switch (comingDataType.ToLower())
            {
                case "date":
                    {
                        returndatatype = "Date";
                        break;
                    }
                case "datetime":
                    {
                        returndatatype = "DateTime";
                        break;
                    }
                case "varchar":
                    {
                        returndatatype = "VarChar";
                        break;
                    }
                case "int":
                    {
                        returndatatype = "Int";
                        break;
                    }
                case "nvarchar":
                    {
                        returndatatype = "NVarChar";
                        break;
                    }
                case "char":
                    {
                        returndatatype = "Char";
                        break;
                    }
            }
            return returndatatype;
        }
    }
}
