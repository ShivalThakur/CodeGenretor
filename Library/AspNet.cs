using System.Data;
using SearchFile.Library.DB;

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
}