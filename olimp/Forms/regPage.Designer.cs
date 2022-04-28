
namespace olimp
{
    partial class regPage
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
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Pasw = new System.Windows.Forms.TextBox();
            this.tb_PaswRe = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_typeErr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(12, 32);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(159, 20);
            this.tb_Email.TabIndex = 0;
            // 
            // tb_Pasw
            // 
            this.tb_Pasw.Location = new System.Drawing.Point(12, 81);
            this.tb_Pasw.Name = "tb_Pasw";
            this.tb_Pasw.PasswordChar = '*';
            this.tb_Pasw.Size = new System.Drawing.Size(159, 20);
            this.tb_Pasw.TabIndex = 1;
            // 
            // tb_PaswRe
            // 
            this.tb_PaswRe.Location = new System.Drawing.Point(12, 134);
            this.tb_PaswRe.Name = "tb_PaswRe";
            this.tb_PaswRe.PasswordChar = '*';
            this.tb_PaswRe.Size = new System.Drawing.Size(159, 20);
            this.tb_PaswRe.TabIndex = 2;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btn_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(0, 0);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(182, 39);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "Войти";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_typeErr
            // 
            this.lbl_typeErr.AutoSize = true;
            this.lbl_typeErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeErr.Location = new System.Drawing.Point(35, 166);
            this.lbl_typeErr.Name = "lbl_typeErr";
            this.lbl_typeErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_typeErr.TabIndex = 4;
            this.lbl_typeErr.Text = "label1";
            this.lbl_typeErr.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Повтор:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SignUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 39);
            this.panel1.TabIndex = 8;
            // 
            // regPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(182, 221);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_typeErr);
            this.Controls.Add(this.tb_PaswRe);
            this.Controls.Add(this.tb_Pasw);
            this.Controls.Add(this.tb_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "regPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Pasw;
        private System.Windows.Forms.TextBox tb_PaswRe;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_typeErr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}