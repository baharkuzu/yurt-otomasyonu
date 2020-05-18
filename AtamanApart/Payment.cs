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
    public partial class Payment : MaterialForm
    {
        public Payment()
        {
            InitializeComponent();
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.16.0; Data Source = your Path");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();


        private void odeme_islemi_Click(object sender, EventArgs e)
        {
            this.Close();
            PaymentRegistry paymentRegistry = new PaymentRegistry();
            paymentRegistry.Show();
        }

        public void veri_getir()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from odeme", baglanti);
            adtr.Fill(dtst, "odeme");
            dataGridView1.DataSource = dtst.Tables["odeme"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "TC No";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Oda No";
            dataGridView1.Columns[3].HeaderText = "Oda Ücret";
            dataGridView1.Columns[4].HeaderText = "Ödeme Şekli";
            dataGridView1.Columns[5].HeaderText = "Eylül";
            dataGridView1.Columns[6].HeaderText = "Ekim";
            dataGridView1.Columns[7].HeaderText = "Kasım";
            dataGridView1.Columns[8].HeaderText = "Aralık";
            dataGridView1.Columns[9].HeaderText = "Ocak";
            dataGridView1.Columns[10].HeaderText = "Şubat";
            dataGridView1.Columns[11].HeaderText = "Mart";
            dataGridView1.Columns[12].HeaderText = "Nisan";
            dataGridView1.Columns[13].HeaderText = "Mayıs";
            dataGridView1.Columns[14].HeaderText = "Haziran";
            dataGridView1.Columns[15].HeaderText = "Personel";


            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[11].Width = 70;
            dataGridView1.Columns[12].Width = 70;
            dataGridView1.Columns[13].Width = 70;
            dataGridView1.Columns[14].Width = 70;
            dataGridView1.Columns[15].Width = 70;

            #endregion
        }

        private void tum_kayit_Click(object sender, EventArgs e)
        {
            veri_getir();
            tum_kayit.Enabled = false;
        }

        private void ad_ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from odeme where ad_soyad like'" + ad_ara.Text + "%'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "odeme");
            dataGridView1.DataSource = dtst.Tables["odeme"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "TC No";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Oda No";
            dataGridView1.Columns[3].HeaderText = "Oda Ücret";
            dataGridView1.Columns[4].HeaderText = "Ödeme Şekli";
            dataGridView1.Columns[5].HeaderText = "Eylül";
            dataGridView1.Columns[6].HeaderText = "Ekim";
            dataGridView1.Columns[7].HeaderText = "Kasım";
            dataGridView1.Columns[8].HeaderText = "Aralık";
            dataGridView1.Columns[9].HeaderText = "Ocak";
            dataGridView1.Columns[10].HeaderText = "Şubat";
            dataGridView1.Columns[11].HeaderText = "Mart";
            dataGridView1.Columns[12].HeaderText = "Nisan";
            dataGridView1.Columns[13].HeaderText = "Mayıs";
            dataGridView1.Columns[14].HeaderText = "Haziran";
            dataGridView1.Columns[15].HeaderText = "Personel";


            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[11].Width = 70;
            dataGridView1.Columns[12].Width = 70;
            dataGridView1.Columns[13].Width = 70;
            dataGridView1.Columns[14].Width = 70;
            dataGridView1.Columns[15].Width = 70;

            #endregion
        }
    }
}
