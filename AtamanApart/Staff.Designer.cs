namespace AtamanApart
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temizlik = new System.Windows.Forms.Button();
            this.yonetim = new System.Windows.Forms.Button();
            this.guvenlik = new System.Windows.Forms.Button();
            this.personel_islem = new System.Windows.Forms.Button();
            this.calisma_cizelgesi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.yonetmelik = new MaterialSkin.Controls.MaterialRaisedButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // temizlik
            // 
            this.temizlik.BackColor = System.Drawing.Color.Olive;
            this.temizlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizlik.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlik.ForeColor = System.Drawing.SystemColors.Window;
            this.temizlik.Location = new System.Drawing.Point(12, 210);
            this.temizlik.Name = "temizlik";
            this.temizlik.Size = new System.Drawing.Size(196, 78);
            this.temizlik.TabIndex = 9;
            this.temizlik.Text = "TEMİZLİK";
            this.temizlik.UseVisualStyleBackColor = false;
            this.temizlik.Click += new System.EventHandler(this.temizlik_Click);
            // 
            // yonetim
            // 
            this.yonetim.BackColor = System.Drawing.Color.Olive;
            this.yonetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yonetim.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetim.ForeColor = System.Drawing.SystemColors.Window;
            this.yonetim.Location = new System.Drawing.Point(12, 313);
            this.yonetim.Name = "yonetim";
            this.yonetim.Size = new System.Drawing.Size(196, 78);
            this.yonetim.TabIndex = 10;
            this.yonetim.Text = "YÖNETİM";
            this.yonetim.UseVisualStyleBackColor = false;
            this.yonetim.Click += new System.EventHandler(this.yonetim_Click);
            // 
            // guvenlik
            // 
            this.guvenlik.BackColor = System.Drawing.Color.Olive;
            this.guvenlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guvenlik.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlik.ForeColor = System.Drawing.SystemColors.Window;
            this.guvenlik.Location = new System.Drawing.Point(12, 107);
            this.guvenlik.Name = "guvenlik";
            this.guvenlik.Size = new System.Drawing.Size(196, 78);
            this.guvenlik.TabIndex = 11;
            this.guvenlik.Text = "GÜVENLİK";
            this.guvenlik.UseVisualStyleBackColor = false;
            this.guvenlik.Click += new System.EventHandler(this.guvenlik_Click);
            // 
            // personel_islem
            // 
            this.personel_islem.BackColor = System.Drawing.Color.Olive;
            this.personel_islem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_islem.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_islem.ForeColor = System.Drawing.SystemColors.Window;
            this.personel_islem.Location = new System.Drawing.Point(12, 416);
            this.personel_islem.Name = "personel_islem";
            this.personel_islem.Size = new System.Drawing.Size(196, 78);
            this.personel_islem.TabIndex = 12;
            this.personel_islem.Text = "PERSONEL İŞLEMLERİ";
            this.personel_islem.UseVisualStyleBackColor = false;
            this.personel_islem.Click += new System.EventHandler(this.personel_islem_Click);
            // 
            // calisma_cizelgesi
            // 
            this.calisma_cizelgesi.AutoSize = true;
            this.calisma_cizelgesi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calisma_cizelgesi.Depth = 0;
            this.calisma_cizelgesi.Icon = null;
            this.calisma_cizelgesi.Location = new System.Drawing.Point(39, 602);
            this.calisma_cizelgesi.MouseState = MaterialSkin.MouseState.HOVER;
            this.calisma_cizelgesi.Name = "calisma_cizelgesi";
            this.calisma_cizelgesi.Primary = true;
            this.calisma_cizelgesi.Size = new System.Drawing.Size(149, 36);
            this.calisma_cizelgesi.TabIndex = 63;
            this.calisma_cizelgesi.Text = "ÇALIŞMA ÇİZELGESİ";
            this.calisma_cizelgesi.UseVisualStyleBackColor = true;
            // 
            // yonetmelik
            // 
            this.yonetmelik.AutoSize = true;
            this.yonetmelik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yonetmelik.Depth = 0;
            this.yonetmelik.Icon = null;
            this.yonetmelik.Location = new System.Drawing.Point(33, 644);
            this.yonetmelik.MouseState = MaterialSkin.MouseState.HOVER;
            this.yonetmelik.Name = "yonetmelik";
            this.yonetmelik.Primary = true;
            this.yonetmelik.Size = new System.Drawing.Size(164, 36);
            this.yonetmelik.TabIndex = 64;
            this.yonetmelik.Text = "Yönetmeliği Göster";
            this.yonetmelik.UseVisualStyleBackColor = true;
            this.yonetmelik.Click += new System.EventHandler(this.yonetmelik_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(230, 80);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(850, 600);
            this.axAcroPDF1.TabIndex = 65;
            this.axAcroPDF1.Visible = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.yonetmelik);
            this.Controls.Add(this.calisma_cizelgesi);
            this.Controls.Add(this.personel_islem);
            this.Controls.Add(this.guvenlik);
            this.Controls.Add(this.yonetim);
            this.Controls.Add(this.temizlik);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button temizlik;
        private System.Windows.Forms.Button yonetim;
        private System.Windows.Forms.Button guvenlik;
        private System.Windows.Forms.Button personel_islem;
        private MaterialSkin.Controls.MaterialRaisedButton calisma_cizelgesi;
        private MaterialSkin.Controls.MaterialRaisedButton yonetmelik;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}