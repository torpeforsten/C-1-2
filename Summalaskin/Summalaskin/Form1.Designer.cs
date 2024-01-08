namespace Summalaskin
{
    partial class Summain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLuku1 = new System.Windows.Forms.TextBox();
            this.tbLuku2 = new System.Windows.Forms.TextBox();
            this.btnSummaa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSumma);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLuku2);
            this.panel1.Controls.Add(this.tbLuku1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 219);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luku 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Luku 2";
            // 
            // tbLuku1
            // 
            this.tbLuku1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuku1.Location = new System.Drawing.Point(112, 33);
            this.tbLuku1.Name = "tbLuku1";
            this.tbLuku1.Size = new System.Drawing.Size(100, 24);
            this.tbLuku1.TabIndex = 2;
            this.tbLuku1.Text = "0";
            // 
            // tbLuku2
            // 
            this.tbLuku2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuku2.Location = new System.Drawing.Point(112, 75);
            this.tbLuku2.Name = "tbLuku2";
            this.tbLuku2.Size = new System.Drawing.Size(100, 24);
            this.tbLuku2.TabIndex = 3;
            this.tbLuku2.Text = "0";
            // 
            // btnSummaa
            // 
            this.btnSummaa.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummaa.Location = new System.Drawing.Point(128, 299);
            this.btnSummaa.Name = "btnSummaa";
            this.btnSummaa.Size = new System.Drawing.Size(131, 68);
            this.btnSummaa.TabIndex = 1;
            this.btnSummaa.Text = "Summaa";
            this.btnSummaa.UseVisualStyleBackColor = true;
            this.btnSummaa.Click += new System.EventHandler(this.btnSummaa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Summa";
            // 
            // tbSumma
            // 
            this.tbSumma.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSumma.Location = new System.Drawing.Point(112, 156);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(100, 24);
            this.tbSumma.TabIndex = 5;
            this.tbSumma.Text = "0";
            // 
            // Summain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 397);
            this.Controls.Add(this.btnSummaa);
            this.Controls.Add(this.panel1);
            this.Name = "Summain";
            this.Text = "Summain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLuku2;
        private System.Windows.Forms.TextBox tbLuku1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSummaa;
    }
}

