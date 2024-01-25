using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT
{
    internal class DungChung
    {
        
        string ChuoiKN = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nam_3\LT.NET\CS464E_INDIVIDUAL_PROJECT\CS464E_INDIVIDUAL_PROJECT\QUANLYSACH.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        public DungChung()
        {
            con = new SqlConnection(ChuoiKN);
            da = new SqlDataAdapter();
            dt = new DataTable();
        }

        public void NonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int items = cmd.ExecuteNonQuery();
            if (items >= 1)
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
            con.Close();
        }

        public DataTable LoadData (string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int scalar(string sql)
        {
            con.Open();
            SqlCommand comm = new SqlCommand(sql, con);
            int ketqua = (int)comm.ExecuteScalar();
            con.Close();
            return ketqua;
        }
        
        public void Updatedata()
        {
            SqlCommandBuilder up = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
