
namespace olimp
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NameApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_toAcc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_signIN = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NameApp
            // 
            this.lbl_NameApp.AutoSize = true;
            this.lbl_NameApp.Location = new System.Drawing.Point(331, 187);
            this.lbl_NameApp.Name = "lbl_NameApp";
            this.lbl_NameApp.Size = new System.Drawing.Size(90, 13);
            this.lbl_NameApp.TabIndex = 1;
            this.lbl_NameApp.Text = "Name Application";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_toAcc);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_mainMenu);
            this.panel1.Controls.Add(this.btn_signIN);
            this.panel1.Controls.Add(this.btn_signUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 40);
            this.panel1.TabIndex = 3;
            // 
            // btn_toAcc
            // 
            this.btn_toAcc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_toAcc.FlatAppearance.BorderSize = 0;
            this.btn_toAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toAcc.Location = new System.Drawing.Point(559, 0);
            this.btn_toAcc.Name = "btn_toAcc";
            this.btn_toAcc.Size = new System.Drawing.Size(91, 40);
            this.btn_toAcc.TabIndex = 8;
            this.btn_toAcc.Text = "Личный кабинет";
            this.btn_toAcc.UseVisualStyleBackColor = true;
            this.btn_toAcc.Visible = false;
            this.btn_toAcc.Click += new System.EventHandler(this.btn_toAcc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(650, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 40);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_mainMenu.FlatAppearance.BorderSize = 0;
            this.btn_mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainMenu.Location = new System.Drawing.Point(182, 0);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(91, 40);
            this.btn_mainMenu.TabIndex = 6;
            this.btn_mainMenu.Text = "На главную";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            // 
            // btn_signIN
            // 
            this.btn_signIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_signIN.FlatAppearance.BorderSize = 0;
            this.btn_signIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signIN.Location = new System.Drawing.Point(91, 0);
            this.btn_signIN.Name = "btn_signIN";
            this.btn_signIN.Size = new System.Drawing.Size(91, 40);
            this.btn_signIN.TabIndex = 5;
            this.btn_signIN.Text = "Авторизация";
            this.btn_signIN.UseVisualStyleBackColor = true;
            this.btn_signIN.Click += new System.EventHandler(this.btn_signIN_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Location = new System.Drawing.Point(0, 0);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(91, 40);
            this.btn_signUp.TabIndex = 4;
            this.btn_signUp.Text = "Регистрация";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NameApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NameApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_toAcc;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_signIN;
        private System.Windows.Forms.Button btn_signUp;
    }
}

