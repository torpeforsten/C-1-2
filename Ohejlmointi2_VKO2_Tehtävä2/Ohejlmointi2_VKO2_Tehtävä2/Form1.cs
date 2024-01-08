using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohejlmointi2_VKO2_Tehtävä2
{
    public partial class Paikanvaihto : Form
    {
        public Paikanvaihto()
        {
            InitializeComponent();
        }

        private void btnVaihda_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = int.Parse(tbX.Text);
            p.Y = int.Parse(tbY.Text);
            btnVaihda.Location = p;   
        }
    }
}
