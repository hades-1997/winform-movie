using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class addMovie : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommandBuilder builder;
        DateTime ngayxuatban;
        public addMovie(string mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
        }
        private string mov_id;

        private void addMovie_Load(object sender, EventArgs e)
        {

            Genres();
            Actor();
            Director();
        }
        private void Genres()
        {
            DataSet ds = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "selectGenres";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "selectGenres");
            var dt = ds.Tables[0];
            foreach (DataRow datarow in dt.Rows)
            {
                ckdGenres.Items.Add(datarow["gen_title"]);
            }
        }
        private void Director()
        {
            DataSet dir = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "SelectDirector";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dir, "SelectDirector");
            var dr = dir.Tables[0];
            foreach (DataRow datarow in dr.Rows)
            {
                ckdDirector.Items.Add(datarow["dir_lname"]);
            }
        }
        private void Actor()
        {
            DataSet act = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandText = "SelectAllActor";
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 30;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(act, "SelectAllActor");
            var actor = act.Tables[0];
            foreach (DataRow datarow in actor.Rows)
            {
                ckdActor.Items.Add(datarow["act_lname"]);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                var year = Convert.ToInt32(txtyear.Text);
                var time = Convert.ToInt32(txtlength.Text);
                try
                {
                    ngayxuatban = DateTime.ParseExact(maskedTextBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Error");
                    maskedTextBox1.Select();
                }
                command.CommandText = "insert into movies (mov_title,mov_year,mov_time,mov_lang,mov_dt_rel,mov_rel_country) values ('" + txttitle.Text + "'," + year + "," + time + ",'" + txtlangue.Text + "','" + ngayxuatban.ToString("dd/MM/yyyy") + "','" + txtcountry.Text + "')";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@mov_title", txttitle.Text);
                command.Parameters.AddWithValue("@mov_year", year);
                command.Parameters.AddWithValue("@mov_time", time);
                command.Parameters.AddWithValue("@mov_lang", txtlangue.Text);
                command.Parameters.AddWithValue("@mov_dt_rel", ngayxuatban.ToString("dd/MM/yyyy"));
                command.Parameters.AddWithValue("@mov_rel_country", txtcountry.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                #region
                for (int i = 0; i < ckdGenres.Items.Count; i++)
                {
                    command.Parameters.Clear();
                    if (ckdGenres.GetItemChecked(i))
                    {
                        string str = (string)ckdGenres.Items[i];
                        //MessageBox.Show("" + str);
                        command.CommandText = "select * from genres where gen_title='" + str + "' ";
                        command.CommandType = CommandType.Text;
                        dataAdapter.SelectCommand = command;
                        DataSet genres = new DataSet();
                        dataAdapter.Fill(genres);
                        var dr = genres.Tables[0];
                        foreach (DataRow datarow in dr.Rows)
                        {
                            command.Parameters.Clear();
                            var id = datarow["gen_id"];
                            command.CommandText = "insertMovieGenres";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@gen_id", id);
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                    }
                }
                #endregion
                #region actor
                for (int i = 0; i < ckdGenres.Items.Count; i++)
                {
                    command.Parameters.Clear();
                    if (ckdActor.GetItemChecked(i))
                    {
                        string act = (string)ckdActor.Items[i];
                        //MessageBox.Show("" + act);
                        command.CommandText = "select * from actor where act_lname ='" + act + "'";
                        command.CommandType = CommandType.Text;
                        dataAdapter.SelectCommand = command;
                        DataSet act_i = new DataSet();
                        dataAdapter.Fill(act_i);
                        var dr = act_i.Tables[0];
                        foreach (DataRow datarow in dr.Rows)
                        {
                            command.Parameters.Clear();
                            var act_id = datarow["act_id"];
                            command.CommandText = "inserMovieCast";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@act_id", act_id);
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                    }
                }
                #endregion
                #region director
                for (int i = 0; i < ckdDirector.Items.Count; i++)
                {
                    command.Parameters.Clear();
                    if (ckdDirector.GetItemChecked(i))
                    {
                        string dirct = (string)ckdDirector.Items[i];
                       // MessageBox.Show("" + dirct);
                        command.CommandText = "select * from director where dir_lname= '" + dirct + "'";
                        command.CommandType = CommandType.Text;
                        dataAdapter.SelectCommand = command;
                        DataSet dir = new DataSet();
                        dataAdapter.Fill(dir);
                        var dirt_lname = dir.Tables[0];
                        foreach (DataRow datarow in dirt_lname.Rows)
                        {
                            command.Parameters.Clear();
                            var dir_id = datarow["dir_id"];
                            command.CommandText = "insertMovieDirector";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@dir_id", dir_id);
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                        }
                    }
                }
                #endregion
                command.ExecuteNonQuery();
                MessageBox.Show("Insert Sucess!!!");
                connect.Close();
                this.Hide();
            }
            catch 
            {
                MessageBox.Show("Insert Error!!!");

            }
        }
    }
}
