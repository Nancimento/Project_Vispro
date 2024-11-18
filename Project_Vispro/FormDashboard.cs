using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Vispro
{
    public partial class FormDashboard: Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Formlapangan formlapangan = new Formlapangan();
            formlapangan.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
        }
    }
}
