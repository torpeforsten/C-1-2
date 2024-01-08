using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyö_Roope_ja_Jenna
{
    public partial class frmHenkilotietoLomake : Form
    {
        
        const string personsfile = "C:\\temp\\henkilot.json";
        List<Henkilo> henkilot = new List<Henkilo>();
        public int iMuokIndex;
        public bool bMuokattu = false;

        public frmHenkilotietoLomake()
        {
            InitializeComponent();
            henkilot = DeserializeJSON();
            UpdateHenkilotListBox();
        }
                // Viedään tiedot listaan textboxeista napin painalluksessa
        private void btnVieTiedot_Click(object sender, EventArgs e)
        {
            Henkilo H = new Henkilo();

            H.Etunimet = tbEtunimet.Text;
            H.Sukunimi = tbSukunimi.Text;
            H.Kutsumanimi = tbKutsumanimi.Text;
            H.Hetu = tbHetu.Text;
            H.Katuosoite = tbOsoite.Text;
            H.PostiNro = tbPostiNro.Text;
            H.PostiPaikka = tbPostiPaikka.Text;
            H.Alkaminen = dtpAlkaminen.Value;
            H.Paattyminen = dtpPaattyminen.Value;
            H.Nimike = cbNimike.Text;
            H.Yksikko = cbYksikko.Text;

            if (bMuokattu == false)
            {
                henkilot.Add(H);
            }
            else
            {
                henkilot[iMuokIndex] = H;
            }

            bMuokattu = false;
            UpdateHenkilotListBox();
            SerializeJSON(henkilot);
        }
            // Alla oleva funktio päivittää listboxia, jonne tiedot viedään.
            // Tätä käytetään monessa muussa funktiossa, jotta listbox on ajan tasalla.
        public void UpdateHenkilotListBox()
        {
            lbTiedot.Items.Clear();
            foreach (Henkilo H in henkilot)
            {
                lbTiedot.Items.Add(H.Etunimet + ", " + H.Sukunimi + ", " + H.Kutsumanimi + ", " + H.Hetu + ", "
                    + H.Katuosoite + ", " + H.PostiNro + ", " + H.PostiPaikka + ", "
                    + H.Alkaminen.Date.ToShortDateString() + ", " + H.Paattyminen.Date.ToShortDateString() + ", " + H.Nimike + ", " + H.Yksikko);
            }
        }

            // Alla olevilla Click funktioilla saadaan sovelluksen listan järjestystä muutettua.
        private void tsAO_Click(object sender, EventArgs e)
        {
            var a = (ToolStripMenuItem)sender;
            if (a.Name == "kutsumanimiToolStripMenuItem")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return x.Kutsumanimi.CompareTo(y.Kutsumanimi);
                });
            }
            else if (a.Name == "sukunimiToolStripMenuItem")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return x.Sukunimi.CompareTo(y.Sukunimi);
                });
            }
            else if (a.Name == "nimikeToolStripMenuItem")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return x.Nimike.CompareTo(y.Nimike);
                });
            }
            UpdateHenkilotListBox();
        }

        private void tsOA_Click(object sender, EventArgs e)
        {
            var a = (ToolStripMenuItem)sender;
            if (a.Name == "kutsumanimiToolStripMenuItem1")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return y.Kutsumanimi.CompareTo(x.Kutsumanimi);
                });
            }
            else if (a.Name == "sukunimiToolStripMenuItem1")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return y.Sukunimi.CompareTo(x.Sukunimi);
                });
            }
            else if (a.Name == "nimikeToolStripMenuItem1")
            {
                henkilot.Sort(delegate (Henkilo x, Henkilo y)
                {
                    return y.Nimike.CompareTo(x.Nimike);
                });
            }
            UpdateHenkilotListBox();
        }

        public void tbHetu_Leave(object sender, EventArgs e)
        {
            string sTarkistus, kokoluku;
            decimal desimaali;
            string tunnusSyöte = tbHetu.Text.ToUpper();
            char[] cTarkistusArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                'A', 'B', 'C', 'D', 'E', 'F', 'H', 'J', 'K', 'L', 'M', 'N','P','R','S','T','U','V','W','X','Y' };

            sTarkistus = (tbHetu.Text);

                // Alla olevat koodirivit tarkastavat HETUN
            kokoluku = "";
            for (int i = 0; i < sTarkistus.Length; i++)
            {
                if (i == 6 || i == 10) ; // Tämä ei tee mitään
                else
                    kokoluku += sTarkistus[i];
            }
                // tähän henkilötunnuksen tarkistus
            desimaali = decimal.Parse(kokoluku);


            //  Tämä lisätty kokeiluna
            //  decimal.TryParse(kokoluku, out desimaali);

            desimaali = desimaali / 31;

            desimaali = desimaali - (int)desimaali;
            desimaali = Math.Round(desimaali * 31);

            if (cTarkistusArray[(int)desimaali] != sTarkistus[sTarkistus.Count() - 1])
                MessageBox.Show("Syötit henkilötunnuksen väärin.");

        }
        
         // Seuraavat kaksi funktiota on tiedostoon kirjoittamiseen ja tideostosta lukemiseen tarvittavaa koodia 
        private void SerializeJSON(List<Henkilo> input)
        {
            string json = JsonConvert.SerializeObject(input); // Kirjoittaa tiedostoon
            System.IO.File.WriteAllText(personsfile, json);
        }
        private List<Henkilo> DeserializeJSON()
        {
            if (File.Exists(personsfile))
            {
                using (StreamReader r = new StreamReader(personsfile))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Henkilo>>(json);
                }
            }
            else
                return new List<Henkilo>();
        }

        private void lbTiedot_DoubleClick(object sender, EventArgs e)
        { // viedään muokattavat tiedot takaisin textboxeihin SHORTCUT

            var p = (ListBox)sender;
            iMuokIndex = p.SelectedIndex;

            Henkilo H = henkilot[iMuokIndex];

            tbEtunimet.Text = H.Etunimet;
            tbSukunimi.Text = H.Sukunimi;
            tbKutsumanimi.Text = H.Kutsumanimi;
            tbHetu.Text = H.Hetu;
            tbOsoite.Text = H.Katuosoite;
            tbPostiNro.Text = H.PostiNro;
            tbPostiPaikka.Text = H.PostiPaikka;
            dtpAlkaminen.Value = H.Alkaminen;
            dtpPaattyminen.Value = H.Paattyminen;
            cbNimike.Text = H.Nimike;
            cbYksikko.Text = H.Yksikko;

            bMuokattu = true;
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        { // Muokkaa napin käyttö. Voi käyttää myös aiemman funktion shortcuttia, jos sen huomaa.
            var p = lbTiedot;
            iMuokIndex = p.SelectedIndex;

            Henkilo H = henkilot[iMuokIndex];

            tbEtunimet.Text = H.Etunimet;
            tbSukunimi.Text = H.Sukunimi;
            tbKutsumanimi.Text = H.Kutsumanimi;
            tbHetu.Text = H.Hetu;
            tbOsoite.Text = H.Katuosoite;
            tbPostiNro.Text = H.PostiNro;
            tbPostiPaikka.Text = H.PostiPaikka;
            dtpAlkaminen.Value = H.Alkaminen;
            dtpPaattyminen.Value = H.Paattyminen;
            cbNimike.Text = H.Nimike;
            cbYksikko.Text = H.Yksikko;

            bMuokattu = true;
        }

        private void btnPoista_Click(object sender, EventArgs e)
        { // Poista napin käyttö.

            if (DialogResult.Yes == MessageBox.Show("Haluatko varmasti poistaa valitun tiedon?", "VAROITUS!", MessageBoxButtons.YesNo))
            {
                var p = lbTiedot;
                henkilot.RemoveAt(p.SelectedIndex);
                UpdateHenkilotListBox();
                SerializeJSON(henkilot);
            }
        }
            // Postinumeron automaattinen tunnistaminen listasta, jos se listassa löytyy.
        private void tbPostiNro_Leave(object sender, EventArgs e)
        {
            if (henkilot.Count != 0 && tbPostiNro.Text.Count() >= 5)
            {
                foreach (var item in henkilot)
                {
                    if (tbPostiNro.Text[0] == item.PostiNro[0] && tbPostiNro.Text[1] == item.PostiNro[1])
                    {
                        tbPostiPaikka.Text = item.PostiPaikka;
                    }
                }
            }
        }
            // Seuraava funktio poistaa mahdollisuuden kirjoittaa kirjaimia postinumeron paikalle.
        private void tbPostiNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}