namespace OtoparkOtomasyon
{
    partial class HizmetGuncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Musteri_id = new System.Windows.Forms.TextBox();
            this.Arac_plaka = new System.Windows.Forms.TextBox();
            this.Arac_giris_saati = new System.Windows.Forms.TextBox();
            this.Arac_cikis_saati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Musteri_id
            // 
            this.Musteri_id.Location = new System.Drawing.Point(259, 37);
            this.Musteri_id.Name = "Musteri_id";
            this.Musteri_id.Size = new System.Drawing.Size(100, 20);
            this.Musteri_id.TabIndex = 1;
            // 
            // Arac_plaka
            // 
            this.Arac_plaka.Location = new System.Drawing.Point(259, 64);
            this.Arac_plaka.Name = "Arac_plaka";
            this.Arac_plaka.Size = new System.Drawing.Size(100, 20);
            this.Arac_plaka.TabIndex = 2;
            // 
            // Arac_giris_saati
            // 
            this.Arac_giris_saati.Location = new System.Drawing.Point(259, 90);
            this.Arac_giris_saati.Name = "Arac_giris_saati";
            this.Arac_giris_saati.Size = new System.Drawing.Size(100, 20);
            this.Arac_giris_saati.TabIndex = 3;
            // 
            // Arac_cikis_saati
            // 
            this.Arac_cikis_saati.Location = new System.Drawing.Point(259, 116);
            this.Arac_cikis_saati.Name = "Arac_cikis_saati";
            this.Arac_cikis_saati.Size = new System.Drawing.Size(100, 20);
            this.Arac_cikis_saati.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Plaka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Araç Giriş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Araç Çıkış Saati :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HizmetGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Arac_cikis_saati);
            this.Controls.Add(this.Arac_giris_saati);
            this.Controls.Add(this.Arac_plaka);
            this.Controls.Add(this.Musteri_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HizmetGuncelle";
            this.Text = "HizmetGuncelle";
            this.Load += new System.EventHandler(this.HizmetGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Musteri_id;
        private System.Windows.Forms.TextBox Arac_plaka;
        private System.Windows.Forms.TextBox Arac_giris_saati;
        private System.Windows.Forms.TextBox Arac_cikis_saati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}