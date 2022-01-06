using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class MoviesTop : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommandBuilder builder;
        private string mov_id;

        public MoviesTop()
        {
            InitializeComponent();
        }
        #region
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadData1();
        }
        private void LoadData1()
        {
            DataSet ds = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop1";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                txtyear.Text = rd["mov_dt_rel"].ToString().Trim();
                txttitle.Text = rd["mov_title"].ToString().Trim();
                string mov_id = rd["mov_id"].ToString().Trim();
            }
            connect.Close();
        }
        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds1 = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop2";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds1);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                year.Text = rd["mov_dt_rel"].ToString().Trim();
                txtname.Text = rd["mov_title"].ToString().Trim();
            }
            connect.Close();
        }
        //date
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds2 = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop3";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds2);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                date.Text = rd["mov_dt_rel"].ToString().Trim();
                title.Text = rd["mov_title"].ToString().Trim();
            }
            connect.Close();
        }
        //date3
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds3 = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop4";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds3);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                date3.Text = rd["mov_dt_rel"].ToString().Trim();
                name3.Text = rd["mov_title"].ToString().Trim();
            }
            connect.Close();
        }
        //date5 -- name6
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds4 = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop4";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds4);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                date5.Text = rd["mov_dt_rel"].ToString().Trim();
                name5.Text = rd["mov_title"].ToString().Trim();
            }
            connect.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds5 = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectTop4";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds5);
            connect.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                ///txtid.Text = @dir_id;
                date6.Text = rd["mov_dt_rel"].ToString().Trim();
                name6.Text = rd["mov_title"].ToString().Trim();
            }
            connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //date6
    }
}
