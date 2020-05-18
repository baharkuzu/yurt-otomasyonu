namespace AtamanApart
{
    partial class StudentRegistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.tc_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.oda_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.durum_pasif = new MaterialSkin.Controls.MaterialRadioButton();
            this.durum_aktif = new MaterialSkin.Controls.MaterialRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.kayit_ara = new MaterialSkin.Controls.MaterialRaisedButton();
            this.temizle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.yakin_tel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.baba_adsoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.anne_adsoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ikanetgah = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tel_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.sinif = new System.Windows.Forms.ComboBox();
            this.okul = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.d_tarih = new System.Windows.Forms.DateTimePicker();
            this.bolum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.soyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Olive;
            this.label13.Location = new System.Drawing.Point(12, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 22);
            this.label13.TabIndex = 34;
            this.label13.Text = "T.C Kimlik Numarası:";
            // 
            // tc_no
            // 
            this.tc_no.Depth = 0;
            this.tc_no.Hint = "";
            this.tc_no.Location = new System.Drawing.Point(169, 45);
            this.tc_no.MaxLength = 32767;
            this.tc_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc_no.Name = "tc_no";
            this.tc_no.PasswordChar = '\0';
            this.tc_no.SelectedText = "";
            this.tc_no.SelectionLength = 0;
            this.tc_no.SelectionStart = 0;
            this.tc_no.Size = new System.Drawing.Size(263, 23);
            this.tc_no.TabIndex = 35;
            this.tc_no.TabStop = false;
            this.tc_no.UseSystemPasswordChar = false;
            this.tc_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_no_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.oda_no);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.durum_pasif);
            this.groupBox3.Controls.Add(this.durum_aktif);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.kayit_ara);
            this.groupBox3.Controls.Add(this.temizle);
            this.groupBox3.Controls.Add(this.yakin_tel);
            this.groupBox3.Controls.Add(this.baba_adsoyad);
            this.groupBox3.Controls.Add(this.anne_adsoyad);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ikanetgah);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.sehir);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tel_no);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.sinif);
            this.groupBox3.Controls.Add(this.okul);
            this.groupBox3.Controls.Add(this.d_tarih);
            this.groupBox3.Controls.Add(this.bolum);
            this.groupBox3.Controls.Add(this.soyad);
            this.groupBox3.Controls.Add(this.ad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tc_no);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(230, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 600);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Bilgileri";
            // 
            // oda_no
            // 
            this.oda_no.Depth = 0;
            this.oda_no.Hint = "";
            this.oda_no.Location = new System.Drawing.Point(608, 297);
            this.oda_no.MaxLength = 32767;
            this.oda_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.oda_no.Name = "oda_no";
            this.oda_no.PasswordChar = '\0';
            this.oda_no.SelectedText = "";
            this.oda_no.SelectionLength = 0;
            this.oda_no.SelectionStart = 0;
            this.oda_no.Size = new System.Drawing.Size(206, 23);
            this.oda_no.TabIndex = 67;
            this.oda_no.TabStop = false;
            this.oda_no.UseSystemPasswordChar = false;
            this.oda_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oda_no_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(476, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 22);
            this.label14.TabIndex = 66;
            this.label14.Text = "Oda Numarası:";
            // 
            // durum_pasif
            // 
            this.durum_pasif.AutoSize = true;
            this.durum_pasif.Depth = 0;
            this.durum_pasif.Font = new System.Drawing.Font("Roboto", 10F);
            this.durum_pasif.Location = new System.Drawing.Point(753, 243);
            this.durum_pasif.Margin = new System.Windows.Forms.Padding(0);
            this.durum_pasif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.durum_pasif.MouseState = MaterialSkin.MouseState.HOVER;
            this.durum_pasif.Name = "durum_pasif";
            this.durum_pasif.Ripple = true;
            this.durum_pasif.Size = new System.Drawing.Size(61, 30);
            this.durum_pasif.TabIndex = 65;
            this.durum_pasif.TabStop = true;
            this.durum_pasif.Text = "Pasif";
            this.durum_pasif.UseVisualStyleBackColor = true;
            // 
            // durum_aktif
            // 
            this.durum_aktif.AutoSize = true;
            this.durum_aktif.Depth = 0;
            this.durum_aktif.Font = new System.Drawing.Font("Roboto", 10F);
            this.durum_aktif.Location = new System.Drawing.Point(605, 242);
            this.durum_aktif.Margin = new System.Windows.Forms.Padding(0);
            this.durum_aktif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.durum_aktif.MouseState = MaterialSkin.MouseState.HOVER;
            this.durum_aktif.Name = "durum_aktif";
            this.durum_aktif.Ripple = true;
            this.durum_aktif.Size = new System.Drawing.Size(58, 30);
            this.durum_aktif.TabIndex = 64;
            this.durum_aktif.TabStop = true;
            this.durum_aktif.Text = "Aktif";
            this.durum_aktif.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(476, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 63;
            this.label11.Text = "Durum:";
            // 
            // kayit_ara
            // 
            this.kayit_ara.AutoSize = true;
            this.kayit_ara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kayit_ara.Depth = 0;
            this.kayit_ara.Icon = null;
            this.kayit_ara.Location = new System.Drawing.Point(342, 98);
            this.kayit_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.kayit_ara.Name = "kayit_ara";
            this.kayit_ara.Primary = true;
            this.kayit_ara.Size = new System.Drawing.Size(90, 36);
            this.kayit_ara.TabIndex = 11;
            this.kayit_ara.Text = "KAYIT ARA";
            this.kayit_ara.UseVisualStyleBackColor = true;
            this.kayit_ara.Click += new System.EventHandler(this.kayit_ara_Click);
            // 
            // temizle
            // 
            this.temizle.AutoSize = true;
            this.temizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temizle.Depth = 0;
            this.temizle.Icon = null;
            this.temizle.Location = new System.Drawing.Point(768, 558);
            this.temizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.temizle.Name = "temizle";
            this.temizle.Primary = true;
            this.temizle.Size = new System.Drawing.Size(76, 36);
            this.temizle.TabIndex = 62;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // yakin_tel
            // 
            this.yakin_tel.Depth = 0;
            this.yakin_tel.Hint = "";
            this.yakin_tel.Location = new System.Drawing.Point(658, 440);
            this.yakin_tel.MaxLength = 32767;
            this.yakin_tel.MouseState = MaterialSkin.MouseState.HOVER;
            this.yakin_tel.Name = "yakin_tel";
            this.yakin_tel.PasswordChar = '\0';
            this.yakin_tel.SelectedText = "";
            this.yakin_tel.SelectionLength = 0;
            this.yakin_tel.SelectionStart = 0;
            this.yakin_tel.Size = new System.Drawing.Size(156, 23);
            this.yakin_tel.TabIndex = 61;
            this.yakin_tel.TabStop = false;
            this.yakin_tel.UseSystemPasswordChar = false;
            this.yakin_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yakin_tel_KeyPress);
            // 
            // baba_adsoyad
            // 
            this.baba_adsoyad.Depth = 0;
            this.baba_adsoyad.Hint = "";
            this.baba_adsoyad.Location = new System.Drawing.Point(608, 390);
            this.baba_adsoyad.MaxLength = 32767;
            this.baba_adsoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.baba_adsoyad.Name = "baba_adsoyad";
            this.baba_adsoyad.PasswordChar = '\0';
            this.baba_adsoyad.SelectedText = "";
            this.baba_adsoyad.SelectionLength = 0;
            this.baba_adsoyad.SelectionStart = 0;
            this.baba_adsoyad.Size = new System.Drawing.Size(206, 23);
            this.baba_adsoyad.TabIndex = 60;
            this.baba_adsoyad.TabStop = false;
            this.baba_adsoyad.UseSystemPasswordChar = false;
            this.baba_adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baba_adsoyad_KeyPress);
            // 
            // anne_adsoyad
            // 
            this.anne_adsoyad.Depth = 0;
            this.anne_adsoyad.Hint = "";
            this.anne_adsoyad.Location = new System.Drawing.Point(608, 339);
            this.anne_adsoyad.MaxLength = 32767;
            this.anne_adsoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.anne_adsoyad.Name = "anne_adsoyad";
            this.anne_adsoyad.PasswordChar = '\0';
            this.anne_adsoyad.SelectedText = "";
            this.anne_adsoyad.SelectionLength = 0;
            this.anne_adsoyad.SelectionStart = 0;
            this.anne_adsoyad.Size = new System.Drawing.Size(206, 23);
            this.anne_adsoyad.TabIndex = 59;
            this.anne_adsoyad.TabStop = false;
            this.anne_adsoyad.UseSystemPasswordChar = false;
            this.anne_adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anne_adsoyad_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Olive;
            this.label15.Location = new System.Drawing.Point(476, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 22);
            this.label15.TabIndex = 58;
            this.label15.Text = "Yakın Telefon Numarası:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(476, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 56;
            this.label12.Text = "Baba Adı Soyadı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(476, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 54;
            this.label10.Text = "Anne Adı Soyadı:";
            // 
            // ikanetgah
            // 
            this.ikanetgah.BackColor = System.Drawing.SystemColors.Window;
            this.ikanetgah.Location = new System.Drawing.Point(608, 44);
            this.ikanetgah.Multiline = true;
            this.ikanetgah.Name = "ikanetgah";
            this.ikanetgah.Size = new System.Drawing.Size(206, 174);
            this.ikanetgah.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(476, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "İkametgah:";
            // 
            // sehir
            // 
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Ağrı",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Iğdır",
            "K.Maraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Kırklareli",
            "Kırıkkale",
            "Kırşehir",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "İstanbul",
            "İzmir",
            "Şanlıurfa",
            "Şırnak"});
            this.sehir.Location = new System.Drawing.Point(169, 515);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(263, 28);
            this.sehir.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(12, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Şehir:";
            // 
            // tel_no
            // 
            this.tel_no.Depth = 0;
            this.tel_no.Hint = "";
            this.tel_no.Location = new System.Drawing.Point(169, 466);
            this.tel_no.MaxLength = 32767;
            this.tel_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tel_no.Name = "tel_no";
            this.tel_no.PasswordChar = '\0';
            this.tel_no.SelectedText = "";
            this.tel_no.SelectionLength = 0;
            this.tel_no.SelectionStart = 0;
            this.tel_no.Size = new System.Drawing.Size(263, 23);
            this.tel_no.TabIndex = 49;
            this.tel_no.TabStop = false;
            this.tel_no.UseSystemPasswordChar = false;
            this.tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_no_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(12, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "Telefon Numarası:";
            // 
            // sinif
            // 
            this.sinif.FormattingEnabled = true;
            this.sinif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.sinif.Location = new System.Drawing.Point(169, 412);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(263, 28);
            this.sinif.TabIndex = 47;
            // 
            // okul
            // 
            this.okul.Depth = 0;
            this.okul.Hint = "";
            this.okul.Location = new System.Drawing.Point(169, 314);
            this.okul.MaxLength = 32767;
            this.okul.MouseState = MaterialSkin.MouseState.HOVER;
            this.okul.Name = "okul";
            this.okul.PasswordChar = '\0';
            this.okul.SelectedText = "";
            this.okul.SelectionLength = 0;
            this.okul.SelectionStart = 0;
            this.okul.Size = new System.Drawing.Size(263, 23);
            this.okul.TabIndex = 46;
            this.okul.TabStop = false;
            this.okul.UseSystemPasswordChar = false;
            this.okul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.okul_KeyPress);
            // 
            // d_tarih
            // 
            this.d_tarih.Location = new System.Drawing.Point(169, 262);
            this.d_tarih.Name = "d_tarih";
            this.d_tarih.Size = new System.Drawing.Size(263, 26);
            this.d_tarih.TabIndex = 45;
            // 
            // bolum
            // 
            this.bolum.Depth = 0;
            this.bolum.Hint = "";
            this.bolum.Location = new System.Drawing.Point(169, 363);
            this.bolum.MaxLength = 32767;
            this.bolum.MouseState = MaterialSkin.MouseState.HOVER;
            this.bolum.Name = "bolum";
            this.bolum.PasswordChar = '\0';
            this.bolum.SelectedText = "";
            this.bolum.SelectionLength = 0;
            this.bolum.SelectionStart = 0;
            this.bolum.Size = new System.Drawing.Size(263, 23);
            this.bolum.TabIndex = 44;
            this.bolum.TabStop = false;
            this.bolum.UseSystemPasswordChar = false;
            // 
            // soyad
            // 
            this.soyad.Depth = 0;
            this.soyad.Hint = "";
            this.soyad.Location = new System.Drawing.Point(169, 213);
            this.soyad.MaxLength = 32767;
            this.soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.soyad.Name = "soyad";
            this.soyad.PasswordChar = '\0';
            this.soyad.SelectedText = "";
            this.soyad.SelectionLength = 0;
            this.soyad.SelectionStart = 0;
            this.soyad.Size = new System.Drawing.Size(263, 23);
            this.soyad.TabIndex = 43;
            this.soyad.TabStop = false;
            this.soyad.UseSystemPasswordChar = false;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // ad
            // 
            this.ad.Depth = 0;
            this.ad.Hint = "";
            this.ad.Location = new System.Drawing.Point(169, 164);
            this.ad.MaxLength = 32767;
            this.ad.MouseState = MaterialSkin.MouseState.HOVER;
            this.ad.Name = "ad";
            this.ad.PasswordChar = '\0';
            this.ad.SelectedText = "";
            this.ad.SelectionLength = 0;
            this.ad.SelectionStart = 0;
            this.ad.Size = new System.Drawing.Size(263, 23);
            this.ad.TabIndex = 42;
            this.ad.TabStop = false;
            this.ad.UseSystemPasswordChar = false;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sınıf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(12, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Bölüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(12, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Okul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad:";
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Olive;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.ekle.Location = new System.Drawing.Point(15, 240);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(196, 54);
            this.ekle.TabIndex = 8;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Olive;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.guncelle.Location = new System.Drawing.Point(15, 325);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(196, 54);
            this.guncelle.TabIndex = 9;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Olive;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.Window;
            this.sil.Location = new System.Drawing.Point(15, 410);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(196, 54);
            this.sil.TabIndex = 10;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // StudentRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "StudentRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialSingleLineTextField tc_no;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker d_tarih;
        private MaterialSkin.Controls.MaterialSingleLineTextField bolum;
        private MaterialSkin.Controls.MaterialSingleLineTextField soyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ikanetgah;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField tel_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sinif;
        private MaterialSkin.Controls.MaterialSingleLineTextField okul;
        private MaterialSkin.Controls.MaterialSingleLineTextField yakin_tel;
        private MaterialSkin.Controls.MaterialSingleLineTextField baba_adsoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField anne_adsoyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialRaisedButton temizle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private MaterialSkin.Controls.MaterialRadioButton durum_pasif;
        private MaterialSkin.Controls.MaterialRadioButton durum_aktif;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialRaisedButton kayit_ara;
        private MaterialSkin.Controls.MaterialSingleLineTextField oda_no;
        private System.Windows.Forms.Label label14;
    }
}