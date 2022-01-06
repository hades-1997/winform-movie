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
    public partial class Login : Form
    {
        #region
        //SqlConnection connect = new SqlConnection();
        //SqlCommand command = new SqlCommand();
        //SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        //SqlCommandBuilder builder;
        #endregion
        Myconnect db = new Myconnect();
        public Login()
        {
            InitializeComponent();
        }
        public string acc_user = "";
        public string acc_password = "";
        public string authorization = "";
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Clear();
            txtPassword.PasswordChar = '*';
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor= Color.FromArgb(81, 170, 232);
           // button1.FontChanged
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(81, 170, 232);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acc_user = txtUser.Text;
            acc_password = txtPassword.Text;
            if (string.IsNullOrEmpty(acc_user))
            {

                MessageBox.Show("Please enter UserName", "UserName not Empty!!!");
                return;
            }
            else if (string.IsNullOrEmpty(acc_password))
            {
                MessageBox.Show("Please enter PassWord", "PassWord not Empty!!!");
                return;
            }
            else
            {
                #region cách 1
                //connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                //command.Connection = connect;
                //command.CommandText = "select acc_id,acc_user,acc_password,acc_authorization from account where acc_user='" + acc_user + "' and acc_password= '" + acc_password + "' ";
                //command.CommandType = CommandType.Text;
                //command.CommandTimeout = 30;
                //dataAdapter.SelectCommand = command;
                //dataAdapter.Fill(ds);
                //var dt = ds.Tables[0];
                //if (dt.Rows.Count > 0)
                //{
                //    string usertype = dt.Rows[0][3].ToString();
                //    MessageBox.Show(dt.Rows[0][3].ToString());
                //    if (usertype.Trim()=="admin")
                //    {
                //        MessageBox.Show("admin");
                //    }
                //    else if (usertype == "user")
                //    {
                //        MessageBox.Show("user");
                //    }
                //    MessageBox.Show("Welcome " + txtUser.Text);
                //    new Form1().ShowDialog();
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Login Error");
                //}
                #endregion
                SqlCommand cmd = new SqlCommand("Login", db.con);
                cmd.CommandType = CommandType.StoredProcedure;
                db.con.Open();
                cmd.Parameters.AddWithValue("@acc_user", txtUser.Text);
                cmd.Parameters.AddWithValue("@acc_password", txtPassword.Text);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Read();
                    var type_move = rd[3].ToString();
                    if (type_move.Trim() == "admin")
                    {
                        Myconnect.type = "Admin";
                    }
                    else if (type_move.Trim() == "user")
                    {
                        Myconnect.type = "User";
                    }
                    MessageBox.Show("Welcome " + txtUser.Text);
                    new Form1().ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed!!!!!");
                }
            }
        }
    }
}
