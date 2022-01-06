using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PlayerUI
{
    public partial class addDirector : Form
    {

        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        Myconnect db = new Myconnect();
        public addDirector(string dir_id)
        {
            this.dir_id = dir_id;
            InitializeComponent();
            if (string.IsNullOrEmpty(dir_id)) // nếu dir_id không có => thêm mới dao dien
            {
                this.Text = "Thêm Mới Đạo Diễn";
            }
            else
            {
                this.Text = "Cập Nhật Thông Tin Đạo Diễn";
                this.dir_id = @dir_id;
                SqlCommand cmd = new SqlCommand("select * from director where dir_id ='"+@dir_id+"'", db.con);
                cmd.CommandType = CommandType.Text;
                db.con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    ///txtid.Text = @dir_id;
                    txtfirstname.Text = rd["dir_fname"].ToString().Trim();
                    txtlastname.Text = rd["dir_lname"].ToString().Trim();
                }

            }
        }

        //public addDirector(){}

        public string dir_id;
        private void savedirector_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dir_id))
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                var query = "insert into director value (@dir_fname,@dir_lname)";
                command.CommandText = "insertDirector";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dir_fname", txtfirstname.Text);
                command.Parameters.AddWithValue("@dir_lname", txtlastname.Text);

                connect.Open();
                try
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Insert Sucess");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                    command.Parameters.Clear();
                }
                txtfirstname.DataBindings.Clear();
                txtlastname.DataBindings.Clear();
            }
            else
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                command.CommandText = "UPDATE director SET dir_fname=@dir_fname,dir_lname=@dir_lname where dir_id=" + dir_id + "";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@dir_fname", txtfirstname.Text);
                command.Parameters.AddWithValue("@dir_lname", txtlastname.Text);
                try
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Sucess");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                    command.Parameters.Clear();
                }
                txtfirstname.DataBindings.Clear();
                txtlastname.DataBindings.Clear();
            }
        }
    }
}
