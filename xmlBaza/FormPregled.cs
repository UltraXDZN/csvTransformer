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

namespace csvTransformer
{
    public delegate void NotifyEvent(string ime, string prezime, string email, string razred);
    public partial class FormPregled : Form
    {
        public NotifyEvent notifyDelegate;

        FormFiltriranje filtriranjeForma = null;
        public FormPregled(NotifyEvent notify = null)
        {
            InitializeComponent();
            notifyDelegate += new NotifyEvent(Filtriranje);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            FormFiltriranje frmFiltriranje = new FormFiltriranje(notifyDelegate);
            frmFiltriranje.Show();
        }

        private void BtnUcitajDokument_Click(object sender, EventArgs e)
        {
            rtbIspisPodataka.Text = "";
            string lokacija = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "testNiOP");

            if (!File.Exists(lokacija))
            {
                Directory.CreateDirectory(lokacija);
            }
            StreamReader sw = new StreamReader(lokacija + "/report.csv");
            string saved_data = sw.ReadToEnd();
            string[] podaci = saved_data.Split(',');
            for (int i=0; i<podaci.Length; i++)
            {
                rtbIspisPodataka.Text += $"{podaci[i]}  ";
            }
            sw.Close();
        }

        void Filtriranje(string ime, string prezime, string email, string razred)
        {
            if (rtbIspisPodataka.Text.Contains(ime))
            {
                if (rtbIspisPodataka.Text.Contains(prezime))
                {
                    if (rtbIspisPodataka.Text.Contains(email))
                    {
                        if (rtbIspisPodataka.Text.Contains(razred))
                        {
                            rtbIspisPodataka.Text = $"{ime} {prezime} {email} {razred}";
                        }
                    }
                }
                    
            }
        }
    }
}
