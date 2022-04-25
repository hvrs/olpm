
namespace olimp.Forms
{
    partial class accPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_addApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_statistic);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_mainMenu);
            this.panel1.Controls.Add(this.btn_addApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 37);
            this.panel1.TabIndex = 4;
            // 
            // btn_statistic
            // 
            this.btn_statistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_statistic.FlatAppearance.BorderSize = 0;
            this.btn_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistic.Location = new System.Drawing.Point(182, 0);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(91, 37);
            this.btn_statistic.TabIndex = 8;
            this.btn_statistic.Text = "Статистика";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(652, 0);
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
            // btn_addApp
            // 
            this.btn_addApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addApp.FlatAppearance.BorderSize = 0;
            this.btn_addApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addApp.Location = new System.Drawing.Point(0, 0);
            this.btn_addApp.Name = "btn_addApp";
            this.btn_addApp.Size = new System.Drawing.Size(91, 37);
            this.btn_addApp.TabIndex = 5;
            this.btn_addApp.Text = "Добавить приложение";
            this.btn_addApp.UseVisualStyleBackColor = true;
            this.btn_addApp.Click += new System.EventHandler(this.btn_addApp_Click);
            // 
            // accPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "accPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.Load += new System.EventHandler(this.accPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_addApp;
        private System.Windows.Forms.Button btn_statistic;
    }
}