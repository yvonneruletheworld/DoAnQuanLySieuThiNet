namespace GUI
{
    partial class UC_Message
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
            this.components = new System.ComponentModel.Container();
            this.lbl_mess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mess
            // 
            this.lbl_mess.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_mess.ForeColor = System.Drawing.Color.White;
            this.lbl_mess.Location = new System.Drawing.Point(110, 16);
            this.lbl_mess.Name = "lbl_mess";
            this.lbl_mess.Size = new System.Drawing.Size(332, 91);
            this.lbl_mess.TabIndex = 0;
            this.lbl_mess.Text = "label1";
            this.lbl_mess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::GUI.Properties.Resources.icons8_close_32;
            this.btn_close.Location = new System.Drawing.Point(449, 24);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(66, 80);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_icon
            // 
            this.btn_icon.BackColor = System.Drawing.Color.Transparent;
            this.btn_icon.Image = global::GUI.Properties.Resources.icons8_info_48;
            this.btn_icon.Location = new System.Drawing.Point(22, 19);
            this.btn_icon.Name = "btn_icon";
            this.btn_icon.Size = new System.Drawing.Size(76, 88);
            this.btn_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_icon.TabIndex = 2;
            this.btn_icon.TabStop = false;
            // 
            // UC_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(517, 128);
            this.Controls.Add(this.btn_icon);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_mess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Message";
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_mess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_icon;
    }
}
