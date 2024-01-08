namespace Ohejlmointi2_VKO2_Tehtävä2
{
    partial class Paikanvaihto
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnVaihda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(23, 45);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(23, 103);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(61, 45);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 2;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(61, 96);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 3;
            // 
            // btnVaihda
            // 
            this.btnVaihda.Location = new System.Drawing.Point(72, 133);
            this.btnVaihda.Name = "btnVaihda";
            this.btnVaihda.Size = new System.Drawing.Size(75, 23);
            this.btnVaihda.TabIndex = 4;
            this.btnVaihda.Text = "Vaihda";
            this.btnVaihda.UseVisualStyleBackColor = true;
            this.btnVaihda.Click += new System.EventHandler(this.btnVaihda_Click);
            // 
            // Paikanvaihto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 193);
            this.Controls.Add(this.btnVaihda);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Paikanvaihto";
            this.Text = "Paikanvaihto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnVaihda;
    }
}

