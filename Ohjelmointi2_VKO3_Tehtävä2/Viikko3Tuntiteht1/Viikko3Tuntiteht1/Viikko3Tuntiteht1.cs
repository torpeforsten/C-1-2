using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Viikko3Tuntiteht1
{
    public partial class Viikko3Tuntiteht1 : Form
    {
        bool muuttunut;

        public Viikko3Tuntiteht1()
        {
            InitializeComponent();
            muuttunut = false;
        }

        private void menuVie_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\teksti.txt");
            sw.WriteLine(tbTeksti.Text);
            sw.Close();
        }

        private void menuTuo_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"c:\temp\teksti.txt");
            tbTeksti.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void menuLopeta_Click(object sender, EventArgs e)
        {
            DialogResult rs = DialogResult.Yes;

            if (muuttunut == true)
            {
                rs = MessageBox.Show("Lopetetaanko ? ", "Loppuuko", MessageBoxButtons.YesNo);
            }

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbTeksti_TextChanged(object sender, EventArgs e)
        {
            muuttunut = true;
        }

        private void tyhjennäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTeksti.Clear();
        }
    }
}
