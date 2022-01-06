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
    public partial class movies : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        public movies()
        {
            InitializeComponent();
        }

        private void movies_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //dgvMovies.DataSource = null;
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectMovies";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "selectMovies");
            dgvMovies.DataSource = ds.Tables[0];
            command.Parameters.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new addMovie(null).ShowDialog();
            ds.Tables[0].Clear();
            LoadData();
        }
    }
}
