
namespace GUI
{
    partial class UC_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartLoaiHangBanTang1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoaiHangBanTang1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartLoaiHangBanTang1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 492);
            this.panel1.TabIndex = 0;
            // 
            // chartLoaiHangBanTang1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLoaiHangBanTang1.ChartAreas.Add(chartArea1);
            this.chartLoaiHangBanTang1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartLoaiHangBanTang1.Legends.Add(legend1);
            this.chartLoaiHangBanTang1.Location = new System.Drawing.Point(0, 59);
            this.chartLoaiHangBanTang1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartLoaiHangBanTang1.Name = "chartLoaiHangBanTang1";
            this.chartLoaiHangBanTang1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Hàng Hóa";
            this.chartLoaiHangBanTang1.Series.Add(series1);
            this.chartLoaiHangBanTang1.Size = new System.Drawing.Size(553, 433);
            this.chartLoaiHangBanTang1.TabIndex = 9;
            this.chartLoaiHangBanTang1.Text = "chart2";
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl.Size = new System.Drawing.Size(553, 59);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Tầng 1";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Chart";
            this.Size = new System.Drawing.Size(553, 492);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoaiHangBanTang1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoaiHangBanTang1;
        private Guna.UI.WinForms.GunaLabel lbl;
    }
}
