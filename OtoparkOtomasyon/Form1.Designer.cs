namespace OtoparkOtomasyon
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MusteriGuncelle = new System.Windows.Forms.Button();
            this.MusteriSil = new System.Windows.Forms.Button();
            this.MusteriEkle = new System.Windows.Forms.Button();
            this.dataGridMusteri = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Musteri_adres = new System.Windows.Forms.TextBox();
            this.Musteri_tel_no = new System.Windows.Forms.TextBox();
            this.Musteri_soyad = new System.Windows.Forms.TextBox();
            this.Musteri_ad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AracGuncelle = new System.Windows.Forms.Button();
            this.AracSil = new System.Windows.Forms.Button();
            this.AracEkle = new System.Windows.Forms.Button();
            this.dataGridArac = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Arac_yil = new System.Windows.Forms.TextBox();
            this.Arac_model = new System.Windows.Forms.TextBox();
            this.Arac_renk = new System.Windows.Forms.TextBox();
            this.Arac_plaka = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AboneGuncelle = new System.Windows.Forms.Button();
            this.AboneSil = new System.Windows.Forms.Button();
            this.AboneEkle = new System.Windows.Forms.Button();
            this.dataGridAbone = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Ucret = new System.Windows.Forms.TextBox();
            this.Abonelik_tipi = new System.Windows.Forms.TextBox();
            this.Abonelik_bas_tarihi = new System.Windows.Forms.DateTimePicker();
            this.Abonelik_bit_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.mArac_plaka = new System.Windows.Forms.TextBox();
            this.Musteri_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.hizmet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 314);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.mArac_plaka);
            this.tabPage1.Controls.Add(this.MusteriGuncelle);
            this.tabPage1.Controls.Add(this.MusteriSil);
            this.tabPage1.Controls.Add(this.MusteriEkle);
            this.tabPage1.Controls.Add(this.dataGridMusteri);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Musteri_adres);
            this.tabPage1.Controls.Add(this.Musteri_tel_no);
            this.tabPage1.Controls.Add(this.Musteri_soyad);
            this.tabPage1.Controls.Add(this.Musteri_ad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MusteriGuncelle
            // 
            this.MusteriGuncelle.Location = new System.Drawing.Point(107, 188);
            this.MusteriGuncelle.Name = "MusteriGuncelle";
            this.MusteriGuncelle.Size = new System.Drawing.Size(91, 40);
            this.MusteriGuncelle.TabIndex = 11;
            this.MusteriGuncelle.Text = "Güncelle";
            this.MusteriGuncelle.UseVisualStyleBackColor = true;
            this.MusteriGuncelle.Click += new System.EventHandler(this.MusteriGuncelle_Click);
            // 
            // MusteriSil
            // 
            this.MusteriSil.Location = new System.Drawing.Point(58, 188);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(43, 40);
            this.MusteriSil.TabIndex = 10;
            this.MusteriSil.Text = "Sil";
            this.MusteriSil.UseVisualStyleBackColor = true;
            this.MusteriSil.Click += new System.EventHandler(this.MusteriSil_Click);
            // 
            // MusteriEkle
            // 
            this.MusteriEkle.Location = new System.Drawing.Point(58, 234);
            this.MusteriEkle.Name = "MusteriEkle";
            this.MusteriEkle.Size = new System.Drawing.Size(140, 40);
            this.MusteriEkle.TabIndex = 9;
            this.MusteriEkle.Text = "Ekle";
            this.MusteriEkle.UseVisualStyleBackColor = true;
            this.MusteriEkle.Click += new System.EventHandler(this.MusteriEkle_Click);
            // 
            // dataGridMusteri
            // 
            this.dataGridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteri.Location = new System.Drawing.Point(223, 6);
            this.dataGridMusteri.Name = "dataGridMusteri";
            this.dataGridMusteri.Size = new System.Drawing.Size(360, 276);
            this.dataGridMusteri.TabIndex = 8;
            this.dataGridMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMusteri_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad :";
            // 
            // Musteri_adres
            // 
            this.Musteri_adres.Location = new System.Drawing.Point(58, 99);
            this.Musteri_adres.MaxLength = 100;
            this.Musteri_adres.Multiline = true;
            this.Musteri_adres.Name = "Musteri_adres";
            this.Musteri_adres.Size = new System.Drawing.Size(140, 56);
            this.Musteri_adres.TabIndex = 3;
            // 
            // Musteri_tel_no
            // 
            this.Musteri_tel_no.Location = new System.Drawing.Point(58, 72);
            this.Musteri_tel_no.MaxLength = 11;
            this.Musteri_tel_no.Name = "Musteri_tel_no";
            this.Musteri_tel_no.Size = new System.Drawing.Size(140, 20);
            this.Musteri_tel_no.TabIndex = 2;
            // 
            // Musteri_soyad
            // 
            this.Musteri_soyad.Location = new System.Drawing.Point(58, 45);
            this.Musteri_soyad.MaxLength = 50;
            this.Musteri_soyad.Name = "Musteri_soyad";
            this.Musteri_soyad.Size = new System.Drawing.Size(140, 20);
            this.Musteri_soyad.TabIndex = 1;
            // 
            // Musteri_ad
            // 
            this.Musteri_ad.Location = new System.Drawing.Point(58, 18);
            this.Musteri_ad.MaxLength = 50;
            this.Musteri_ad.Name = "Musteri_ad";
            this.Musteri_ad.Size = new System.Drawing.Size(140, 20);
            this.Musteri_ad.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AracGuncelle);
            this.tabPage2.Controls.Add(this.AracSil);
            this.tabPage2.Controls.Add(this.AracEkle);
            this.tabPage2.Controls.Add(this.dataGridArac);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Arac_yil);
            this.tabPage2.Controls.Add(this.Arac_model);
            this.tabPage2.Controls.Add(this.Arac_renk);
            this.tabPage2.Controls.Add(this.Arac_plaka);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Araçlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AracGuncelle
            // 
            this.AracGuncelle.Location = new System.Drawing.Point(107, 188);
            this.AracGuncelle.Name = "AracGuncelle";
            this.AracGuncelle.Size = new System.Drawing.Size(91, 40);
            this.AracGuncelle.TabIndex = 23;
            this.AracGuncelle.Text = "Güncelle";
            this.AracGuncelle.UseVisualStyleBackColor = true;
            this.AracGuncelle.Click += new System.EventHandler(this.AracGuncelle_Click);
            // 
            // AracSil
            // 
            this.AracSil.Location = new System.Drawing.Point(58, 188);
            this.AracSil.Name = "AracSil";
            this.AracSil.Size = new System.Drawing.Size(43, 40);
            this.AracSil.TabIndex = 22;
            this.AracSil.Text = "Sil";
            this.AracSil.UseVisualStyleBackColor = true;
            this.AracSil.Click += new System.EventHandler(this.AracSil_Click);
            // 
            // AracEkle
            // 
            this.AracEkle.Location = new System.Drawing.Point(58, 234);
            this.AracEkle.Name = "AracEkle";
            this.AracEkle.Size = new System.Drawing.Size(140, 40);
            this.AracEkle.TabIndex = 21;
            this.AracEkle.Text = "Ekle";
            this.AracEkle.UseVisualStyleBackColor = true;
            this.AracEkle.Click += new System.EventHandler(this.AracEkle_Click);
            // 
            // dataGridArac
            // 
            this.dataGridArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArac.Location = new System.Drawing.Point(223, 6);
            this.dataGridArac.Name = "dataGridArac";
            this.dataGridArac.Size = new System.Drawing.Size(360, 276);
            this.dataGridArac.TabIndex = 20;
            this.dataGridArac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArac_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Yıl :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Model :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Renk :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Plaka :";
            // 
            // Arac_yil
            // 
            this.Arac_yil.Location = new System.Drawing.Point(58, 99);
            this.Arac_yil.MaxLength = 4;
            this.Arac_yil.Name = "Arac_yil";
            this.Arac_yil.Size = new System.Drawing.Size(140, 20);
            this.Arac_yil.TabIndex = 15;
            // 
            // Arac_model
            // 
            this.Arac_model.Location = new System.Drawing.Point(58, 72);
            this.Arac_model.MaxLength = 25;
            this.Arac_model.Name = "Arac_model";
            this.Arac_model.Size = new System.Drawing.Size(140, 20);
            this.Arac_model.TabIndex = 14;
            // 
            // Arac_renk
            // 
            this.Arac_renk.Location = new System.Drawing.Point(58, 45);
            this.Arac_renk.MaxLength = 25;
            this.Arac_renk.Name = "Arac_renk";
            this.Arac_renk.Size = new System.Drawing.Size(140, 20);
            this.Arac_renk.TabIndex = 13;
            // 
            // Arac_plaka
            // 
            this.Arac_plaka.Location = new System.Drawing.Point(58, 18);
            this.Arac_plaka.MaxLength = 9;
            this.Arac_plaka.Name = "Arac_plaka";
            this.Arac_plaka.Size = new System.Drawing.Size(140, 20);
            this.Arac_plaka.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Abonelik_bit_tarihi);
            this.tabPage3.Controls.Add(this.Abonelik_bas_tarihi);
            this.tabPage3.Controls.Add(this.AboneGuncelle);
            this.tabPage3.Controls.Add(this.AboneSil);
            this.tabPage3.Controls.Add(this.AboneEkle);
            this.tabPage3.Controls.Add(this.dataGridAbone);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Musteri_id);
            this.tabPage3.Controls.Add(this.Ucret);
            this.tabPage3.Controls.Add(this.Abonelik_tipi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(591, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Abonelik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AboneGuncelle
            // 
            this.AboneGuncelle.Location = new System.Drawing.Point(107, 188);
            this.AboneGuncelle.Name = "AboneGuncelle";
            this.AboneGuncelle.Size = new System.Drawing.Size(91, 40);
            this.AboneGuncelle.TabIndex = 35;
            this.AboneGuncelle.Text = "Güncelle";
            this.AboneGuncelle.UseVisualStyleBackColor = true;
            this.AboneGuncelle.Click += new System.EventHandler(this.AboneGuncelle_Click);
            // 
            // AboneSil
            // 
            this.AboneSil.Location = new System.Drawing.Point(58, 188);
            this.AboneSil.Name = "AboneSil";
            this.AboneSil.Size = new System.Drawing.Size(43, 40);
            this.AboneSil.TabIndex = 34;
            this.AboneSil.Text = "Sil";
            this.AboneSil.UseVisualStyleBackColor = true;
            this.AboneSil.Click += new System.EventHandler(this.AboneSil_Click);
            // 
            // AboneEkle
            // 
            this.AboneEkle.Location = new System.Drawing.Point(58, 234);
            this.AboneEkle.Name = "AboneEkle";
            this.AboneEkle.Size = new System.Drawing.Size(140, 40);
            this.AboneEkle.TabIndex = 33;
            this.AboneEkle.Text = "Ekle";
            this.AboneEkle.UseVisualStyleBackColor = true;
            this.AboneEkle.Click += new System.EventHandler(this.AboneEkle_Click);
            // 
            // dataGridAbone
            // 
            this.dataGridAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAbone.Location = new System.Drawing.Point(223, 6);
            this.dataGridAbone.Name = "dataGridAbone";
            this.dataGridAbone.Size = new System.Drawing.Size(360, 276);
            this.dataGridAbone.TabIndex = 32;
            this.dataGridAbone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAbone_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ücret :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Abonelik Bit. Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Abonelik Baş. Tarihi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Abonelik Tipi :";
            // 
            // Ucret
            // 
            this.Ucret.Location = new System.Drawing.Point(120, 99);
            this.Ucret.MaxLength = 4;
            this.Ucret.Name = "Ucret";
            this.Ucret.Size = new System.Drawing.Size(78, 20);
            this.Ucret.TabIndex = 27;
            // 
            // Abonelik_tipi
            // 
            this.Abonelik_tipi.Location = new System.Drawing.Point(120, 18);
            this.Abonelik_tipi.MaxLength = 9;
            this.Abonelik_tipi.Name = "Abonelik_tipi";
            this.Abonelik_tipi.Size = new System.Drawing.Size(78, 20);
            this.Abonelik_tipi.TabIndex = 24;
            // 
            // Abonelik_bas_tarihi
            // 
            this.Abonelik_bas_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Abonelik_bas_tarihi.Location = new System.Drawing.Point(120, 45);
            this.Abonelik_bas_tarihi.Name = "Abonelik_bas_tarihi";
            this.Abonelik_bas_tarihi.Size = new System.Drawing.Size(78, 20);
            this.Abonelik_bas_tarihi.TabIndex = 36;
            // 
            // Abonelik_bit_tarihi
            // 
            this.Abonelik_bit_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Abonelik_bit_tarihi.Location = new System.Drawing.Point(120, 72);
            this.Abonelik_bit_tarihi.Name = "Abonelik_bit_tarihi";
            this.Abonelik_bit_tarihi.Size = new System.Drawing.Size(78, 20);
            this.Abonelik_bit_tarihi.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Araç Plaka :";
            // 
            // mArac_plaka
            // 
            this.mArac_plaka.Location = new System.Drawing.Point(94, 161);
            this.mArac_plaka.MaxLength = 9;
            this.mArac_plaka.Name = "mArac_plaka";
            this.mArac_plaka.Size = new System.Drawing.Size(104, 20);
            this.mArac_plaka.TabIndex = 12;
            // 
            // Musteri_id
            // 
            this.Musteri_id.Location = new System.Drawing.Point(120, 125);
            this.Musteri_id.MaxLength = 4;
            this.Musteri_id.Name = "Musteri_id";
            this.Musteri_id.Size = new System.Drawing.Size(78, 20);
            this.Musteri_id.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Müşteri ID :";
            // 
            // hizmet
            // 
            this.hizmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizmet.Location = new System.Drawing.Point(12, 332);
            this.hizmet.Name = "hizmet";
            this.hizmet.Size = new System.Drawing.Size(599, 36);
            this.hizmet.TabIndex = 1;
            this.hizmet.Text = "HİZMET";
            this.hizmet.UseVisualStyleBackColor = true;
            this.hizmet.Click += new System.EventHandler(this.hizmet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.hizmet);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArac)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAbone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Musteri_adres;
        private System.Windows.Forms.TextBox Musteri_tel_no;
        private System.Windows.Forms.TextBox Musteri_soyad;
        private System.Windows.Forms.TextBox Musteri_ad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button MusteriGuncelle;
        private System.Windows.Forms.Button MusteriSil;
        private System.Windows.Forms.Button MusteriEkle;
        private System.Windows.Forms.Button AracGuncelle;
        private System.Windows.Forms.Button AracSil;
        private System.Windows.Forms.Button AracEkle;
        private System.Windows.Forms.DataGridView dataGridArac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Arac_yil;
        private System.Windows.Forms.TextBox Arac_model;
        private System.Windows.Forms.TextBox Arac_renk;
        private System.Windows.Forms.TextBox Arac_plaka;
        private System.Windows.Forms.Button AboneGuncelle;
        private System.Windows.Forms.Button AboneSil;
        private System.Windows.Forms.Button AboneEkle;
        private System.Windows.Forms.DataGridView dataGridAbone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Ucret;
        private System.Windows.Forms.TextBox Abonelik_tipi;
        private System.Windows.Forms.DateTimePicker Abonelik_bit_tarihi;
        private System.Windows.Forms.DateTimePicker Abonelik_bas_tarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mArac_plaka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Musteri_id;
        private System.Windows.Forms.Button hizmet;
    }
}

