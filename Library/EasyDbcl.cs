using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using SearchFile;

/// <summary>
/// Summary description for EasyDbcl
/// </summary>
public class EasyDbcl
{
    SqlConnection oConnection = null;
    SqlCommand oCommand = null;
    SqlDataAdapter oDataAdapter = null;
    SqlDataReader oDataReader = null;
    DataSet oDs = null;
    string m_sSql = null;
    string sConString = ConfigurationSettings.AppSettings["ConnectionString"];
    public EasyDbcl()
    {
        sConString = Form1.connectionString;
    }
    public DataSet GetDataset(SqlCommand sSql)
    {
        GetConnection();
        oDataAdapter = new SqlDataAdapter("", oConnection);
        sSql.Connection = oConnection;
        oDataAdapter.SelectCommand = sSql;
        oDs = new DataSet();
        try
        {
            oDataAdapter.Fill(oDs);
            CloseConnection();
        }
        catch (Exception e)
        {

            //throw;
        }
        finally
        {
            CloseConnection();
        }
        return oDs;
    }
    public void GetConnection()
    {

        oConnection = new SqlConnection(sConString);
        oConnection.Open();

    }

    public void CloseConnection()
    {
        if (oConnection.State == ConnectionState.Open)
        {
            oConnection.Close();
        }
    }

    public void ExecuteCommand(string sSql)
    {
        GetConnection();
        oCommand = new SqlCommand(sSql, oConnection);
        oCommand.ExecuteNonQuery();
        CloseConnection();
    }
    public void ExecuteCommand(SqlCommand sSql)
    {
        GetConnection();
        sSql.Connection = oConnection;
        oCommand = sSql;
        oCommand.ExecuteNonQuery();
        CloseConnection();
    }


    public int ExecuteScalar(string sSql)
    {
        int iReturn = 0;
        GetConnection();
        oCommand = new SqlCommand(sSql, oConnection);
        iReturn = Convert.ToInt32(oCommand.ExecuteScalar());
        CloseConnection();
        return iReturn;
    }
    public int ExecuteScalar(SqlCommand sSql)
    {
        int iReturn = 0;
        GetConnection();
        sSql.Connection = oConnection;
        oCommand = sSql;
        iReturn = Convert.ToInt32(oCommand.ExecuteScalar());
        CloseConnection();
        return iReturn;
    }

    public DataSet GetDataset(string sSql)
    {
        GetConnection();
        oDataAdapter = new SqlDataAdapter(sSql, oConnection);
        oDataAdapter.SelectCommand.CommandTimeout = 0;
        oDs = new DataSet();
        try
        {
            oDataAdapter.Fill(oDs);
            CloseConnection();
        }
        catch (Exception e)
        {
            //Emailcl email = new Emailcl();
            //email.sendMail(e.Message + "<br />" + e.StackTrace + "<br />" + e.Source, "Error Tracker", "shivalthakur@gmail.com", "", "");
            //throw;
        }
        finally
        {
            CloseConnection();
        }
        return oDs;
    }

    public SqlDataReader GetDataReader(string sSql)
    {
        GetConnection();
        oCommand = new SqlCommand(sSql, oConnection);
        oDataReader = oCommand.ExecuteReader();
        return oDataReader;
    }
}
interface IDataBase
{
    DataSet ExecuteSql(string sql);
    DataSet ExecuteProcedureToGetColumns(string spName);
}
enum DataBaseType
{
    SqlServer
}
