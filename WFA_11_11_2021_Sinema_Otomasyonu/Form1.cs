using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_11_11_2021_Sinema_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        TableLayoutPanel tlp = new TableLayoutPanel();
        public List<Izleyici> izleyici = new List<Izleyici>();

        public class Izleyici
        {
            public int koltukNo { get; set; }
            public string adSoyad { get; set; }
            public string tc { get; set; }
            public string cinsiyet { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tlp.ColumnCount = 12;
            tlp.RowCount = 6;
            tlp.AutoSize = true;
            tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            int koltukNumarasi = 1;
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
                for (int j = 0; j < tlp.RowCount; j++)
                {
                    tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
                    Button btn = new Button();
                    btn.Text = koltukNumarasi.ToString();
                    koltukNumarasi++;
                    btn.Name = $"koltuk_{i}_{j}";
                    btn.Dock = DockStyle.Fill;
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                    btn.BackgroundImage = Image.FromFile($"{path}\\Images\\mavi.jpg");
                    btn.Click += Btn_Click;
                    tlp.Controls.Add(btn, i, j);
                }
            }
            panel2.Controls.Add(tlp);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 kullanıcıKaydi = new Form2();
            kullanıcıKaydi.form1 = this;

            Button tiklananButon = sender as Button;
            if (izleyici.Count!=0)
            {
                foreach (var item in izleyici)
                {
                    if (item.koltukNo ==Convert.ToInt32( tiklananButon.Text))
                    {
                        kullanıcıKaydi.Form2EkraniniDoldur(item );
                    } 
                }
            }
                kullanıcıKaydi.tiklananKoltuk = (sender as Button);

            kullanıcıKaydi.ShowDialog();

        }

        public void KoltuguDoldur(Button btn)
        {
            foreach (Button item in tlp.Controls)
            {
                if (item.Name == btn.Name)
                {
                    item.BackgroundImage = Image.FromFile($"{path}\\Images\\kirmizi.jpg");
                    item.Tag = "Dolu";
                }
            }
           
        }

        public void KoltuguBosalt(Button btn)
        {
            foreach (Button item in tlp.Controls)
            {
                if (item.Name == btn.Name)
                {
                    item.BackgroundImage = Image.FromFile($"{path}\\Images\\mavi.jpg");
                    item.Tag = "Boş";
                }
            }
        }

        private void btnGunlukAnaliz_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.form1 = this;
            form3.KullanicilariListele(izleyici);
            form3.ShowDialog();
        }
    }
}
