namespace UDEMY_UYGULAMASI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbKulup = new System.Windows.Forms.ComboBox();
            this.BtOgrList = new System.Windows.Forms.Button();
            this.BtOgrGun = new System.Windows.Forms.Button();
            this.BtOgrSil = new System.Windows.Forms.Button();
            this.BtOgrKaydet = new System.Windows.Forms.Button();
            this.TxtFotograf = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtOgrId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOrt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtS3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtS2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtNotList = new System.Windows.Forms.Button();
            this.BtNotGun = new System.Windows.Forms.Button();
            this.TxtS1 = new System.Windows.Forms.TextBox();
            this.TxtNotId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtKulupSil = new System.Windows.Forms.Button();
            this.BtKulKaydet = new System.Windows.Forms.Button();
            this.BtKulupGun = new System.Windows.Forms.Button();
            this.TxtKulupAd = new System.Windows.Forms.TextBox();
            this.TxtKulupId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnKlpList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbKulup);
            this.groupBox1.Controls.Add(this.BtOgrList);
            this.groupBox1.Controls.Add(this.BtOgrGun);
            this.groupBox1.Controls.Add(this.BtOgrSil);
            this.groupBox1.Controls.Add(this.BtOgrKaydet);
            this.groupBox1.Controls.Add(this.TxtFotograf);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtOgrId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CmbKulup
            // 
            this.CmbKulup.FormattingEnabled = true;
            this.CmbKulup.Location = new System.Drawing.Point(123, 181);
            this.CmbKulup.Name = "CmbKulup";
            this.CmbKulup.Size = new System.Drawing.Size(216, 26);
            this.CmbKulup.TabIndex = 15;
            // 
            // BtOgrList
            // 
            this.BtOgrList.Location = new System.Drawing.Point(234, 270);
            this.BtOgrList.Name = "BtOgrList";
            this.BtOgrList.Size = new System.Drawing.Size(105, 23);
            this.BtOgrList.TabIndex = 14;
            this.BtOgrList.Text = "LISTELE";
            this.BtOgrList.UseVisualStyleBackColor = true;
            this.BtOgrList.Click += new System.EventHandler(this.BtOgrList_Click);
            // 
            // BtOgrGun
            // 
            this.BtOgrGun.Location = new System.Drawing.Point(123, 270);
            this.BtOgrGun.Name = "BtOgrGun";
            this.BtOgrGun.Size = new System.Drawing.Size(105, 23);
            this.BtOgrGun.TabIndex = 13;
            this.BtOgrGun.Text = "GUNCELLE";
            this.BtOgrGun.UseVisualStyleBackColor = true;
            this.BtOgrGun.Click += new System.EventHandler(this.BtOgrGun_Click);
            // 
            // BtOgrSil
            // 
            this.BtOgrSil.Location = new System.Drawing.Point(234, 232);
            this.BtOgrSil.Name = "BtOgrSil";
            this.BtOgrSil.Size = new System.Drawing.Size(105, 23);
            this.BtOgrSil.TabIndex = 12;
            this.BtOgrSil.Text = "SIL";
            this.BtOgrSil.UseVisualStyleBackColor = true;
            this.BtOgrSil.Click += new System.EventHandler(this.BtOgrSil_Click);
            // 
            // BtOgrKaydet
            // 
            this.BtOgrKaydet.Location = new System.Drawing.Point(123, 232);
            this.BtOgrKaydet.Name = "BtOgrKaydet";
            this.BtOgrKaydet.Size = new System.Drawing.Size(105, 23);
            this.BtOgrKaydet.TabIndex = 11;
            this.BtOgrKaydet.Text = "KAYDET";
            this.BtOgrKaydet.UseVisualStyleBackColor = true;
            this.BtOgrKaydet.Click += new System.EventHandler(this.BtOgrKaydet_Click);
            // 
            // TxtFotograf
            // 
            this.TxtFotograf.Location = new System.Drawing.Point(123, 143);
            this.TxtFotograf.Name = "TxtFotograf";
            this.TxtFotograf.Size = new System.Drawing.Size(216, 26);
            this.TxtFotograf.TabIndex = 9;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(123, 109);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(216, 26);
            this.TxtSoyad.TabIndex = 8;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(123, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(216, 26);
            this.TxtAd.TabIndex = 7;
            // 
            // TxtOgrId
            // 
            this.TxtOgrId.Location = new System.Drawing.Point(123, 36);
            this.TxtOgrId.Name = "TxtOgrId";
            this.TxtOgrId.Size = new System.Drawing.Size(216, 26);
            this.TxtOgrId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "KULUP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "FOTOGRAF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHesapla);
            this.groupBox2.Controls.Add(this.TxtDurum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtOrt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtProje);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtS3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtS2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtNotList);
            this.groupBox2.Controls.Add(this.BtNotGun);
            this.groupBox2.Controls.Add(this.TxtS1);
            this.groupBox2.Controls.Add(this.TxtNotId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(480, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 312);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(316, 127);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(80, 26);
            this.TxtDurum.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "DURUM";
            // 
            // TxtOrt
            // 
            this.TxtOrt.Location = new System.Drawing.Point(316, 95);
            this.TxtOrt.Name = "TxtOrt";
            this.TxtOrt.Size = new System.Drawing.Size(80, 26);
            this.TxtOrt.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "ORTALAMA";
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(316, 60);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(80, 26);
            this.TxtProje.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "PROJE";
            // 
            // TxtS3
            // 
            this.TxtS3.Location = new System.Drawing.Point(123, 132);
            this.TxtS3.Name = "TxtS3";
            this.TxtS3.Size = new System.Drawing.Size(80, 26);
            this.TxtS3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "SINAV3";
            // 
            // TxtS2
            // 
            this.TxtS2.Location = new System.Drawing.Point(123, 100);
            this.TxtS2.Name = "TxtS2";
            this.TxtS2.Size = new System.Drawing.Size(80, 26);
            this.TxtS2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "SINAV2";
            // 
            // BtNotList
            // 
            this.BtNotList.Location = new System.Drawing.Point(291, 205);
            this.BtNotList.Name = "BtNotList";
            this.BtNotList.Size = new System.Drawing.Size(105, 23);
            this.BtNotList.TabIndex = 14;
            this.BtNotList.Text = "LISTELE";
            this.BtNotList.UseVisualStyleBackColor = true;
            this.BtNotList.Click += new System.EventHandler(this.BtNotList_Click);
            // 
            // BtNotGun
            // 
            this.BtNotGun.Location = new System.Drawing.Point(98, 205);
            this.BtNotGun.Name = "BtNotGun";
            this.BtNotGun.Size = new System.Drawing.Size(105, 23);
            this.BtNotGun.TabIndex = 13;
            this.BtNotGun.Text = "GUNCELLE";
            this.BtNotGun.UseVisualStyleBackColor = true;
            this.BtNotGun.Click += new System.EventHandler(this.BtNotGun_Click);
            // 
            // TxtS1
            // 
            this.TxtS1.Location = new System.Drawing.Point(123, 68);
            this.TxtS1.Name = "TxtS1";
            this.TxtS1.Size = new System.Drawing.Size(80, 26);
            this.TxtS1.TabIndex = 7;
            // 
            // TxtNotId
            // 
            this.TxtNotId.Location = new System.Drawing.Point(123, 36);
            this.TxtNotId.Name = "TxtNotId";
            this.TxtNotId.Size = new System.Drawing.Size(80, 26);
            this.TxtNotId.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "SINAV1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKlpList);
            this.groupBox3.Controls.Add(this.BtKulupSil);
            this.groupBox3.Controls.Add(this.BtKulKaydet);
            this.groupBox3.Controls.Add(this.BtKulupGun);
            this.groupBox3.Controls.Add(this.TxtKulupAd);
            this.groupBox3.Controls.Add(this.TxtKulupId);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(934, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 312);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kulupler";
            // 
            // BtKulupSil
            // 
            this.BtKulupSil.Location = new System.Drawing.Point(195, 167);
            this.BtKulupSil.Name = "BtKulupSil";
            this.BtKulupSil.Size = new System.Drawing.Size(105, 23);
            this.BtKulupSil.TabIndex = 16;
            this.BtKulupSil.Text = "SIL";
            this.BtKulupSil.UseVisualStyleBackColor = true;
            this.BtKulupSil.Click += new System.EventHandler(this.BtKulupSil_Click);
            // 
            // BtKulKaydet
            // 
            this.BtKulKaydet.Location = new System.Drawing.Point(84, 167);
            this.BtKulKaydet.Name = "BtKulKaydet";
            this.BtKulKaydet.Size = new System.Drawing.Size(105, 23);
            this.BtKulKaydet.TabIndex = 15;
            this.BtKulKaydet.Text = "KAYDET";
            this.BtKulKaydet.UseVisualStyleBackColor = true;
            this.BtKulKaydet.Click += new System.EventHandler(this.BtKulKaydet_Click);
            // 
            // BtKulupGun
            // 
            this.BtKulupGun.Location = new System.Drawing.Point(84, 207);
            this.BtKulupGun.Name = "BtKulupGun";
            this.BtKulupGun.Size = new System.Drawing.Size(105, 23);
            this.BtKulupGun.TabIndex = 13;
            this.BtKulupGun.Text = "GUNCELLE";
            this.BtKulupGun.UseVisualStyleBackColor = true;
            this.BtKulupGun.Click += new System.EventHandler(this.BtKulupGun_Click);
            // 
            // TxtKulupAd
            // 
            this.TxtKulupAd.Location = new System.Drawing.Point(176, 100);
            this.TxtKulupAd.Name = "TxtKulupAd";
            this.TxtKulupAd.Size = new System.Drawing.Size(124, 26);
            this.TxtKulupAd.TabIndex = 7;
            // 
            // TxtKulupId
            // 
            this.TxtKulupId.Location = new System.Drawing.Point(176, 71);
            this.TxtKulupId.Name = "TxtKulupId";
            this.TxtKulupId.Size = new System.Drawing.Size(124, 26);
            this.TxtKulupId.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(134, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "KULUPAD";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(33, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1258, 239);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1252, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(199, 248);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(102, 23);
            this.BtnHesapla.TabIndex = 27;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnKlpList
            // 
            this.BtnKlpList.Location = new System.Drawing.Point(195, 207);
            this.BtnKlpList.Name = "BtnKlpList";
            this.BtnKlpList.Size = new System.Drawing.Size(105, 23);
            this.BtnKlpList.TabIndex = 17;
            this.BtnKlpList.Text = "LISTELE";
            this.BtnKlpList.UseVisualStyleBackColor = true;
            this.BtnKlpList.Click += new System.EventHandler(this.BtnKlpList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1335, 695);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtOgrList;
        private System.Windows.Forms.Button BtOgrGun;
        private System.Windows.Forms.Button BtOgrSil;
        private System.Windows.Forms.Button BtOgrKaydet;
        private System.Windows.Forms.TextBox TxtFotograf;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtOgrId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbKulup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOrt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtS3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtS2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtNotList;
        private System.Windows.Forms.Button BtNotGun;
        private System.Windows.Forms.TextBox TxtS1;
        private System.Windows.Forms.TextBox TxtNotId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtKulupSil;
        private System.Windows.Forms.Button BtKulKaydet;
        private System.Windows.Forms.Button BtKulupGun;
        private System.Windows.Forms.TextBox TxtKulupAd;
        private System.Windows.Forms.TextBox TxtKulupId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnKlpList;
    }
}

