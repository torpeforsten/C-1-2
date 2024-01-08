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
    public partial class FrmKarhuHavainto : Form
    {
        /*
        public void PaivitaHavainto(KarhuHavainto kh)
        {

            kh.Havaintopaiva = dtpKarhuPaiva.Value;
            kh.Havaintopaikka = tbKarhuPaikka.Text;
            if (cbKarhuNahty.Checked)
                kh.Nahty = "Kyllä";
            else
                kh.Nahty = "Ei";
            kh.JaljenPituus = (int)nudJaljenPituus.Value;
            kh.Kuvaus = tbKarhuKuvaus.Text;
        }
        */
        public FrmKarhuHavainto(KarhuHavainto kh)
        {
            InitializeComponent();
            //PaivitaHavainto(kh);

            dtpKarhuPaiva.Value = kh.Havaintopaiva;
            tbKarhuPaikka.Text = kh.Havaintopaikka;
            if (kh.Nahty == "Kyllä")
                cbKarhuNahty.Checked = true;
            else
                cbKarhuNahty.Checked = false;

            nudJaljenPituus.Value = kh.JaljenPituus;
            tbKarhuKuvaus.Text = kh.Kuvaus;
        }
    }
}
