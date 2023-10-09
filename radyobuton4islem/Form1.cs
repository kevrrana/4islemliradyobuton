using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radyobuton4islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToSingle(txtSayi1.Text);
            sayi2 = Convert.ToSingle(txtSayi2.Text);

            if (rbToplam.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (rbCikarma.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (rbCarpma.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (rbBolme.Checked)
            {
                sonuc=sayi1 / sayi2;
            }

            lblSonuc.Text = "Sonuç: " + sonuc.ToString();
        }
    }
}
