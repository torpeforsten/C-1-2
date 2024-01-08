namespace Viikko3Tuntiteht1
{
    partial class Viikko3Tuntiteht1
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
            this.tbTeksti = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTuo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLopeta = new System.Windows.Forms.ToolStripMenuItem();
            this.tyhjennäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTeksti
            // 
            this.tbTeksti.Location = new System.Drawing.Point(9, 43);
            this.tbTeksti.Margin = new System.Windows.Forms.Padding(2);
            this.tbTeksti.Multiline = true;
            this.tbTeksti.Name = "tbTeksti";
            this.tbTeksti.Size = new System.Drawing.Size(460, 290);
            this.tbTeksti.TabIndex = 0;
            this.tbTeksti.TextChanged += new System.EventHandler(this.tbTeksti_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tyhjennäToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVie,
            this.menuTuo,
            this.menuLopeta});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.menuTuo_Click);
            // 
            // menuVie
            // 
            this.menuVie.Image = global::Viikko3Tuntiteht1.Properties.Resources._58_581822_email_send_icon_icon_hd_png_download;
            this.menuVie.Name = "menuVie";
            this.menuVie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.menuVie.Size = new System.Drawing.Size(184, 26);
            this.menuVie.Text = "Vie";
            this.menuVie.Click += new System.EventHandler(this.menuVie_Click);
            // 
            // menuTuo
            // 
            this.menuTuo.Image = global::Viikko3Tuntiteht1.Properties.Resources.png_transparent_computer_icons_add_logo_desktop_wallpaper_add_thumbnail;
            this.menuTuo.Name = "menuTuo";
            this.menuTuo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.menuTuo.Size = new System.Drawing.Size(184, 26);
            this.menuTuo.Text = "Tuo";
            this.menuTuo.Click += new System.EventHandler(this.menuTuo_Click);
            // 
            // menuLopeta
            // 
            this.menuLopeta.Name = "menuLopeta";
            this.menuLopeta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.menuLopeta.Size = new System.Drawing.Size(184, 26);
            this.menuLopeta.Text = "Lopeta";
            this.menuLopeta.Click += new System.EventHandler(this.menuLopeta_Click);
            // 
            // tyhjennäToolStripMenuItem
            // 
            this.tyhjennäToolStripMenuItem.Name = "tyhjennäToolStripMenuItem";
            this.tyhjennäToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tyhjennäToolStripMenuItem.Text = "Tyhjennä";
            this.tyhjennäToolStripMenuItem.Click += new System.EventHandler(this.tyhjennäToolStripMenuItem_Click);
            // 
            // Viikko3Tuntiteht1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 426);
            this.Controls.Add(this.tbTeksti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Viikko3Tuntiteht1";
            this.Text = "Ohjelmointi2_VKO2_T2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTeksti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVie;
        private System.Windows.Forms.ToolStripMenuItem menuTuo;
        private System.Windows.Forms.ToolStripMenuItem menuLopeta;
        private System.Windows.Forms.ToolStripMenuItem tyhjennäToolStripMenuItem;
    }
}

