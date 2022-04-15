using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_11_11_2021_Sinema_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 form1 { get; set; }

        public Button tiklananKoltuk;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtTc.Text != "")
            {
                form1.izleyici.Add(new Form1.Izleyici { koltukNo = Convert.ToInt32(tiklananKoltuk.Text), adSoyad = txtAdSoyad.Text, tc = txtTc.Text, cinsiyet = rbBay.Checked == true ? "Bay" : "Bayan" });

                form1.KoltuguDoldur(tiklananKoltuk);
                this.Close();
            }
            else
                MessageBox.Show("Lütfen İsim ve TC Bilgilerinizi Giriniz.", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "")
            {
                for (int i = 0; i < form1.izleyici.Count; i++)
                {
                    if (form1.izleyici[i].adSoyad == txtAdSoyad.Text)
                    {
                        if (MessageBox.Show("Reveryasyonu iptal etmek istediğinize eminmisiniz...", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            form1.KoltuguBosalt(tiklananKoltuk);
                            form1.izleyici.RemoveAt(i);
                            FormuTemizle();
                        }
                    }
                }
            }
            else
                if (MessageBox.Show("Bu koltuk zaten boş...Ekranı kapatmak mı istiyorsunuz...", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FormuTemizle()
        {
            txtAdSoyad.Text = "";
            txtTc.Text = "";
            rbBay.Checked = true;
        }

        public void Form2EkraniniDoldur(Form1.Izleyici izleyici)
        {
            txtAdSoyad.Text = izleyici.adSoyad;
            txtTc.Text = izleyici.tc;
            if (izleyici.cinsiyet == "Bay")
                rbBay.Checked = true;
            else
                rbBayan.Checked = true;

        }
    }
}
