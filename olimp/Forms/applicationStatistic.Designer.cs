
namespace olimp.Forms
{
    partial class applicationStatistic
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
            this.GridListApps = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridListApps)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListApps
            // 
            this.GridListApps.AllowUserToAddRows = false;
            this.GridListApps.AllowUserToDeleteRows = false;
            this.GridListApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListApps.Location = new System.Drawing.Point(57, 40);
            this.GridListApps.Name = "GridListApps";
            this.GridListApps.ReadOnly = true;
            this.GridListApps.Size = new System.Drawing.Size(458, 232);
            this.GridListApps.TabIndex = 0;
            // 
            // applicationStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 323);
            this.Controls.Add(this.GridListApps);
            this.Name = "applicationStatistic";
            this.Text = "applicationStatistic";
            this.Load += new System.EventHandler(this.applicationStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridListApps;
    }
}