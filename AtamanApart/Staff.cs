using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AtamanApart
{
    public partial class Staff : MaterialForm
    {
        public Staff()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.16.0; Data Source =your Path");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void guvenlik_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev= 'Güvenlik'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;

            #endregion
        }

        private void temizlik_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev= 'Temizlik'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;

            #endregion
        }

        private void yonetim_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev='Yönetim'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;

            #endregion
        }
        private void personel_islem_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffRegistry staffRegistry = new StaffRegistry();
            staffRegistry.Show();
        }

        private void yonetmelik_Click(object sender, EventArgs e)
        {
            if(yonetmelik.Text== "Yönetmeliği Göster")
            {
                yonetmelik.Text = "Yönetmeliği Kapat";
                dataGridView1.Visible = false;
                axAcroPDF1.Visible = true;
                axAcroPDF1.src = "your path";
            }
            else
            {
                yonetmelik.Text = "Yönetmelik Göster";
                dataGridView1.Visible = true;
                axAcroPDF1.Visible = false;
            }
            
        }
    }
}
