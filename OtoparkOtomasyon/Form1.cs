using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Musteri Musteri = new Musteri();
        Arac Arac = new Arac();
        Abone Abone = new Abone();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridMusteri.DataSource = Musteri.MusteriGetir();
            dataGridArac.DataSource = Arac.AracGetir();
            dataGridAbone.DataSource = Abone.AboneGetir();

        }
        //---------MÜŞTERİ
        private void dataGridMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri_ad.Text = dataGridMusteri.CurrentRow.Cells[1].Value.ToString();
            Musteri_soyad.Text = dataGridMusteri.CurrentRow.Cells[2].Value.ToString();
            Musteri_tel_no.Text = dataGridMusteri.CurrentRow.Cells[3].Value.ToString();
            Musteri_adres.Text = dataGridMusteri.CurrentRow.Cells[4].Value.ToString();
            mArac_plaka.Text = dataGridMusteri.CurrentRow.Cells[5].Value.ToString();
        }


//Müşteri Ekle ----------------------------------------------------------------------------------------
        private void MusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri.MusteriEkle(Musteri_ad.Text, Musteri_soyad.Text, Musteri_tel_no.Text, Musteri_adres.Text, mArac_plaka.Text);
            dataGridMusteri.DataSource = Musteri.MusteriGetir();
        }


//Müşteri Sil -----------------------------------------------------------------------------------------
        private void MusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Secim == DialogResult.Yes)
                {
                    string Musteri_id = dataGridMusteri.CurrentRow.Cells[0].Value.ToString();
                    Musteri.MusteriSil(Musteri_id);
                    dataGridMusteri.DataSource = Musteri.MusteriGetir();
                }
            }
            catch
            {
                MessageBox.Show("Satır seçiniz!");
            }

        }

//Müşteri Güncelle ------------------------------------------------------------------------------------
        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            if(Musteri_adres.Text=="")
            {
                MessageBox.Show("Lütfen satır seçiniz!");
            }
            else
            {
                string Musteri_id = dataGridMusteri.CurrentRow.Cells[0].Value.ToString();
                Musteri.MusteriGuncelle(Musteri_id, Musteri_ad.Text, Musteri_soyad.Text, Musteri_tel_no.Text, Musteri_adres.Text, mArac_plaka.Text);
                dataGridMusteri.DataSource = Musteri.MusteriGetir();
            }

        }


        //---------ARAÇ
        private void dataGridArac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Arac_plaka.Text = dataGridArac.CurrentRow.Cells[1].Value.ToString();
            Arac_renk.Text = dataGridArac.CurrentRow.Cells[2].Value.ToString();
            Arac_model.Text = dataGridArac.CurrentRow.Cells[3].Value.ToString();
            Arac_yil.Text = dataGridArac.CurrentRow.Cells[4].Value.ToString();
        }
        

//Araç Ekle ----------------------------------------------------------------------------------------
        private void AracEkle_Click(object sender, EventArgs e)
        {
            Arac.AracEkle(Arac_plaka.Text, Arac_renk.Text, Arac_model.Text, Arac_yil.Text);
            dataGridArac.DataSource = Arac.AracGetir();
        }

//Araç Sil -----------------------------------------------------------------------------------------
        private void AracSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    string Arac_id = dataGridArac.CurrentRow.Cells[0].Value.ToString();
                    Arac.AracSil(Arac_id);
                    dataGridArac.DataSource = Arac.AracGetir();
                }
            }
            catch
            {
                MessageBox.Show("Satır seçiniz!");
            }
        }

//Araç Güncelle ------------------------------------------------------------------------------------
        private void AracGuncelle_Click(object sender, EventArgs e)
        {
            if (Arac_plaka.Text == "")
            {
                MessageBox.Show("Lütfen satır seçiniz");

            }
            else
            {
                string Arac_id = dataGridArac.CurrentRow.Cells[0].Value.ToString();
                Arac.AracGuncelle(Arac_id, Arac_plaka.Text, Arac_renk.Text, Arac_model.Text, Arac_yil.Text);
                dataGridArac.DataSource = Arac.AracGetir();
            }
        }
        //---------ABONE
        private void dataGridAbone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Abonelik_tipi.Text = dataGridAbone.CurrentRow.Cells[1].Value.ToString();
            Abonelik_bas_tarihi.Text = dataGridAbone.CurrentRow.Cells[2].Value.ToString();
            Abonelik_bit_tarihi.Text = dataGridAbone.CurrentRow.Cells[3].Value.ToString();
            Ucret.Text = dataGridAbone.CurrentRow.Cells[4].Value.ToString();
            Musteri_id.Text = dataGridAbone.CurrentRow.Cells[5].Value.ToString();
        }

//Abone Ekle ----------------------------------------------------------------------------------------
        private void AboneEkle_Click(object sender, EventArgs e)
        {
            Abone.AboneEkle(Abonelik_tipi.Text, Abonelik_bas_tarihi.Text, Abonelik_bit_tarihi.Text, Ucret.Text, Musteri_id.Text);
            dataGridAbone.DataSource = Abone.AboneGetir();
        }

//Abone Sil ----------------------------------------------------------------------------------------
        private void AboneSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    string Abonelik_id = dataGridAbone.CurrentRow.Cells[0].Value.ToString();
                    Abone.AboneSil(Abonelik_id);
                    dataGridAbone.DataSource = Abone.AboneGetir();
                }
            }
            catch
            {
                MessageBox.Show("Satır seçiniz!");
            }
        }

//Abone Güncelle ------------------------------------------------------------------------------------
        private void AboneGuncelle_Click(object sender, EventArgs e)
        {
            if (Ucret.Text == "")
            {
                MessageBox.Show("Lütfen satır seçiniz");

            }
            else
            {
                string Abonelik_id = dataGridAbone.CurrentRow.Cells[0].Value.ToString();
                Abone.AboneGuncelle(Abonelik_id, Abonelik_tipi.Text, Abonelik_bas_tarihi.Text, Abonelik_bit_tarihi.Text, Ucret.Text, Musteri_id.Text);
                dataGridAbone.DataSource = Abone.AboneGetir();
            }
        }

        private void hizmet_Click(object sender, EventArgs e)
        {
            Hizmet HizmetForm = new Hizmet();
            HizmetForm.ShowDialog();
        }
    }
}
