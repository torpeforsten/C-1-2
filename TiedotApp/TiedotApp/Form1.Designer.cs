namespace TiedotApp
{
    partial class frmRiistahavainnot
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
            this.tbcHavainnot = new System.Windows.Forms.TabControl();
            this.tbcKarhu = new System.Windows.Forms.TabPage();
            this.tbKarhuKuvaus = new System.Windows.Forms.TextBox();
            this.dgvKarhuhavainnot = new System.Windows.Forms.DataGridView();
            this.btnVie = new System.Windows.Forms.Button();
            this.nudJaljenPituus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKarhuPaiva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKarhuNahty = new System.Windows.Forms.CheckBox();
            this.tbKarhuPaikka = new System.Windows.Forms.TextBox();
            this.lblHavaintopaikka = new System.Windows.Forms.Label();
            this.lblHavaintopaiva = new System.Windows.Forms.Label();
            this.tbcIlves = new System.Windows.Forms.TabPage();
            this.tbcHirvi = new System.Windows.Forms.TabPage();
            this.msToiminnot = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcHavainnot.SuspendLayout();
            this.tbcKarhu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarhuhavainnot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJaljenPituus)).BeginInit();
            this.tbcIlves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcHavainnot
            // 
            this.tbcHavainnot.Controls.Add(this.tbcKarhu);
            this.tbcHavainnot.Controls.Add(this.tbcIlves);
            this.tbcHavainnot.Controls.Add(this.tbcHirvi);
            this.tbcHavainnot.Location = new System.Drawing.Point(12, 40);
            this.tbcHavainnot.Name = "tbcHavainnot";
            this.tbcHavainnot.SelectedIndex = 0;
            this.tbcHavainnot.Size = new System.Drawing.Size(776, 398);
            this.tbcHavainnot.TabIndex = 0;
            // 
            // tbcKarhu
            // 
            this.tbcKarhu.Controls.Add(this.tbKarhuKuvaus);
            this.tbcKarhu.Controls.Add(this.dgvKarhuhavainnot);
            this.tbcKarhu.Controls.Add(this.btnVie);
            this.tbcKarhu.Controls.Add(this.nudJaljenPituus);
            this.tbcKarhu.Controls.Add(this.label2);
            this.tbcKarhu.Controls.Add(this.dtpKarhuPaiva);
            this.tbcKarhu.Controls.Add(this.label1);
            this.tbcKarhu.Controls.Add(this.cbKarhuNahty);
            this.tbcKarhu.Controls.Add(this.tbKarhuPaikka);
            this.tbcKarhu.Controls.Add(this.lblHavaintopaikka);
            this.tbcKarhu.Controls.Add(this.lblHavaintopaiva);
            this.tbcKarhu.Location = new System.Drawing.Point(4, 22);
            this.tbcKarhu.Name = "tbcKarhu";
            this.tbcKarhu.Padding = new System.Windows.Forms.Padding(3);
            this.tbcKarhu.Size = new System.Drawing.Size(768, 372);
            this.tbcKarhu.TabIndex = 0;
            this.tbcKarhu.Text = "Karhu";
            this.tbcKarhu.UseVisualStyleBackColor = true;
            // 
            // tbKarhuKuvaus
            // 
            this.tbKarhuKuvaus.Location = new System.Drawing.Point(155, 252);
            this.tbKarhuKuvaus.Multiline = true;
            this.tbKarhuKuvaus.Name = "tbKarhuKuvaus";
            this.tbKarhuKuvaus.Size = new System.Drawing.Size(200, 89);
            this.tbKarhuKuvaus.TabIndex = 11;
            // 
            // dgvKarhuhavainnot
            // 
            this.dgvKarhuhavainnot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarhuhavainnot.Location = new System.Drawing.Point(393, 50);
            this.dgvKarhuhavainnot.Name = "dgvKarhuhavainnot";
            this.dgvKarhuhavainnot.Size = new System.Drawing.Size(351, 291);
            this.dgvKarhuhavainnot.TabIndex = 10;
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(280, 135);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(75, 48);
            this.btnVie.TabIndex = 9;
            this.btnVie.Text = "Vie";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.btnVie_Click);
            // 
            // nudJaljenPituus
            // 
            this.nudJaljenPituus.Location = new System.Drawing.Point(155, 200);
            this.nudJaljenPituus.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudJaljenPituus.Name = "nudJaljenPituus";
            this.nudJaljenPituus.Size = new System.Drawing.Size(200, 20);
            this.nudJaljenPituus.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jäljen pituus (cm)";
            // 
            // dtpKarhuPaiva
            // 
            this.dtpKarhuPaiva.Location = new System.Drawing.Point(155, 50);
            this.dtpKarhuPaiva.Name = "dtpKarhuPaiva";
            this.dtpKarhuPaiva.Size = new System.Drawing.Size(200, 20);
            this.dtpKarhuPaiva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kuvaus";
            // 
            // cbKarhuNahty
            // 
            this.cbKarhuNahty.AutoSize = true;
            this.cbKarhuNahty.Location = new System.Drawing.Point(155, 153);
            this.cbKarhuNahty.Name = "cbKarhuNahty";
            this.cbKarhuNahty.Size = new System.Drawing.Size(54, 17);
            this.cbKarhuNahty.TabIndex = 3;
            this.cbKarhuNahty.Text = "Nähty";
            this.cbKarhuNahty.UseVisualStyleBackColor = true;
            // 
            // tbKarhuPaikka
            // 
            this.tbKarhuPaikka.Location = new System.Drawing.Point(155, 95);
            this.tbKarhuPaikka.Name = "tbKarhuPaikka";
            this.tbKarhuPaikka.Size = new System.Drawing.Size(200, 20);
            this.tbKarhuPaikka.TabIndex = 2;
            // 
            // lblHavaintopaikka
            // 
            this.lblHavaintopaikka.AutoSize = true;
            this.lblHavaintopaikka.Location = new System.Drawing.Point(40, 98);
            this.lblHavaintopaikka.Name = "lblHavaintopaikka";
            this.lblHavaintopaikka.Size = new System.Drawing.Size(82, 13);
            this.lblHavaintopaikka.TabIndex = 1;
            this.lblHavaintopaikka.Text = "Havaintopaikka";
            // 
            // lblHavaintopaiva
            // 
            this.lblHavaintopaiva.AutoSize = true;
            this.lblHavaintopaiva.Location = new System.Drawing.Point(37, 50);
            this.lblHavaintopaiva.Name = "lblHavaintopaiva";
            this.lblHavaintopaiva.Size = new System.Drawing.Size(76, 13);
            this.lblHavaintopaiva.TabIndex = 0;
            this.lblHavaintopaiva.Text = "Havaintopäivä";
            // 
            // tbcIlves
            // 
            this.tbcIlves.Controls.Add(this.textBox1);
            this.tbcIlves.Controls.Add(this.dataGridView1);
            this.tbcIlves.Controls.Add(this.button1);
            this.tbcIlves.Controls.Add(this.numericUpDown1);
            this.tbcIlves.Controls.Add(this.label3);
            this.tbcIlves.Controls.Add(this.dateTimePicker1);
            this.tbcIlves.Controls.Add(this.label4);
            this.tbcIlves.Controls.Add(this.checkBox1);
            this.tbcIlves.Controls.Add(this.textBox2);
            this.tbcIlves.Controls.Add(this.label5);
            this.tbcIlves.Controls.Add(this.label6);
            this.tbcIlves.Location = new System.Drawing.Point(4, 22);
            this.tbcIlves.Name = "tbcIlves";
            this.tbcIlves.Padding = new System.Windows.Forms.Padding(3);
            this.tbcIlves.Size = new System.Drawing.Size(768, 372);
            this.tbcIlves.TabIndex = 1;
            this.tbcIlves.Text = "Ilves";
            this.tbcIlves.UseVisualStyleBackColor = true;
            // 
            // tbcHirvi
            // 
            this.tbcHirvi.Location = new System.Drawing.Point(4, 22);
            this.tbcHirvi.Name = "tbcHirvi";
            this.tbcHirvi.Padding = new System.Windows.Forms.Padding(3);
            this.tbcHirvi.Size = new System.Drawing.Size(768, 400);
            this.tbcHirvi.TabIndex = 2;
            this.tbcHirvi.Text = "Hirvi";
            this.tbcHirvi.UseVisualStyleBackColor = true;
            // 
            // msToiminnot
            // 
            this.msToiminnot.Location = new System.Drawing.Point(0, 0);
            this.msToiminnot.Name = "msToiminnot";
            this.msToiminnot.Size = new System.Drawing.Size(800, 24);
            this.msToiminnot.TabIndex = 1;
            this.msToiminnot.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 89);
            this.textBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 291);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Vie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 191);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jäljen pituus (cm)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kuvaus";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Nähty";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Havaintopaikka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Havaintopäivä";
            // 
            // frmRiistahavainnot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcHavainnot);
            this.Controls.Add(this.msToiminnot);
            this.MainMenuStrip = this.msToiminnot;
            this.Name = "frmRiistahavainnot";
            this.Text = "Riistahavainnot";
            this.tbcHavainnot.ResumeLayout(false);
            this.tbcKarhu.ResumeLayout(false);
            this.tbcKarhu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarhuhavainnot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJaljenPituus)).EndInit();
            this.tbcIlves.ResumeLayout(false);
            this.tbcIlves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcHavainnot;
        private System.Windows.Forms.TabPage tbcKarhu;
        private System.Windows.Forms.TabPage tbcIlves;
        private System.Windows.Forms.TabPage tbcHirvi;
        private System.Windows.Forms.DataGridView dgvKarhuhavainnot;
        private System.Windows.Forms.Button btnVie;
        private System.Windows.Forms.NumericUpDown nudJaljenPituus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKarhuPaiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbKarhuNahty;
        private System.Windows.Forms.TextBox tbKarhuPaikka;
        private System.Windows.Forms.Label lblHavaintopaikka;
        private System.Windows.Forms.Label lblHavaintopaiva;
        private System.Windows.Forms.TextBox tbKarhuKuvaus;
        private System.Windows.Forms.MenuStrip msToiminnot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

