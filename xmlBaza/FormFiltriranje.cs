using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvTransformer
{
    public partial class FormFiltriranje : Form
    {
        NotifyEvent filter;
        string ime = "";
        string prezime = "";
        string email = "";
        string razred = "";

        public FormFiltriranje(NotifyEvent notify)
        {
            InitializeComponent();
            filter = notify;
        }

        private void btnOdustaniFilter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrirajPodatke_Click(object sender, EventArgs e)
        {
            ime = txtImeFilter.Text;
            prezime = txtPrezimeFilter.Text;
            email = txtEmailFilter.Text;
            razred = cmbRazredFilter.Text;
            filter.Invoke(ime, prezime, email, razred);
        }
    }
}
