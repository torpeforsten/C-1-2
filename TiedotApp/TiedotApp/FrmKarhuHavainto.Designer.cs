namespace TiedotApp
{
    partial class FrmKarhuHavainto
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
            this.tbKarhuKuvaus = new System.Windows.Forms.TextBox();
            this.btnVie = new System.Windows.Forms.Button();
            this.nudJaljenPituus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKarhuPaiva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKarhuNahty = new System.Windows.Forms.CheckBox();
            this.tbKarhuPaikka = new System.Windows.Forms.TextBox();
            this.lblHavaintopaikka = new System.Windows.Forms.Label();
            this.lblHavaintopaiva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudJaljenPituus)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKarhuKuvaus
            // 
            this.tbKarhuKuvaus.Location = new System.Drawing.Point(160, 245);
            this.tbKarhuKuvaus.Multiline = true;
            this.tbKarhuKuvaus.Name = "tbKarhuKuvaus";
            this.tbKarhuKuvaus.Size = new System.Drawing.Size(200, 89);
            this.tbKarhuKuvaus.TabIndex = 21;
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(285, 128);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(75, 48);
            this.btnVie.TabIndex = 20;
            this.btnVie.Text = "Vie";
            this.btnVie.UseVisualStyleBackColor = true;
            // 
            // nudJaljenPituus
            // 
            this.nudJaljenPituus.Location = new System.Drawing.Point(160, 193);
            this.nudJaljenPituus.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudJaljenPituus.Name = "nudJaljenPituus";
            this.nudJaljenPituus.Size = new System.Drawing.Size(200, 20);
            this.nudJaljenPituus.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Jäljen pituus (cm)";
            // 
            // dtpKarhuPaiva
            // 
            this.dtpKarhuPaiva.Location = new System.Drawing.Point(160, 43);
            this.dtpKarhuPaiva.Name = "dtpKarhuPaiva";
            this.dtpKarhuPaiva.Size = new System.Drawing.Size(200, 20);
            this.dtpKarhuPaiva.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kuvaus";
            // 
            // cbKarhuNahty
            // 
            this.cbKarhuNahty.AutoSize = true;
            this.cbKarhuNahty.Location = new System.Drawing.Point(160, 146);
            this.cbKarhuNahty.Name = "cbKarhuNahty";
            this.cbKarhuNahty.Size = new System.Drawing.Size(54, 17);
            this.cbKarhuNahty.TabIndex = 15;
            this.cbKarhuNahty.Text = "Nähty";
            this.cbKarhuNahty.UseVisualStyleBackColor = true;
            // 
            // tbKarhuPaikka
            // 
            this.tbKarhuPaikka.Location = new System.Drawing.Point(160, 88);
            this.tbKarhuPaikka.Name = "tbKarhuPaikka";
            this.tbKarhuPaikka.Size = new System.Drawing.Size(200, 20);
            this.tbKarhuPaikka.TabIndex = 14;
            // 
            // lblHavaintopaikka
            // 
            this.lblHavaintopaikka.AutoSize = true;
            this.lblHavaintopaikka.Location = new System.Drawing.Point(45, 91);
            this.lblHavaintopaikka.Name = "lblHavaintopaikka";
            this.lblHavaintopaikka.Size = new System.Drawing.Size(82, 13);
            this.lblHavaintopaikka.TabIndex = 13;
            this.lblHavaintopaikka.Text = "Havaintopaikka";
            // 
            // lblHavaintopaiva
            // 
            this.lblHavaintopaiva.AutoSize = true;
            this.lblHavaintopaiva.Location = new System.Drawing.Point(42, 43);
            this.lblHavaintopaiva.Name = "lblHavaintopaiva";
            this.lblHavaintopaiva.Size = new System.Drawing.Size(76, 13);
            this.lblHavaintopaiva.TabIndex = 12;
            this.lblHavaintopaiva.Text = "Havaintopäivä";
            // 
            // FrmKarhuHavainto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 390);
            this.Controls.Add(this.tbKarhuKuvaus);
            this.Controls.Add(this.btnVie);
            this.Controls.Add(this.nudJaljenPituus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpKarhuPaiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKarhuNahty);
            this.Controls.Add(this.tbKarhuPaikka);
            this.Controls.Add(this.lblHavaintopaikka);
            this.Controls.Add(this.lblHavaintopaiva);
            this.Name = "FrmKarhuHavainto";
            this.Text = "KarhuHavainto";
            ((System.ComponentModel.ISupportInitialize)(this.nudJaljenPituus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKarhuKuvaus;
        private System.Windows.Forms.Button btnVie;
        private System.Windows.Forms.NumericUpDown nudJaljenPituus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKarhuPaiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbKarhuNahty;
        private System.Windows.Forms.TextBox tbKarhuPaikka;
        private System.Windows.Forms.Label lblHavaintopaikka;
        private System.Windows.Forms.Label lblHavaintopaiva;
    }
}