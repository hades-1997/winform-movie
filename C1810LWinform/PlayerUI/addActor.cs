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
    public partial class addActor : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder builder;
        Myconnect db = new Myconnect();
        public addActor(string act_id)
        {
            InitializeComponent();
            this.act_id = act_id;
            if (string.IsNullOrEmpty(act_id)) // nếu act_id không có => thêm mới dien vien
            {
                this.Text = "Thêm Mới Diễn Viên";
            }
            else
            {
                this.Text = "Cập Nhật Thông Tin Diễn Viên";
                this.act_id = @act_id;
                SqlCommand cmd = new SqlCommand("select * from actor where act_id ='"+@act_id+"'", db.con);
                cmd.CommandType = CommandType.Text;
                db.con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    txtid.Text = @act_id;
                    txtfn.Text = rd["act_fname"].ToString().Trim();
                    txtln.Text = rd["act_lname"].ToString().Trim();
                    var gender_actor = rd["act_gender"].ToString();
                    if (gender_actor.Trim()== "0")
                    {
                        rdbnam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                }

            }
        }
        private string act_id;
        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(act_id)) // nếu act_id không có => thêm mới dien vien
            {

                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                var query = "insert into actor values (@act_fname,@act_lname,@act_gender) where act_id='"+act_id+"'";
                command.CommandText = "insertActor";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@act_fname", txtfn.Text);
                command.Parameters.AddWithValue("@act_lname", txtln.Text);
                command.Parameters.AddWithValue("@act_gender", rdbnam.Checked ? "0" : "1");
                //if(pictureBox1.Image != null)
                //{
                //    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                //    byte[] pic = ImageToByTes(bitmap, System.Drawing.Imaging.ImageFormat.Jpeg);
                //    command.Parameters.AddWithValue("@act_image", pic);

                //}
                //else
                //{
                //    //command.Parameters.AddWithValue("@act_image", ).Value = DbNull.Value;
                //}

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
                txtfn.DataBindings.Clear();
                txtln.DataBindings.Clear();
                //rdbnam.DataBindings.Clear();
            }
            else
            {
                #region store produre error het cach
                // this.act_id = @act_id;
                //connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                //command.Connection = connect;
                //command.CommandTimeout = 30;
                //var query = "update actor set @act_fname,@act_lname,@act_gender";
                //command.CommandText = "updateActor";
                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@act_fname", txtfn.Text);
                //command.Parameters.AddWithValue("@act_lname", txtln.Text);
                //command.Parameters.AddWithValue("@act_gender", rdbnam.Checked ? "0" : "1");
                //dataAdapter.SelectCommand = command;
                #endregion
                connect.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                command.Connection = connect;
                command.CommandTimeout = 30;
                //"UPDATE actor SET act_fname=@act_fname,act_lname=@act_lname,act_gender=@act_gender where act_id="+act_id+ ""
                command.CommandText = "UPDATE actor SET act_fname=@act_fname,act_lname=@act_lname,act_gender=@act_gender where act_id="+act_id+ "";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@act_fname", txtfn.Text);
                command.Parameters.AddWithValue("@act_lname", txtln.Text);
                command.Parameters.AddWithValue("@act_gender", rdbnam.Checked ? "0" : "1");
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
                txtfn.DataBindings.Clear();
                txtln.DataBindings.Clear();
            }

        }
        //private byte[] ImageToByTes(Image image, System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (System.IO.MemoryStream memStream = new System.IO.MemoryStream())
        //    {
        //        image.Save(memStream, format);
        //        return memStream.ToArray();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    // display image in picture box  
            //    pictureBox1.Image = new Bitmap(open.FileName);
            //    // image file path  
            //    //button1.Text = open.FileName;
            //}

        }

        //private void txtID_TextChanged(object sender, EventArgs e)
        //{
        //    //txtID.Visible = false;
        //}
    }
}
