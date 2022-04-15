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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form1 form1 { get; set; }

        private void Form3_Load(object sender, EventArgs e)
        {
            listViewIzleyiler.View = View.Details;

            listViewIzleyiler.Columns.Add(new ColumnHeader());
            listViewIzleyiler.Columns[0].Text = "Ad - Soyad";
            listViewIzleyiler.Columns[0].Width = this.Width / 3;

            listViewIzleyiler.Columns.Add(new ColumnHeader());
            listViewIzleyiler.Columns[1].Text = "T.C. Kimlik No";
            listViewIzleyiler.Columns[1].Width = this.Width / 3;

            listViewIzleyiler.Columns.Add(new ColumnHeader());
            listViewIzleyiler.Columns[2].Text = "Cinsiyet";
            listViewIzleyiler.Columns[2].Width = this.Width / 3;

        }

        public void KullanicilariListele(List<Form1.Izleyici> a)
        {
            int bayanSayisi = 0;
            int erkekSayisi = 0;
            foreach (var item in a)
            {
                string[] izleyici = { item.adSoyad, item.tc, item.cinsiyet };
                listViewIzleyiler.Items.Add(new ListViewItem(izleyici));
                if (item.cinsiyet == "Bayan")
                    bayanSayisi++;
                else
                    erkekSayisi++;
            }

            lblToplamIzleyiciSayisi.Text = a.Count.ToString();
            lblBayanIzleyiciSayisi.Text = bayanSayisi.ToString();
            lblErkekIzleyiciSayisi.Text = erkekSayisi.ToString();
        }
    }
}
