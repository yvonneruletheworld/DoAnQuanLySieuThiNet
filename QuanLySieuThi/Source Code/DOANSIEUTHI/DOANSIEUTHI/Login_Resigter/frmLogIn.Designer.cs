namespace DOANSIEUTHI
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnLogIn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSwitch1 = new Guna.UI.WinForms.GunaSwitch();
            this.matkhau_txt = new Guna.UI.WinForms.GunaTextBox();
            this.username_txt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPictureBox2;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::DOANSIEUTHI.Properties.Resources.E_commerce;
            this.gunaPictureBox2.Location = new System.Drawing.Point(-423, -65);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(1197, 731);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.gunaPanel1.Controls.Add(this.btnThoat);
            this.gunaPanel1.Controls.Add(this.btnLogIn);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaSwitch1);
            this.gunaPanel1.Controls.Add(this.matkhau_txt);
            this.gunaPanel1.Controls.Add(this.username_txt);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(347, 649);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnThoat.BorderSize = 3;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(181, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Radius = 18;
            this.btnThoat.Size = new System.Drawing.Size(123, 56);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.AnimationHoverSpeed = 0.07F;
            this.btnLogIn.AnimationSpeed = 0.03F;
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.btnLogIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.btnLogIn.BorderSize = 2;
            this.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogIn.Image = null;
            this.btnLogIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogIn.Location = new System.Drawing.Point(23, 456);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogIn.OnHoverImage = null;
            this.btnLogIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogIn.Radius = 18;
            this.btnLogIn.Size = new System.Drawing.Size(124, 56);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Đăng Nhập";
            this.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(62, 398);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(85, 28);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Ghi Nhớ";
            // 
            // gunaSwitch1
            // 
            this.gunaSwitch1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.gunaSwitch1.Checked = true;
            this.gunaSwitch1.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.gunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.gunaSwitch1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gunaSwitch1.Location = new System.Drawing.Point(23, 398);
            this.gunaSwitch1.Name = "gunaSwitch1";
            this.gunaSwitch1.Size = new System.Drawing.Size(72, 33);
            this.gunaSwitch1.TabIndex = 3;
            // 
            // matkhau_txt
            // 
            this.matkhau_txt.BackColor = System.Drawing.Color.Transparent;
            this.matkhau_txt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.matkhau_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.matkhau_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matkhau_txt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.matkhau_txt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.matkhau_txt.FocusedForeColor = System.Drawing.Color.White;
            this.matkhau_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau_txt.ForeColor = System.Drawing.Color.White;
            this.matkhau_txt.Location = new System.Drawing.Point(23, 328);
            this.matkhau_txt.Name = "matkhau_txt";
            this.matkhau_txt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.matkhau_txt.PasswordChar = '●';
            this.matkhau_txt.Radius = 8;
            this.matkhau_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matkhau_txt.SelectedText = "";
            this.matkhau_txt.Size = new System.Drawing.Size(291, 48);
            this.matkhau_txt.TabIndex = 2;
            this.matkhau_txt.Text = "Pass";
            this.matkhau_txt.UseSystemPasswordChar = true;
            this.matkhau_txt.TextChanged += new System.EventHandler(this.matkhau_txt_TextChanged);
            this.matkhau_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogIn_KeyPress);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.Transparent;
            this.username_txt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.username_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(169)))));
            this.username_txt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username_txt.FocusedForeColor = System.Drawing.Color.Transparent;
            this.username_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.White;
            this.username_txt.Location = new System.Drawing.Point(23, 253);
            this.username_txt.Name = "username_txt";
            this.username_txt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.username_txt.PasswordChar = '\0';
            this.username_txt.Radius = 8;
            this.username_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username_txt.SelectedText = "";
            this.username_txt.Size = new System.Drawing.Size(291, 48);
            this.username_txt.TabIndex = 1;
            this.username_txt.Text = "UserName";
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            this.username_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogIn_KeyPress);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DOANSIEUTHI.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(51, 61);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(241, 165);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(336, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(711, 649);
            this.gunaPanel2.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 649);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnLogIn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaSwitch gunaSwitch1;
        private Guna.UI.WinForms.GunaTextBox matkhau_txt;
        private Guna.UI.WinForms.GunaTextBox username_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}