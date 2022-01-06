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
    public partial class addGenres : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        Myconnect db = new Myconnect();
        public addGenres(string gen_id)
        {
            this.gen_id = gen_id;
            InitializeComponent();
            if (string.IsNullOrEmpty(gen_id)) // nếu gen_id không có => thêm mới The Loai Phim
            {
                this.Text = "Thêm Mới Thể Loại Phim";
            }
            else
            {
                this.Text = "Cập Nhật Thông Tin Thể Loại Phim";
                this.gen_id = @gen_id;
                SqlCommand cmd = new SqlCommand("select * from genres where gen_id ='" + @gen_id + "'", db.con);
                cmd.CommandType = CommandType.Text;
                db.con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    txtgenres.Text = rd["gen_title"].ToString().Trim();
                }

            }
        }
        private string gen_id;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gen_id))
            { 
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                var query = "insert into genres values (@gen_title) where gen_id='" + gen_id + "'";
                command.CommandText = "insertGenres";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@gen_title", txtgenres.Text);
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
            }
            else
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                //"UPDATE actor SET act_fname=@act_fname,act_lname=@act_lname,act_gender=@act_gender where act_id="+act_id+ ""
                command.CommandText = "UPDATE genres SET gen_title=@gen_title where gen_id="+gen_id+ "";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@gen_title", txtgenres.Text);

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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
