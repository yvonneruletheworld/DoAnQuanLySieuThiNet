namespace GUI
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ten = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_icon = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ten
            // 
            this.lbl_ten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ten.ForeColor = System.Drawing.Color.White;
            this.lbl_ten.Location = new System.Drawing.Point(97, 16);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(327, 44);
            this.lbl_ten.TabIndex = 0;
            this.lbl_ten.Text = "label1";
            this.lbl_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::GUI.Properties.Resources.icons8_close_32;
            this.btn_close.Location = new System.Drawing.Point(485, 18);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(66, 80);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            // 
            // btn_icon
            // 
            this.btn_icon.BackColor = System.Drawing.Color.Transparent;
            this.btn_icon.Image = global::GUI.Properties.Resources.icons8_male_user_32;
            this.btn_icon.Location = new System.Drawing.Point(20, 31);
            this.btn_icon.Name = "btn_icon";
            this.btn_icon.Size = new System.Drawing.Size(53, 57);
            this.btn_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_icon.TabIndex = 2;
            this.btn_icon.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(97, 66);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(329, 44);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Thời gian truy cập:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 1F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(3, 91);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 28);
            this.lblUser.TabIndex = 4;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btn_icon);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_ten);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(564, 128);
            this.MouseEnter += new System.EventHandler(this.UC_Account_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Account_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_icon;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
    }
}
