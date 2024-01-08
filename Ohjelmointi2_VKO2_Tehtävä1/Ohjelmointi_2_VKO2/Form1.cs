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

namespace Ohjelmointi_2_VKO2
{
    public partial class FormHenkilöt : Form
    {
        public struct Henkilo
        {
            public string FirstName;
            public string LastName;
            public string Dob;
            public string JobTitle;
            public DateTime JobStart;
            public DateTime JobEnd;
        }
        ArrayList henkilot = new ArrayList();

        public FormHenkilöt()
        {
            InitializeComponent();
        }

        private void btnLisääTiedot_Click(object sender, EventArgs e)
        {
            Henkilo h = new Henkilo();
            h.FirstName = tbFirstName.Text;
            h.LastName = tbLastName.Text;
            h.Dob = tbDOB.Text;
            h.JobStart = dtpStart.Value;
            h.JobEnd = dtpEnd.Value;
            henkilot.Add(h);
            h.JobTitle = cbNimike.Text;

            MessageBox.Show(tbFirstName.Text + " " + tbLastName.Text + " " + tbDOB.Text + " " + cbNimike.Text + " " + dtpStart.Value.ToShortDateString() + " " + dtpEnd.Value.ToShortDateString());
        }
    }
}
