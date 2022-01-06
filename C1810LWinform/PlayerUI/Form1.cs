using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
            loadmenu();
        }
        public void loadmenu()
        {
            //if ( == "Amin")
            //{
                //btnPlaylist.Visible = true;
                //btnTools.Visible = true;
                //btnActor.Visible = true;
                //button4.Visible = true;
                //button1.Visible = true;
                //button6.Visible = true;
            //}
            //else if (type_move == "User")
            //{
            //    btnPlaylist.Visible = false;
            //    btnTools.Visible = false;
            //    btnActor.Visible = true;
            //    button4.Visible = false;
            //    button1.Visible = false;
            //    //button6.Visible = false;
            //}
        }
        private void hideSubMenu()
        {
            //panelMediaSubMenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
            //panelActorSubMenu.Visible = false;
            //panelGenresSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelPlaylistSubMenu);
                openChildForm(new movies());
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
           // openChildForm(new listAllMovie());

            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelToolsSubMenu);
                openChildForm(new Director());
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //openChildForm(new Director());
            //..
            //your codes
            //..
            //hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //openChildForm(new addDirector());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //showSubMenu(panelActorSubMenu);
                openChildForm(new actor());

        }
        #region ActorSubMenu
        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new actor());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
           // openChildForm(new addActor());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion
        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new genres());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           // openChildForm(new adddirection());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //showSubMenu(panelGenresSubMenu);
                openChildForm(new genres());

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new rating());
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {
            if(Myconnect.type == "Admin")
            {
                btnPlaylist.Visible = true;
                btnTools.Visible = true;
                btnActor.Visible = true;
                button4.Visible = true;
            }
            else if (Myconnect.type == "User")
            {
                btnPlaylist.Visible = false;
                btnTools.Visible = false;
                btnActor.Visible = false;
                button4.Visible = false;
            }
        }

        private void hotmovie_Click(object sender, EventArgs e)
        {
            openChildForm(new MoviesTop());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            openChildForm(new review());
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            openChildForm(new rating());
        }
    }
}
