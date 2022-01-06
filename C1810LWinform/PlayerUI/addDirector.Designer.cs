
namespace PlayerUI
{
    partial class addDirector
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
            this.label3 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.savedirector = new System.Windows.Forms.Button();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please Enter The Full Information Below";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.SeaGreen;
            this.close.Location = new System.Drawing.Point(233, 155);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 35);
            this.close.TabIndex = 8;
            this.close.Text = "Cancel";
            this.close.UseVisualStyleBackColor = false;
            // 
            // savedirector
            // 
            this.savedirector.BackColor = System.Drawing.Color.SeaGreen;
            this.savedirector.ForeColor = System.Drawing.Color.White;
            this.savedirector.Location = new System.Drawing.Point(84, 155);
            this.savedirector.Name = "savedirector";
            this.savedirector.Size = new System.Drawing.Size(119, 36);
            this.savedirector.TabIndex = 9;
            this.savedirector.Text = "Save";
            this.savedirector.UseVisualStyleBackColor = false;
            this.savedirector.Click += new System.EventHandler(this.savedirector_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlastname.ForeColor = System.Drawing.Color.White;
            this.txtlastname.Location = new System.Drawing.Point(88, 116);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(205, 13);
            this.txtlastname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfirstname.ForeColor = System.Drawing.Color.White;
            this.txtfirstname.Location = new System.Drawing.Point(84, 73);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(205, 13);
            this.txtfirstname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(84, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 2);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(84, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 2);
            this.panel2.TabIndex = 12;
            // 
            // addDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(382, 251);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.close);
            this.Controls.Add(this.savedirector);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "addDirector";
            this.Text = "addDirector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button savedirector;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}