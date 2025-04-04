namespace Lab03
{
    partial class fMain
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
            this.tbTVInfo = new System.Windows.Forms.TextBox();
            this.btnAddTV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTVInfo
            // 
            this.tbTVInfo.Location = new System.Drawing.Point(12, 12);
            this.tbTVInfo.Multiline = true;
            this.tbTVInfo.Name = "tbTVInfo";
            this.tbTVInfo.ReadOnly = true;
            this.tbTVInfo.Size = new System.Drawing.Size(651, 432);
            this.tbTVInfo.TabIndex = 0;
            // 
            // btnAddTV
            // 
            this.btnAddTV.Location = new System.Drawing.Point(669, 12);
            this.btnAddTV.Name = "btnAddTV";
            this.btnAddTV.Size = new System.Drawing.Size(113, 26);
            this.btnAddTV.TabIndex = 1;
            this.btnAddTV.Text = "Додати телевізор";
            this.btnAddTV.UseVisualStyleBackColor = true;
            this.btnAddTV.Click += new System.EventHandler(this.btnAddTV_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(669, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = " Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTV);
            this.Controls.Add(this.tbTVInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTVInfo;
        private System.Windows.Forms.Button btnAddTV;
        private System.Windows.Forms.Button btnClose;
    }
}

