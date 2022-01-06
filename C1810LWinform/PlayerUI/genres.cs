using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PlayerUI
{
    public partial class genres : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        public genres()
        {
            InitializeComponent();
        }

        private void genres_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectGenres";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "selectGenres");
            //ds.Tables[0].Clear();
            dgvGenres.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvGenres_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string message = "Please select action below (Yes=Edit, No=Close, Cancel=Delete)?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var gen_id = dgvGenres.Rows[e.RowIndex].Cells["gen_id"].Value.ToString();
                    ds.Tables[0].Clear();
                    new addGenres(gen_id).ShowDialog();
                    LoadData();
                }
                else if (result == DialogResult.No)
                {
                }
                else
                {
                    var gen_id = dgvGenres.Rows[e.RowIndex].Cells["gen_id"].Value.ToString();
                    connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                    command.Connection = connect;
                    command.CommandText = "delete from genres where gen_id=" + gen_id + "";
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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new addGenres(null).ShowDialog();
            ds.Tables[0].Clear();
            LoadData();
        }
    }
}
