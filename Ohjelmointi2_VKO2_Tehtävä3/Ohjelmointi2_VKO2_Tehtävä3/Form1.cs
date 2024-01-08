using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmointi2_VKO2_Tehtävä3
{
    public partial class Form1 : Form
    {
            // Luodaan Struct Henkilöille
        public struct Henkilo
        {
            public string Etunimi;
            public string Sukunimi;
            public string PuhNro;
            public string Osoite;
            public string PostiNro;
            public string PostiPaikka;
            public DateTime Syntymäaika;
        }

            // Luodaan ArrayList Henkilöille
        ArrayList henkilot = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
            // Poistaa kirjaimet käytöstä postinumerossa
        private void tbPostiNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
            // Poistaa kirjaimet käytöstä puhelinnumerossa
        private void tbPuhNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

            // Poistetaan double clikillä tietoja List Boxista
        private void lbTiedot_DoubleClick(object sender, EventArgs e)
        {
            int ind = lbTiedot.SelectedIndex;
            if (ind >= 0)
            {
                henkilot.RemoveAt(ind);
                UpdateHenkilotListBox();
            }
        }
            // Max date syntymäpäivä valitsimelle 
        private void dtpSyntymäaika_Leave(object sender, EventArgs e)
        {
            dtpSyntymäaika.MaxDate = DateTime.Today;
        }
            // Asetetaan painonapin tehtävät
        private void btnVie_Click(object sender, EventArgs e)
        {
            Henkilo h = new Henkilo();
            h.Etunimi = tbEtunimi.Text;
            h.Sukunimi = tbSukunimi.Text;
            h.PuhNro = tbPuhNro.Text;
            h.Osoite = tbOsoite.Text;
            h.PostiNro = tbPostiNro.Text;
            h.PostiPaikka = tbPostiPaikka.Text;
            h.Syntymäaika = dtpSyntymäaika.Value;
            henkilot.Add(h);
            UpdateHenkilotListBox();

            // Seuraava resetoi text Boxit
            tbEtunimi.Clear();
            tbSukunimi.Clear();
            tbPuhNro.Clear();
            tbOsoite.Clear();
            tbPostiNro.Clear();
            tbPostiPaikka.Clear();
            dtpSyntymäaika.ResetText();
        }
        // Tuodaan henkilöt näkyviin listboxiin
        public void UpdateHenkilotListBox()
        {
            lbTiedot.Items.Clear();
            foreach (Henkilo h in henkilot)
            {
                lbTiedot.Items.Add(h.Etunimi + " " + h.Sukunimi + ", " + h.PuhNro + ", "
                    + h.Osoite + " " + h.PostiNro + " " + h.PostiPaikka + ", " + h.Syntymäaika.ToShortDateString());
            }
        }
    }
}

