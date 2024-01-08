namespace Ohjelmointi2_VKO2_Tehtävä4
{
    partial class frmMittaus
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
            this.panelMittaus = new System.Windows.Forms.Panel();
            this.dgvLaitteet = new System.Windows.Forms.DataGridView();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblArvo = new System.Windows.Forms.Label();
            this.lblSijainti = new System.Windows.Forms.Label();
            this.clbToiminta = new System.Windows.Forms.CheckBox();
            this.cbArvo = new System.Windows.Forms.ComboBox();
            this.cbSijainti = new System.Windows.Forms.ComboBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.btnLisää = new System.Windows.Forms.Button();
            this.panelMittaus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaitteet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMittaus
            // 
            this.panelMittaus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMittaus.Controls.Add(this.btnLisää);
            this.panelMittaus.Controls.Add(this.tbNimi);
            this.panelMittaus.Controls.Add(this.cbSijainti);
            this.panelMittaus.Controls.Add(this.cbArvo);
            this.panelMittaus.Controls.Add(this.clbToiminta);
            this.panelMittaus.Controls.Add(this.lblSijainti);
            this.panelMittaus.Controls.Add(this.lblArvo);
            this.panelMittaus.Controls.Add(this.lblNimi);
            this.panelMittaus.Location = new System.Drawing.Point(12, 13);
            this.panelMittaus.Name = "panelMittaus";
            this.panelMittaus.Size = new System.Drawing.Size(474, 194);
            this.panelMittaus.TabIndex = 0;
            // 
            // dgvLaitteet
            // 
            this.dgvLaitteet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLaitteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaitteet.Location = new System.Drawing.Point(12, 235);
            this.dgvLaitteet.Name = "dgvLaitteet";
            this.dgvLaitteet.Size = new System.Drawing.Size(474, 203);
            this.dgvLaitteet.TabIndex = 1;
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(28, 24);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(27, 13);
            this.lblNimi.TabIndex = 0;
            this.lblNimi.Text = "Nimi";
            // 
            // lblArvo
            // 
            this.lblArvo.AutoSize = true;
            this.lblArvo.Location = new System.Drawing.Point(28, 73);
            this.lblArvo.Name = "lblArvo";
            this.lblArvo.Size = new System.Drawing.Size(75, 13);
            this.lblArvo.TabIndex = 1;
            this.lblArvo.Text = "Mitattava arvo";
            // 
            // lblSijainti
            // 
            this.lblSijainti.AutoSize = true;
            this.lblSijainti.Location = new System.Drawing.Point(28, 122);
            this.lblSijainti.Name = "lblSijainti";
            this.lblSijainti.Size = new System.Drawing.Size(37, 13);
            this.lblSijainti.TabIndex = 2;
            this.lblSijainti.Text = "Sijainti";
            // 
            // clbToiminta
            // 
            this.clbToiminta.AutoSize = true;
            this.clbToiminta.Location = new System.Drawing.Point(127, 161);
            this.clbToiminta.Name = "clbToiminta";
            this.clbToiminta.Size = new System.Drawing.Size(85, 17);
            this.clbToiminta.TabIndex = 3;
            this.clbToiminta.Text = "Toiminnassa";
            this.clbToiminta.UseVisualStyleBackColor = true;
            // 
            // cbArvo
            // 
            this.cbArvo.FormattingEnabled = true;
            this.cbArvo.Items.AddRange(new object[] {
            "Lämpötila",
            "Kosteus",
            "PH",
            "Tuulen nopeus"});
            this.cbArvo.Location = new System.Drawing.Point(104, 70);
            this.cbArvo.Name = "cbArvo";
            this.cbArvo.Size = new System.Drawing.Size(121, 21);
            this.cbArvo.TabIndex = 4;
            // 
            // cbSijainti
            // 
            this.cbSijainti.FormattingEnabled = true;
            this.cbSijainti.Items.AddRange(new object[] {
            "Sisällä",
            "Ulkona",
            "Ulkona suojatusti"});
            this.cbSijainti.Location = new System.Drawing.Point(104, 119);
            this.cbSijainti.Name = "cbSijainti";
            this.cbSijainti.Size = new System.Drawing.Size(121, 21);
            this.cbSijainti.TabIndex = 5;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(104, 21);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(121, 20);
            this.tbNimi.TabIndex = 6;
            // 
            // btnLisää
            // 
            this.btnLisää.Location = new System.Drawing.Point(286, 13);
            this.btnLisää.Name = "btnLisää";
            this.btnLisää.Size = new System.Drawing.Size(158, 165);
            this.btnLisää.TabIndex = 7;
            this.btnLisää.Text = "Lisää";
            this.btnLisää.UseVisualStyleBackColor = true;
            this.btnLisää.Click += new System.EventHandler(this.btnLisää_Click);
            // 
            // frmMittaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.dgvLaitteet);
            this.Controls.Add(this.panelMittaus);
            this.Name = "frmMittaus";
            this.Text = "MittausApp";
            this.Load += new System.EventHandler(this.frmMittaus_Load);
            this.panelMittaus.ResumeLayout(false);
            this.panelMittaus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaitteet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMittaus;
        private System.Windows.Forms.DataGridView dgvLaitteet;
        private System.Windows.Forms.Button btnLisää;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.ComboBox cbSijainti;
        private System.Windows.Forms.ComboBox cbArvo;
        private System.Windows.Forms.CheckBox clbToiminta;
        private System.Windows.Forms.Label lblSijainti;
        private System.Windows.Forms.Label lblArvo;
        private System.Windows.Forms.Label lblNimi;
    }
}

