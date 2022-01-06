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
    public partial class addComent : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        
        SqlCommandBuilder builder;
        Myconnect db = new Myconnect();
        private int count = 0;
        public addComent(string mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
            this.Text = "Bình Luận Về Bộ Phim";

            load();
            LoadComment();
            LoadNumView();
        }
        private void load()
        {
            SqlCommand cmd = new SqlCommand("select r.rev_id,m.mov_title,rev.rev_name from rating  r inner join movies m on r.mov_id = m.mov_id inner join reviewer rev on r.rev_id = rev.rev_id where m.mov_id =" + mov_id + "", db.con);
            cmd.CommandType = CommandType.Text;
            db.con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Read();
                //txtid.Text = @act_id;
                txttitle.Text = rd["mov_title"].ToString().Trim();
                //revID.Text= rd["rev_id"].ToString().Trim();
            }

            db.con.Close();
        }
        private void LoadNumView()
        {

            //DataSet num = new DataSet();
            //connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            //command.Connection = connect;
            //command.CommandTimeout = 30;
            //command.CommandText = "	select SUM(r.num_o_ratings) from rating  r inner join movies m on r.mov_id = m.mov_id inner join reviewer rev on r.rev_id = rev.rev_id  where m.mov_id = " + mov_id + "";
            //command.CommandType = CommandType.Text;
            //dataAdapter.SelectCommand = command;
            //dataAdapter.Fill(num);
            ////            command.ExecuteReader();
            //numstar.Text = num.num["num_o_ratings"].ToString();
            //connect.Close();
        }
        private void LoadComment()
        {
            DataSet ds = new DataSet();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandTimeout = 30;
            command.CommandText = "	select r.mov_id,rev.rev_name,r.rev_stars from rating  r inner join movies m on r.mov_id = m.mov_id inner join reviewer rev on r.rev_id = rev.rev_id where r.mov_id = " + mov_id + "";
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds, "selectRating");
            dgvcoment.DataSource = ds.Tables[0];
        }
        private string mov_id;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString();
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            if (bunifuRating1.Value == 1)
            {
                starnum.Text = Convert.ToString(1);
            }
            if (bunifuRating1.Value == 2)
            {
                starnum.Text = Convert.ToString(2);
            }
            if (bunifuRating1.Value == 3)
            {
                starnum.Text = Convert.ToString(3);
            }
            if (bunifuRating1.Value == 4)
            {
                starnum.Text = Convert.ToString(4);
            }
            if (bunifuRating1.Value == 5)
            {
                starnum.Text = Convert.ToString(5);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            command.Connection = connect;
            command.CommandTimeout = 30;
            command.CommandText = "addReviews";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@rev_name", RtxtReviews.Text);
            command.Parameters.AddWithValue("@mov_id", mov_id);
            var num_star = Convert.ToInt32(starnum.Text);
            command.Parameters.AddWithValue("@rev_stars", num_star);
            //var r_id = Convert.ToInt32(revID.Text);
            // command.Parameters.AddWithValue("@rev_id", r_id);
            connect.Open();
            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Comment Sucess");
                    this.Hide();
                    new rating();
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
    }
}
