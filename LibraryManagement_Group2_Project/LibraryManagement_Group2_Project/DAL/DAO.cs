using LibraryManagement_Group2_Project.DTL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement_Group2_Project.DAL
{
    class DAO
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        static public DataTable GetDataTable(string sqlSelect)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable GetDataTable(SqlCommand cmd)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.Connection = new SqlConnection(strConn);
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return null;
            }
        }

        static public bool UpdateTable(SqlCommand cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
