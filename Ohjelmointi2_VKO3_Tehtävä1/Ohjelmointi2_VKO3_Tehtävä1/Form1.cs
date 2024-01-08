using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO3_Tehtävä1
{
    public partial class frmViikko3Teht1 : Form
    {
        public frmViikko3Teht1()
        {
            InitializeComponent();
        }

        private void btnYksi_Click (object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Name = "tbYksi";
            tb.Location = new System.Drawing.Point(300, 105);
            tb.Size = new System.Drawing.Size(230, 25);

            this.Controls.Add(tb);
        }

        private void btnKaksi_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Name = "tbKaksi";
            tb.Location = new System.Drawing.Point(300, 290);
            tb.Size = new System.Drawing.Size(230, 25);

            this.Controls.Add(tb);

        }

        private void tbYksi_Leave(object sender, EventArgs e)
        {
            TextBox tbYksi = (TextBox)sender;

            if (tbYksi.Location.Y == btnYksi.Location.Y)
            {
                btnYksi.Text = tbYksi.Text;
            }

        }
    }
}
