using System.Data;

namespace SearchFile.Library.DB
{
    class SqlServer : IDataBase
    {
        EasyDbcl db = null;
        public SqlServer()
        {
            db = new EasyDbcl();
        }
        public DataSet ExecuteSql(string sql)
        {
            return db.GetDataset(sql);
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