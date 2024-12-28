using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for SQL
/// </summary>
public class SQL
{
    public string connectionString;
    public SQL(string connectionString)
    {
        this.connectionString = connectionString;
    }
    /// <summary>
    /// Lấy toàn bộ dữ liệu có trong table CamBien_TuoiCay trong CSDL.
    /// </summary>
    /// <returns></returns>
    public DataTable GetSensor()
    {
        string strSQL = "select * from CamBien_TuoiCay";

        return GetData(strSQL, connectionString);
    }
    //===============================================
    ///  <summary>
    /// Get data from database.
    /// </summary>
    /// <param name="selectCommand">The SQL command.</param>
    /// <param name="connectionString">The string is used to connect to the database.</param>
    /// <returns></returns>
    public System.Data.DataTable GetData(string selectCommand, string connectionString)
    {
        try
        {
            //Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            //Create a command builder to generate SQL update, insert, and delete commands based on selectCommand. These are used to update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //Populate a new data table and bind it to the BindingSource.
            System.Data.DataTable table = new System.Data.DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            return table;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //=========================================================
}