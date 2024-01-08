namespace Ohjelmointi2_VKO3_Tehtävä1
{
    partial class frmViikko3Teht1
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
            this.btnYksi = new System.Windows.Forms.Button();
            this.btnKaksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYksi
            // 
            this.btnYksi.Location = new System.Drawing.Point(84, 74);
            this.btnYksi.Name = "btnYksi";
            this.btnYksi.Size = new System.Drawing.Size(145, 85);
            this.btnYksi.TabIndex = 0;
            this.btnYksi.Text = "Nappi1";
            this.btnYksi.UseVisualStyleBackColor = true;
            this.btnYksi.Click += new System.EventHandler(this.btnYksi_Click);
            // 
            // btnKaksi
            // 
            this.btnKaksi.Location = new System.Drawing.Point(84, 258);
            this.btnKaksi.Name = "btnKaksi";
            this.btnKaksi.Size = new System.Drawing.Size(145, 81);
            this.btnKaksi.TabIndex = 1;
            this.btnKaksi.Text = "Nappi2";
            this.btnKaksi.UseVisualStyleBackColor = true;
            this.btnKaksi.Click += new System.EventHandler(this.btnKaksi_Click);
            // 
            // frmViikko3Teht1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 411);
            this.Controls.Add(this.btnKaksi);
            this.Controls.Add(this.btnYksi);
            this.Name = "frmViikko3Teht1";
            this.Text = "Viikko3Teht1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYksi;
        private System.Windows.Forms.Button btnKaksi;
    }
}

