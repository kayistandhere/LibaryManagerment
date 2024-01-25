using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DungChung
    {
        string ChuoiKN = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KY1NAM3\CS 464E\CS464E_INDIVIDUAL_PROJECT\QUANLYSACH.mdf;Integrated Security=True";
        SqlConnection con;

        public DungChung ()
        {
            con = new SqlConnection(ChuoiKN);
        }


        public void NonQuery (string sql)
        {
            SqlCommand cmd = new SqlCommand (sql,con);
            con.Open ();
            int items = cmd.ExecuteNonQuery ();
            if (items >=1)
            {
                MessageBox.Show("Thành Công ");
            } else
            {
                MessageBox.Show("Thất Bại ");
            }
            con.Close ();
        }

        public DataTable LoadData (string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill (dt);
            return dt;
        }

        public DataSet Scalar (string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill (ds , "SACH");
            return ds;
        }
    }
}
