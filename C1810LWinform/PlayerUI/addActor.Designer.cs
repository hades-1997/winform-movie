
namespace PlayerUI
{
    partial class addActor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addActor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtln = new System.Windows.Forms.TextBox();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtfn
            // 
            this.txtfn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfn.Location = new System.Drawing.Point(87, 82);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(209, 13);
            this.txtfn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // txtln
            // 
            this.txtln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtln.Location = new System.Drawing.Point(87, 141);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(209, 13);
            this.txtln.TabIndex = 1;
            // 
            // rdbnam
            // 
            this.rdbnam.Checked = true;
            this.rdbnam.Location = new System.Drawing.Point(207, 176);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(85, 37);
            this.rdbnam.TabIndex = 2;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.SeaGreen;
            this.save.Location = new System.Drawing.Point(87, 248);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 31);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(207, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Canel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            this.rdbNu.Location = new System.Drawing.Point(113, 179);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(77, 30);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please Enter The Full Information Below";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(353, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(87, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 13);
            this.txtid.TabIndex = 8;
            this.txtid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(83, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(82, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 2);
            this.panel2.TabIndex = 9;
            // 
            // addActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(508, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rdbnam);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "addActor";
            this.Text = "addActor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}