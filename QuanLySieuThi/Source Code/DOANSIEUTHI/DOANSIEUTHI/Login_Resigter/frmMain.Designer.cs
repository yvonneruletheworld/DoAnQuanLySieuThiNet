namespace DOANSIEUTHI.Login_Resigter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBaoCao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEmp = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCoop = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTransition = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHome = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaPanel1.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaGradientPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(134, 830);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(133, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1019, 830);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel2;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.button1);
            this.gunaGradientPanel1.Controls.Add(this.btnExit);
            this.gunaGradientPanel1.Controls.Add(this.btnBaoCao);
            this.gunaGradientPanel1.Controls.Add(this.btnEmp);
            this.gunaGradientPanel1.Controls.Add(this.btnCoop);
            this.gunaGradientPanel1.Controls.Add(this.btnTransition);
            this.gunaGradientPanel1.Controls.Add(this.btnProduct);
            this.gunaGradientPanel1.Controls.Add(this.btnHome);
            this.gunaGradientPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(251)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(15)))), ((int)(((byte)(114)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(133, 830);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 622);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "<<";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AnimationHoverSpeed = 0.07F;
            this.btnBaoCao.AnimationSpeed = 0.03F;
            this.btnBaoCao.BaseColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BorderColor = System.Drawing.Color.Black;
            this.btnBaoCao.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnBaoCao.CheckedBaseColor = System.Drawing.Color.White;
            this.btnBaoCao.CheckedBorderColor = System.Drawing.Color.White;
            this.btnBaoCao.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnBaoCao.CheckedImage = null;
            this.btnBaoCao.CheckedLineColor = System.Drawing.Color.White;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaoCao.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBaoCao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBaoCao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.Location = new System.Drawing.Point(-2, 500);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnBaoCao.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaoCao.OnHoverImage = null;
            this.btnBaoCao.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaoCao.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnBaoCao.Size = new System.Drawing.Size(137, 63);
            this.btnBaoCao.TabIndex = 9;
            this.btnBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEmp
            // 
            this.btnEmp.AnimationHoverSpeed = 0.07F;
            this.btnEmp.AnimationSpeed = 0.03F;
            this.btnEmp.BaseColor = System.Drawing.Color.Transparent;
            this.btnEmp.BorderColor = System.Drawing.Color.Black;
            this.btnEmp.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnEmp.CheckedBaseColor = System.Drawing.Color.White;
            this.btnEmp.CheckedBorderColor = System.Drawing.Color.White;
            this.btnEmp.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEmp.CheckedImage = null;
            this.btnEmp.CheckedLineColor = System.Drawing.Color.White;
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmp.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmp.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEmp.Image")));
            this.btnEmp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmp.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEmp.Location = new System.Drawing.Point(-2, 437);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnEmp.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnEmp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmp.OnHoverImage = null;
            this.btnEmp.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEmp.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnEmp.Size = new System.Drawing.Size(137, 63);
            this.btnEmp.TabIndex = 8;
            this.btnEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCoop
            // 
            this.btnCoop.AnimationHoverSpeed = 0.07F;
            this.btnCoop.AnimationSpeed = 0.03F;
            this.btnCoop.BaseColor = System.Drawing.Color.Transparent;
            this.btnCoop.BorderColor = System.Drawing.Color.Black;
            this.btnCoop.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCoop.CheckedBaseColor = System.Drawing.Color.White;
            this.btnCoop.CheckedBorderColor = System.Drawing.Color.White;
            this.btnCoop.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCoop.CheckedImage = null;
            this.btnCoop.CheckedLineColor = System.Drawing.Color.White;
            this.btnCoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCoop.FocusedColor = System.Drawing.Color.Empty;
            this.btnCoop.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoop.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCoop.Image = ((System.Drawing.Image)(resources.GetObject("btnCoop.Image")));
            this.btnCoop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCoop.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCoop.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCoop.Location = new System.Drawing.Point(-2, 375);
            this.btnCoop.Name = "btnCoop";
            this.btnCoop.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnCoop.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnCoop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCoop.OnHoverImage = null;
            this.btnCoop.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCoop.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnCoop.Size = new System.Drawing.Size(137, 63);
            this.btnCoop.TabIndex = 7;
            this.btnCoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTransition
            // 
            this.btnTransition.AnimationHoverSpeed = 0.07F;
            this.btnTransition.AnimationSpeed = 0.03F;
            this.btnTransition.BaseColor = System.Drawing.Color.Transparent;
            this.btnTransition.BorderColor = System.Drawing.Color.Black;
            this.btnTransition.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnTransition.CheckedBaseColor = System.Drawing.Color.White;
            this.btnTransition.CheckedBorderColor = System.Drawing.Color.White;
            this.btnTransition.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransition.CheckedImage = null;
            this.btnTransition.CheckedLineColor = System.Drawing.Color.White;
            this.btnTransition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransition.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransition.FocusedColor = System.Drawing.Color.Empty;
            this.btnTransition.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransition.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransition.Image = ((System.Drawing.Image)(resources.GetObject("btnTransition.Image")));
            this.btnTransition.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTransition.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransition.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTransition.Location = new System.Drawing.Point(-2, 312);
            this.btnTransition.Name = "btnTransition";
            this.btnTransition.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnTransition.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransition.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTransition.OnHoverImage = null;
            this.btnTransition.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTransition.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnTransition.Size = new System.Drawing.Size(137, 63);
            this.btnTransition.TabIndex = 6;
            this.btnTransition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProduct
            // 
            this.btnProduct.AnimationHoverSpeed = 0.07F;
            this.btnProduct.AnimationSpeed = 0.03F;
            this.btnProduct.BaseColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderColor = System.Drawing.Color.Black;
            this.btnProduct.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnProduct.CheckedBaseColor = System.Drawing.Color.White;
            this.btnProduct.CheckedBorderColor = System.Drawing.Color.White;
            this.btnProduct.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnProduct.CheckedImage = null;
            this.btnProduct.CheckedLineColor = System.Drawing.Color.White;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProduct.Location = new System.Drawing.Point(-3, 249);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnProduct.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProduct.OnHoverImage = null;
            this.btnProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProduct.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnProduct.Size = new System.Drawing.Size(137, 63);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BaseColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Black;
            this.btnHome.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnHome.Checked = true;
            this.btnHome.CheckedBaseColor = System.Drawing.Color.White;
            this.btnHome.CheckedBorderColor = System.Drawing.Color.White;
            this.btnHome.CheckedForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHome.CheckedImage = null;
            this.btnHome.CheckedLineColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.Location = new System.Drawing.Point(0, 186);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHome.OnPressedColor = System.Drawing.Color.Bisque;
            this.btnHome.Size = new System.Drawing.Size(137, 63);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = global::DOANSIEUTHI.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(3, 34);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(134, 74);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 830);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btnHome;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaoCao;
        private Guna.UI.WinForms.GunaAdvenceButton btnEmp;
        private Guna.UI.WinForms.GunaAdvenceButton btnCoop;
        private Guna.UI.WinForms.GunaAdvenceButton btnTransition;
        private Guna.UI.WinForms.GunaAdvenceButton btnProduct;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}