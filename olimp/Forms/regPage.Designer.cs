
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
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(49, 32);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(159, 20);
            this.tb_Email.TabIndex = 0;
            // 
            // tb_Pasw
            // 
            this.tb_Pasw.Location = new System.Drawing.Point(49, 81);
            this.tb_Pasw.Name = "tb_Pasw";
            this.tb_Pasw.PasswordChar = '*';
            this.tb_Pasw.Size = new System.Drawing.Size(159, 20);
            this.tb_Pasw.TabIndex = 1;
            // 
            // tb_PaswRe
            // 
            this.tb_PaswRe.Location = new System.Drawing.Point(49, 134);
            this.tb_PaswRe.Name = "tb_PaswRe";
            this.tb_PaswRe.PasswordChar = '*';
            this.tb_PaswRe.Size = new System.Drawing.Size(159, 20);
            this.tb_PaswRe.TabIndex = 2;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(94, 220);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "Войти";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_typeErr
            // 
            this.lbl_typeErr.AutoSize = true;
            this.lbl_typeErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeErr.Location = new System.Drawing.Point(55, 187);
            this.lbl_typeErr.Name = "lbl_typeErr";
            this.lbl_typeErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_typeErr.TabIndex = 4;
            this.lbl_typeErr.Text = "label1";
            this.lbl_typeErr.Visible = false;
            // 
            // regPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 277);
            this.Controls.Add(this.lbl_typeErr);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.tb_PaswRe);
            this.Controls.Add(this.tb_Pasw);
            this.Controls.Add(this.tb_Email);
            this.Name = "regPage";
            this.Text = "regPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Pasw;
        private System.Windows.Forms.TextBox tb_PaswRe;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_typeErr;
    }
}