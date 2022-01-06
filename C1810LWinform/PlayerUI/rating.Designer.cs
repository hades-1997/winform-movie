
namespace PlayerUI
{
    partial class rating
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
            this.dgvRating = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.AllowUserToDeleteRows = false;
            this.dgvRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRating.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.dgvRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRating.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.dgvRating.Location = new System.Drawing.Point(0, 0);
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.ReadOnly = true;
            this.dgvRating.Size = new System.Drawing.Size(757, 352);
            this.dgvRating.TabIndex = 0;
            this.dgvRating.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRating_CellContentClick);
            this.dgvRating.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRating_CellContentDoubleClick);
            // 
            // rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 352);
            this.Controls.Add(this.dgvRating);
            this.Name = "rating";
            this.Text = "rating";
            this.Load += new System.EventHandler(this.rating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRating;
    }
}