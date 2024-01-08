using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summalaskin
{
    public partial class Summain : Form
    {
        public Summain()
        {
            InitializeComponent();
        }

        private void btnSummaa_Click(object sender, EventArgs e)
        {
            int l1 = int.Parse(tbLuku1.Text);
            int l2 = int.Parse(tbLuku2.Text);

            int tulos = l1 + l2;

            tbSumma.Text = tulos.ToString();
        }
    }
}
