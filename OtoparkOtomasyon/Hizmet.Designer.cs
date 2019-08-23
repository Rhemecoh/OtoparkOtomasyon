namespace OtoparkOtomasyon
{
    partial class Hizmet
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
            this.components = new System.ComponentModel.Container();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Giris = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.plakaara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.girissaat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridAboneOlmayan = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridMusteri = new System.Windows.Forms.DataGridView();
            this.dataGridHizmet = new System.Windows.Forms.DataGridView();
            this.saat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Arac_plaka = new System.Windows.Forms.TextBox();
            this.Musteri_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Abonelik_tipi = new System.Windows.Forms.TextBox();
            this.Musteri_soyad = new System.Windows.Forms.TextBox();
            this.Musteri_ad = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAboneOlmayan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHizmet)).BeginInit();
            this.SuspendLayout();
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(314, 351);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(91, 40);
            this.Guncelle.TabIndex = 38;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(411, 351);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(43, 40);
            this.Sil.TabIndex = 37;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(163, 351);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(66, 40);
            this.Giris.TabIndex = 36;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(236, 351);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(68, 40);
            this.Cikis.TabIndex = 36;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // plakaara
            // 
            this.plakaara.Location = new System.Drawing.Point(286, 54);
            this.plakaara.Name = "plakaara";
            this.plakaara.Size = new System.Drawing.Size(100, 20);
            this.plakaara.TabIndex = 47;
            this.plakaara.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Plaka Ara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.girissaat);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridAboneOlmayan);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridMusteri);
            this.groupBox1.Controls.Add(this.dataGridHizmet);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Arac_plaka);
            this.groupBox1.Controls.Add(this.Musteri_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.plakaara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Abonelik_tipi);
            this.groupBox1.Controls.Add(this.Musteri_soyad);
            this.groupBox1.Controls.Add(this.Musteri_ad);
            this.groupBox1.Controls.Add(this.Guncelle);
            this.groupBox1.Controls.Add(this.Sil);
            this.groupBox1.Controls.Add(this.Cikis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Giris);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 552);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hizmet";
            // 
            // girissaat
            // 
            this.girissaat.Location = new System.Drawing.Point(500, 299);
            this.girissaat.Name = "girissaat";
            this.girissaat.Size = new System.Drawing.Size(100, 20);
            this.girissaat.TabIndex = 51;
            this.girissaat.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 52;
            this.textBox1.Visible = false;
            // 
            // dataGridAboneOlmayan
            // 
            this.dataGridAboneOlmayan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAboneOlmayan.Location = new System.Drawing.Point(6, 78);
            this.dataGridAboneOlmayan.Name = "dataGridAboneOlmayan";
            this.dataGridAboneOlmayan.Size = new System.Drawing.Size(617, 159);
            this.dataGridAboneOlmayan.TabIndex = 61;
            this.dataGridAboneOlmayan.Visible = false;
            this.dataGridAboneOlmayan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAboneOlmayan_CellContentClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(500, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 60;
            this.radioButton2.Text = "Araç";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(438, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 60;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Abone";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(229, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Araç girişi için plaka giriniz!";
            this.label8.Visible = false;
            // 
            // dataGridMusteri
            // 
            this.dataGridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteri.Location = new System.Drawing.Point(6, 78);
            this.dataGridMusteri.Name = "dataGridMusteri";
            this.dataGridMusteri.Size = new System.Drawing.Size(617, 159);
            this.dataGridMusteri.TabIndex = 57;
            this.dataGridMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMusteri_CellContentClick);
            // 
            // dataGridHizmet
            // 
            this.dataGridHizmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHizmet.Location = new System.Drawing.Point(6, 397);
            this.dataGridHizmet.Name = "dataGridHizmet";
            this.dataGridHizmet.Size = new System.Drawing.Size(617, 142);
            this.dataGridHizmet.TabIndex = 51;
            this.dataGridHizmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHizmet_CellContentClick);
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.Location = new System.Drawing.Point(25, 28);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(87, 39);
            this.saat.TabIndex = 50;
            this.saat.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Araç Plaka :";
            this.label6.Visible = false;
            // 
            // Arac_plaka
            // 
            this.Arac_plaka.Location = new System.Drawing.Point(286, 54);
            this.Arac_plaka.Name = "Arac_plaka";
            this.Arac_plaka.Size = new System.Drawing.Size(100, 20);
            this.Arac_plaka.TabIndex = 56;
            this.Arac_plaka.Visible = false;
            // 
            // Musteri_id
            // 
            this.Musteri_id.Enabled = false;
            this.Musteri_id.Location = new System.Drawing.Point(286, 243);
            this.Musteri_id.Name = "Musteri_id";
            this.Musteri_id.Size = new System.Drawing.Size(34, 20);
            this.Musteri_id.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Abonelik Tipi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ad :";
            // 
            // Abonelik_tipi
            // 
            this.Abonelik_tipi.Enabled = false;
            this.Abonelik_tipi.Location = new System.Drawing.Point(286, 322);
            this.Abonelik_tipi.MaxLength = 50;
            this.Abonelik_tipi.Name = "Abonelik_tipi";
            this.Abonelik_tipi.Size = new System.Drawing.Size(140, 20);
            this.Abonelik_tipi.TabIndex = 50;
            // 
            // Musteri_soyad
            // 
            this.Musteri_soyad.Enabled = false;
            this.Musteri_soyad.Location = new System.Drawing.Point(286, 296);
            this.Musteri_soyad.MaxLength = 50;
            this.Musteri_soyad.Name = "Musteri_soyad";
            this.Musteri_soyad.Size = new System.Drawing.Size(140, 20);
            this.Musteri_soyad.TabIndex = 50;
            // 
            // Musteri_ad
            // 
            this.Musteri_ad.Enabled = false;
            this.Musteri_ad.Location = new System.Drawing.Point(286, 269);
            this.Musteri_ad.MaxLength = 50;
            this.Musteri_ad.Name = "Musteri_ad";
            this.Musteri_ad.Size = new System.Drawing.Size(140, 20);
            this.Musteri_ad.TabIndex = 49;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 574);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hizmet";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Hizmet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAboneOlmayan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHizmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.TextBox plakaara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Musteri_soyad;
        private System.Windows.Forms.TextBox Musteri_ad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.TextBox Musteri_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Abonelik_tipi;
        private System.Windows.Forms.TextBox Arac_plaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridHizmet;
        private System.Windows.Forms.DataGridView dataGridMusteri;
        private System.Windows.Forms.TextBox girissaat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridAboneOlmayan;
        private System.Windows.Forms.Button button1;
    }
}