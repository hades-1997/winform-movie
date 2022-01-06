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
    public partial class actor : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        public actor()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void actor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "SelectAllActor";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "SelectAllActor");
            //ds.Tables[0].Clear();
            dgvActor.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvActor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string message = "Please select action below (Yes=Edit, No=Close, Cancel=Delete)?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var act_id = dgvActor.Rows[e.RowIndex].Cells["act_id"].Value.ToString();
                    ds.Tables[0].Clear();
                    new addActor(act_id).ShowDialog();
                    LoadData();
                }
                else if (result == DialogResult.No)
                {
                }
                else
                {
                    //ds.Tables[0].Clear();
                    //new addActor(act_id).ShowDialog();
                    //LoadData();
                    var act_id = dgvActor.Rows[e.RowIndex].Cells["act_id"].Value.ToString();
                    connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                    command.Connection = connect;
                    command.CommandText = "delete from actor where act_id=" + act_id + "";
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearch.Text;
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "select * from actor where act_lname='" + txtSearch.Text + "'";
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            //ds.Tables[0].Clear();
            dgvActor.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tukhoa == "")
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandText = "SelectAllActor";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(ds, "SelectAllActor");
                //ds.Tables[0].Clear();
                dgvActor.DataSource = ds.Tables[0];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new addActor(null).ShowDialog();
            ds.Tables[0].Clear();
            LoadData();
        }
    }
}
