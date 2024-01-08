using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiedotApp
{
    public partial class frmRiistahavainnot : Form
    {
        List<KarhuHavainto> karhuhavainnot = new List<KarhuHavainto>();

        public frmRiistahavainnot()
        {
            InitializeComponent();
            dgvKarhuhavainnot.DataSource = karhuhavainnot;
        }

        private void btnVie_Click(object sender, EventArgs e)
        {
            KarhuHavainto kh = new KarhuHavainto();
            kh.Havaintopaiva = dtpKarhuPaiva.Value;
            kh.Havaintopaikka = tbKarhuPaikka.Text;
            if (cbKarhuNahty.Checked)
                kh.Nahty = "Kyllä";
            else
                kh.Nahty = "Ei";
            kh.JaljenPituus = (int)nudJaljenPituus.Value;
            kh.Kuvaus = tbKarhuKuvaus.Text;

            karhuhavainnot.Add(kh);
            dgvKarhuhavainnot.DataSource = null;
            dgvKarhuhavainnot.DataSource = karhuhavainnot;

            // Näytetään syötetty karhuhavainto toisella lomakkeella

            FrmKarhuHavainto karhuhavainto_lomake = new FrmKarhuHavainto(kh);
            karhuhavainto_lomake.ShowDialog();

        }
    }
}
