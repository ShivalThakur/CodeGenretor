using System;
using System.Data;

namespace SearchFile.Library.DB
{
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
        public DataSet ExecuteSql(string sql)
        {
            return db.ExecuteSql(sql);
        }
        public DataSet ExecuteProcedureToGetColumns(string spName)
        {
            return db.ExecuteProcedureToGetColumns(spName);
        }
        public SqlDbType GetDBType(System.Type theType)
        {
            System.Data.SqlClient.SqlParameter p1;
            System.ComponentModel.TypeConverter tc;
            p1 = new System.Data.SqlClient.SqlParameter();
            tc = System.ComponentModel.TypeDescriptor.GetConverter(p1.DbType);
            if (tc.CanConvertFrom(theType))
            {
                p1.DbType = (DbType)tc.ConvertFrom(theType.Name);
            }
            else
            {
                //Try brute force
                try
                {
                    p1.DbType = (DbType)tc.ConvertFrom(theType.Name);
                }
                catch (Exception)
                {
                    //Do Nothing; will return NVarChar as default
                }
            }
            return p1.SqlDbType;
        }
    }
}