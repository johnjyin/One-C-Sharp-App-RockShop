using System;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Required designer variable.
/// author: john yin
/// version: version: V0.1
/// create date: 5/5/2014
/// last update data: 5/5/2014
/// </summary>
/// 

namespace Rockshop {
	
public class dacMySQLConn
{
    //private const string msModuleName = "dacMySQL";
    private MySqlConnection mySqlConn;
    private MySqlCommand mySqlComm;
    private MySqlDataAdapter mySqlAdapter;
    private DataTable dataTable;
    private int iRowsAffected;
    
    private string sConnStr = "SERVER=localhost; " 
                            + "DATABASE=rockshop; " 
                            + "UID=root; " 
                            + "PASSWORD=; " 
                            + "Convert Zero Datetime=True; "
                            + "Allow Zero Datetime=True; ";

    public DataTable ExecuteQuery(string sSQL)
    {
        mySqlConn = new MySqlConnection(sConnStr);

        try
        {
            mySqlComm = new MySqlCommand(sSQL, mySqlConn);
            mySqlAdapter = new MySqlDataAdapter(mySqlComm);
            dataTable = new DataTable();
            mySqlConn.Open();
            mySqlAdapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            throw new System.Exception("dacMySQLConn :" + ex.Message);
        }
        finally
        {
            mySqlConn.Close();
            
        }
        return dataTable;
    }

    public int ExecuteNonQuery(string sSQL)
    {
        mySqlConn = new MySqlConnection(sConnStr);
        mySqlComm = new MySqlCommand();
        mySqlComm.Connection = mySqlConn;
        mySqlComm.CommandType = CommandType.Text;
        mySqlComm.CommandText = sSQL;

        try
        {
            mySqlConn.Open();
            iRowsAffected = mySqlComm.ExecuteNonQuery();
            
        }
        catch (Exception ex)
        {
            iRowsAffected = -1;
            throw new System.Exception("dacMySQLConn :" + ex.Message);
        }
        finally
        {
            mySqlConn.Close();
        }
        return iRowsAffected;
    }
}

}