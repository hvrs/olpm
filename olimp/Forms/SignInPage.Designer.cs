
namespace olimp
{
    partial class SignInPage
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
            this.tb_Pasw = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lbl_typeErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Pasw
            // 
            this.tb_Pasw.Location = new System.Drawing.Point(27, 92);
            this.tb_Pasw.Name = "tb_Pasw";
            this.tb_Pasw.PasswordChar = '*';
            this.tb_Pasw.Size = new System.Drawing.Size(159, 20);
            this.tb_Pasw.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(27, 43);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(159, 20);
            this.tb_Email.TabIndex = 2;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(68, 159);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(75, 23);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.Text = "Войти";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // lbl_typeErr
            // 
            this.lbl_typeErr.AutoSize = true;
            this.lbl_typeErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeErr.Location = new System.Drawing.Point(87, 132);
            this.lbl_typeErr.Name = "lbl_typeErr";
            this.lbl_typeErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_typeErr.TabIndex = 5;
            this.lbl_typeErr.Text = "label1";
            this.lbl_typeErr.Visible = false;
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 222);
            this.Controls.Add(this.lbl_typeErr);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.tb_Pasw);
            this.Controls.Add(this.tb_Email);
            this.Name = "SignInPage";
            this.Text = "SignInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pasw;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label lbl_typeErr;
    }
}