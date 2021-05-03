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
    public partial class FormUnosPodataka : Form
    {
        public FormUnosPodataka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnosPodataka_Click(object sender, EventArgs e)
        {
            if (txtEmailUnos.Text.Contains("@"))
            {

                string lokacija = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "testNiOP");

                string saved_data = txtImeUnos.Text + "," + txtPrezimeUnos.Text + "," + txtEmailUnos.Text + "," + cmbRazredUnos.Text + ",\r\n";

                if (!File.Exists(lokacija))
                {
                    Directory.CreateDirectory(lokacija);
                }
                StreamWriter sw = new StreamWriter(lokacija + "/report.csv", true);
                sw.Write(saved_data);
                sw.Close();
                MessageBox.Show("Podaci uneseni!", "Unos uspješan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Krivi unos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
