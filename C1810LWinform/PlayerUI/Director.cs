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
    public partial class Director : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;

        public Director()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void Director_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //dgvDirector.DataSource = null;
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "SelectDirector";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "SelectDirector");
            dgvDirector.DataSource = ds.Tables[0];
        }

        private void dgvDirector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dir_name = dgvDirector.Rows[e.RowIndex].Cells["dir_lname"].Value.ToString();
                string message = "Please select action below (Yes=Edit, No=Close, Cancel=Delete)?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var dir_id = dgvDirector.Rows[e.RowIndex].Cells["dir_id"].Value.ToString();
                    ds.Tables[0].Clear();
                    new addDirector(dir_id).ShowDialog();
                    LoadData();
                }
                else if(result == DialogResult.No) {
                }
                else
                {
                    var dir_id = dgvDirector.Rows[e.RowIndex].Cells["dir_id"].Value.ToString();
                    connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                    command.Connection = connect;
                    command.CommandText = "delete from director where dir_id=" + dir_id + "";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;
                    dataAdapter.SelectCommand = command;
                    try
                    {
                        connect.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Delete Sucess");
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
                    ds.Tables[0].Clear();
                    LoadData();
                }
               
                //DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Thông Tin Của: "+ dir_name, "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //switch (dialogResult)
                //{
                //    case DialogResult.Yes:
                //        var dir_id = dgvDirector.Rows[e.RowIndex].Cells["dir_id"].Value.ToString();
                //        ds.Tables[0].Clear();
                //        new addDirector(dir_id).ShowDialog();
                //        LoadData();
                //        break;
                //    case DialogResult.No:
                //        //this.Hide();
                //        break;
                //}

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new addDirector(null).ShowDialog();
            ds.Tables[0].Clear();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "select * from director where dir_lname='" + txtTimKiem.Text+"'";
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgvDirector.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandText = "select * from director";
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 30;
                dataAdapter.SelectCommand = command;
                //DataTable dt = new DataTable();
                dataAdapter.Fill(ds, "director");
                dgvDirector.DataSource = ds.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "select * from director where dir_lname='" + txtTimKiem.Text + "'";
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgvDirector.DataSource = dt;
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "select * from director";
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            //DataTable dt = new DataTable();
            dataAdapter.Fill(ds, "director");
            dgvDirector.DataSource = ds.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new addDirector(null).ShowDialog();
            ds.Tables[0].Clear();
            LoadData();
        }
    }
}
