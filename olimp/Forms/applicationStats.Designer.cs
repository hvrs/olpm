
namespace olimp.Forms
{
    partial class applicationStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_toAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(36, 73);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(401, 219);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chr_stats";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_mainMenu);
            this.panel1.Controls.Add(this.btn_toAcc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 37);
            this.panel1.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(415, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 37);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_mainMenu.FlatAppearance.BorderSize = 0;
            this.btn_mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainMenu.Location = new System.Drawing.Point(91, 0);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(91, 37);
            this.btn_mainMenu.TabIndex = 6;
            this.btn_mainMenu.Text = "На главную";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_toAcc
            // 
            this.btn_toAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toAcc.FlatAppearance.BorderSize = 0;
            this.btn_toAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toAcc.Location = new System.Drawing.Point(0, 0);
            this.btn_toAcc.Name = "btn_toAcc";
            this.btn_toAcc.Size = new System.Drawing.Size(91, 37);
            this.btn_toAcc.TabIndex = 5;
            this.btn_toAcc.Text = "Аккаунт";
            this.btn_toAcc.UseVisualStyleBackColor = true;
            this.btn_toAcc.Click += new System.EventHandler(this.btn_toAcc_Click);
            // 
            // applicationStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "applicationStats";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.applicationStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_toAcc;
    }
}