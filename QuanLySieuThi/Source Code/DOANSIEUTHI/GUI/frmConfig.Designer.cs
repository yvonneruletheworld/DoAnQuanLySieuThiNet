namespace GUI
{
    partial class frmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboSeverName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(33, 32, 33, 32);
            this.panel1.Size = new System.Drawing.Size(533, 442);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCan);
            this.panel6.Controls.Add(this.btnOk);
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(33, 321);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(16);
            this.panel6.Size = new System.Drawing.Size(467, 89);
            this.panel6.TabIndex = 4;
            // 
            // btnCan
            // 
            this.btnCan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCan.Location = new System.Drawing.Point(270, 16);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(127, 57);
            this.btnCan.TabIndex = 2;
            this.btnCan.Text = "Hủy";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(143, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(127, 57);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Nhập";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Location = new System.Drawing.Point(16, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 3, 22, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 57);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboData);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(33, 249);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(16);
            this.panel5.Size = new System.Drawing.Size(467, 72);
            this.panel5.TabIndex = 3;
            // 
            // cboData
            // 
            this.cboData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboData.Enabled = false;
            this.cboData.FormattingEnabled = true;
            this.cboData.Location = new System.Drawing.Point(148, 16);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(303, 38);
            this.cboData.TabIndex = 4;
            this.cboData.DropDown += new System.EventHandler(this.cboData_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database     ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(33, 176);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(16);
            this.panel4.Size = new System.Drawing.Size(467, 73);
            this.panel4.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(149, 16);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(302, 37);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.txt_Change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password     ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(33, 104);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(16);
            this.panel3.Size = new System.Drawing.Size(467, 72);
            this.panel3.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(149, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(302, 37);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txt_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name  ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboSeverName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(33, 32);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(467, 72);
            this.panel2.TabIndex = 0;
            // 
            // cboSeverName
            // 
            this.cboSeverName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSeverName.FormattingEnabled = true;
            this.cboSeverName.Location = new System.Drawing.Point(148, 16);
            this.cboSeverName.Name = "cboSeverName";
            this.cboSeverName.Size = new System.Drawing.Size(303, 38);
            this.cboSeverName.TabIndex = 1;
            this.cboSeverName.DropDown += new System.EventHandler(this.cboSeverName_DropDown);
            this.cboSeverName.SelectedIndexChanged += new System.EventHandler(this.CboSeverName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever Name";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 442);
            this.Controls.Add(this.panel1);
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboSeverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
    }
}
