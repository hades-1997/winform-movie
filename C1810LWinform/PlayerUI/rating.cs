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
    public partial class rating : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        Myconnect db = new Myconnect();
        public rating()
        {
            InitializeComponent();
        }

        private void rating_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandTimeout = 30;
            command.CommandText = "selectRating";
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "selectRating");
            dgvRating.DataSource = ds.Tables[0];
        }

        private void dgvRating_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Please select action below ?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var gen_id = dgvRating.Rows[e.RowIndex].Cells["mov_id"].Value.ToString();
                ds.Tables[0].Clear();
                new addComent(gen_id).ShowDialog();
                LoadData();
            }
            else if (result == DialogResult.No)
            {
            }
            else
            {

            }
        }

        private void dgvRating_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
