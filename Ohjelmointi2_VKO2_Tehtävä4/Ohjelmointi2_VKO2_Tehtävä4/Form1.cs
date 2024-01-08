using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO2_Tehtävä4
{
    public partial class frmMittaus : Form
    {
        List<Mittaus> mittaus = new List<Mittaus>();

        public frmMittaus()
        {
            InitializeComponent();
        }

        private void btnLisää_Click(object sender, EventArgs e)
        {
            Mittaus m = new Mittaus();
            m.nimi = tbNimi.Text;
            m.arvo = cbArvo.Text;
            m.sijainti = cbSijainti.Text;
            m.toiminta = clbToiminta.Text;

            if (clbToiminta.Checked)
            {
                m.toiminta = "Toiminnassa";
            }
            else
            {
                m.toiminta = "Ei toiminnassa";
            }
            mittaus.Add(m);
            dgvLaitteet.DataSource = null;
            dgvLaitteet.DataSource = mittaus;
        }

        private void frmMittaus_Load(object sender, EventArgs e)
        {
            dgvLaitteet.DataSource = mittaus;
        }
    }
}
