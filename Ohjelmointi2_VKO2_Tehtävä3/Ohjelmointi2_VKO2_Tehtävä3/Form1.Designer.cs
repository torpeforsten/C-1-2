namespace Ohjelmointi2_VKO2_Tehtävä3
{
    partial class Form1
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
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblPuhnro = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblPostiNro = new System.Windows.Forms.Label();
            this.lblPostiPaikka = new System.Windows.Forms.Label();
            this.dtpSyntymäaika = new System.Windows.Forms.DateTimePicker();
            this.btnVie = new System.Windows.Forms.Button();
            this.lbTiedot = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPostiPaikka = new System.Windows.Forms.TextBox();
            this.tbPostiNro = new System.Windows.Forms.TextBox();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.tbPuhNro = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(19, 13);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimi.TabIndex = 0;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(19, 40);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 1;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblPuhnro
            // 
            this.lblPuhnro.AutoSize = true;
            this.lblPuhnro.Location = new System.Drawing.Point(19, 64);
            this.lblPuhnro.Name = "lblPuhnro";
            this.lblPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblPuhnro.TabIndex = 2;
            this.lblPuhnro.Text = "Puhelinnumero";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Location = new System.Drawing.Point(19, 92);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(55, 13);
            this.lblOsoite.TabIndex = 3;
            this.lblOsoite.Text = "Lähiosoite";
            // 
            // lblPostiNro
            // 
            this.lblPostiNro.AutoSize = true;
            this.lblPostiNro.Location = new System.Drawing.Point(19, 119);
            this.lblPostiNro.Name = "lblPostiNro";
            this.lblPostiNro.Size = new System.Drawing.Size(65, 13);
            this.lblPostiNro.TabIndex = 4;
            this.lblPostiNro.Text = "Postinumero";
            // 
            // lblPostiPaikka
            // 
            this.lblPostiPaikka.AutoSize = true;
            this.lblPostiPaikka.Location = new System.Drawing.Point(19, 148);
            this.lblPostiPaikka.Name = "lblPostiPaikka";
            this.lblPostiPaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPostiPaikka.TabIndex = 5;
            this.lblPostiPaikka.Text = "Postitoimipaikka";
            // 
            // dtpSyntymäaika
            // 
            this.dtpSyntymäaika.Location = new System.Drawing.Point(22, 181);
            this.dtpSyntymäaika.Name = "dtpSyntymäaika";
            this.dtpSyntymäaika.Size = new System.Drawing.Size(200, 20);
            this.dtpSyntymäaika.TabIndex = 6;
            this.dtpSyntymäaika.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtpSyntymäaika.Leave += new System.EventHandler(this.dtpSyntymäaika_Leave);
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(84, 265);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(98, 43);
            this.btnVie.TabIndex = 7;
            this.btnVie.Text = "Vie Tiedot";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.btnVie_Click);
            // 
            // lbTiedot
            // 
            this.lbTiedot.FormattingEnabled = true;
            this.lbTiedot.Location = new System.Drawing.Point(303, 33);
            this.lbTiedot.Name = "lbTiedot";
            this.lbTiedot.Size = new System.Drawing.Size(400, 225);
            this.lbTiedot.TabIndex = 8;
            this.lbTiedot.DoubleClick += new System.EventHandler(this.lbTiedot_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPostiPaikka);
            this.panel1.Controls.Add(this.tbPostiNro);
            this.panel1.Controls.Add(this.tbOsoite);
            this.panel1.Controls.Add(this.tbPuhNro);
            this.panel1.Controls.Add(this.tbSukunimi);
            this.panel1.Controls.Add(this.tbEtunimi);
            this.panel1.Controls.Add(this.lblEtunimi);
            this.panel1.Controls.Add(this.lblSukunimi);
            this.panel1.Controls.Add(this.lblPuhnro);
            this.panel1.Controls.Add(this.dtpSyntymäaika);
            this.panel1.Controls.Add(this.lblOsoite);
            this.panel1.Controls.Add(this.lblPostiPaikka);
            this.panel1.Controls.Add(this.lblPostiNro);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 226);
            this.panel1.TabIndex = 9;
            // 
            // tbPostiPaikka
            // 
            this.tbPostiPaikka.Location = new System.Drawing.Point(122, 148);
            this.tbPostiPaikka.Name = "tbPostiPaikka";
            this.tbPostiPaikka.Size = new System.Drawing.Size(100, 20);
            this.tbPostiPaikka.TabIndex = 12;
            // 
            // tbPostiNro
            // 
            this.tbPostiNro.Location = new System.Drawing.Point(122, 119);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(100, 20);
            this.tbPostiNro.TabIndex = 11;
            this.tbPostiNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostiNro_KeyPress);
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(122, 92);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(100, 20);
            this.tbOsoite.TabIndex = 10;
            // 
            // tbPuhNro
            // 
            this.tbPuhNro.Location = new System.Drawing.Point(122, 61);
            this.tbPuhNro.Name = "tbPuhNro";
            this.tbPuhNro.Size = new System.Drawing.Size(100, 20);
            this.tbPuhNro.TabIndex = 9;
            this.tbPuhNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhNro_KeyPress);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(122, 37);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 20);
            this.tbSukunimi.TabIndex = 8;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(122, 10);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 20);
            this.tbEtunimi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Syötä Tiedot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yhteenveto Tiedoista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTiedot);
            this.Controls.Add(this.btnVie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblPuhnro;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblPostiNro;
        private System.Windows.Forms.Label lblPostiPaikka;
        private System.Windows.Forms.DateTimePicker dtpSyntymäaika;
        private System.Windows.Forms.Button btnVie;
        private System.Windows.Forms.ListBox lbTiedot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPostiPaikka;
        private System.Windows.Forms.TextBox tbPostiNro;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.TextBox tbPuhNro;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label label2;
    }
}

