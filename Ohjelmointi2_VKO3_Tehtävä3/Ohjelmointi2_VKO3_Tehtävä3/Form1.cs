using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO3_Tehtävä3
{
    public partial class frmPeli : Form
    {
        public frmPeli()
        {
            InitializeComponent();
        }

        private void aloitaPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Button b = new Button();
            this.Controls.Add(b);
            b.Text = "Paina Minua";
            b.Location = new Point(200, 200);
            b.Size = new Size(100, 50);

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
