using SearchFile.Library.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SearchFile.Library
{
    public abstract class CurrentTechnology
    {
        public DataSet colData;
        public abstract string GenerateView(string spName);
        public abstract string GenerateServerCode();

        public List<SqlColumns> GetColumnNames(string spName)
        {
            OperationsDB oDb = new OperationsDB();
            DataSet ds = oDb.ExecuteProcedureToGetColumns(spName);
            string parameters = "";
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                parameters += item["ParameterName"] + "=\'0\',";
            }

            parameters = parameters.Substring(0, parameters.Length - 1);
            DataSet resultSet = oDb.ExecuteSql(spName + " " + parameters);
            return resultSet.Tables[0].Columns.Cast<DataColumn>()
                     .Select(x => new SqlColumns() { ColumnName = x.ColumnName, SqlDbType = x.DataType.Name })
                     .ToList();
        }
    }
}
