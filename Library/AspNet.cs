using System.Data;
using SearchFile.Library.DB;
using System;

namespace SearchFile.Library
{
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
            try
            {
                OperationsDB oDb = new OperationsDB();
                DataSet ds= oDb.ExecuteProcedureToGetColumns(spName);
                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception)
            {
                
                return "";
            }
            
            //throw new NotImplementedException();
        }

        public override string GenerateServerCode()
        {
            return "Cs Code";
        }
    }
}