using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //
using System.Data; // 
using System.Windows.Forms; //

namespace OtoparkOtomasyon
{
    public partial class Hizmet : Form
    {

        private SqlConnection baglanti = new SqlConnection("Data Source=UMUT-LAPTOP\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut;
        protected void baglanticontrol()
        {
            try { baglanti.Close(); }
            catch { }
        }

        public Hizmet()
        {
            InitializeComponent();
        }
        private void Hizmet_Load(object sender, EventArgs e)
        {
            dataGridMusteri.DataSource = MusteriGetir();
            dataGridHizmet.DataSource = HizmetGetir();
            dataGridAboneOlmayan.DataSource = AboneOlmayanGetir();
            timer1.Start();
        }

        private void dataGridMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri_id.Text = dataGridMusteri.CurrentRow.Cells[0].Value.ToString();
            Musteri_ad.Text = dataGridMusteri.CurrentRow.Cells[2].Value.ToString();
            Musteri_soyad.Text = dataGridMusteri.CurrentRow.Cells[3].Value.ToString();
            Abonelik_tipi.Text = dataGridMusteri.CurrentRow.Cells[4].Value.ToString();
            Arac_plaka.Text = dataGridMusteri.CurrentRow.Cells[1].Value.ToString();
        }

        public DataTable HizmetGetir()
        {
            baglanticontrol();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblHizmet WHERE Musteri_id NOT LIKE'0'", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            baglanti.Close();
            return tbl;
        }

        public DataTable AboneOlmayanGetir()
        {
            baglanticontrol();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblHizmet WHERE Musteri_id LIKE'0'", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            baglanti.Close();
            return tbl;
        }

        public DataTable MusteriGetir()
        {
            baglanticontrol();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tblMusteri.Musteri_id, tblMusteri.Arac_plaka, tblMusteri.Musteri_ad, tblMusteri.Musteri_soyad, tblAbone.Abonelik_tipi from tblMusteri inner join tblAbone on tblMusteri.Musteri_id=tblAbone.Musteri_id", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            baglanti.Close();
            return tbl;
        }



//EKLE ----------------------------------------------------------------------------
        public void HizmetEkle(string Musteri_id, string Arac_plaka, string Arac_giris_saati, string Abonelik_tipi)
        {
            komut = new SqlCommand("insert into tblHizmet (Musteri_id,Arac_plaka,Arac_giris_saati,Abonelik_tipi) Values ('" + Musteri_id + "','" + Arac_plaka + "','" + Arac_giris_saati + "','" + Abonelik_tipi + "')", baglanti);
            try
            {
                baglanticontrol();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Hizmet ekleme işlemi başarılı.");
            }
            catch
            {
                MessageBox.Show("Hizmet ekleme işlemi yapılamadı!");
            }
        }
//Ekle Çıkış ----------------------------------------------------------------------------
        public void HizmetEkleCikis(string Hizmet_id,string Arac_cikis_saati, string Ucret)
        {
            komut = new SqlCommand("update tblHizmet set Arac_cikis_saati='" + Arac_cikis_saati + "',Ucret='" + Ucret + "' where Hizmet_id=" + Hizmet_id, baglanti);
            try
            {
                baglanticontrol();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Çıkış işlemi başarılı.");
            }
            catch
            {
                MessageBox.Show("Çıkış işlemi yapılamadı!");
            }
}

//SİL --------------------------------------------------------------------------------
        public void HizmetSil(string Hizmet_id)
        {
            komut = new SqlCommand("delete tblHizmet where Hizmet_id=" + Hizmet_id, baglanti);
            try
            {
                baglanticontrol();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Hizmet silme işlemi başarılı.");
            }
            catch
            {
                MessageBox.Show("Hizmet silme işlemi yapılamadı!");
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            HizmetGuncelle HizmetGuncelle = new HizmetGuncelle();
            HizmetGuncelle.ShowDialog();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            baglanticontrol();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tblMusteri.Musteri_id, tblMusteri.Arac_plaka, tblMusteri.Musteri_ad, tblMusteri.Musteri_soyad, tblAbone.Abonelik_tipi from tblMusteri inner join tblAbone on tblMusteri.Musteri_id=tblAbone.Musteri_id WHERE Arac_plaka LIKE'%" + plakaara.Text + "%'", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            baglanti.Close();
            dataGridMusteri.DataSource = tbl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToShortTimeString();
            
        }
//Giriş Button--------------------------------------------------------------
        private void Giris_Click(object sender, EventArgs e)
        {

            HizmetEkle(Musteri_id.Text, Arac_plaka.Text, saat.Text, Abonelik_tipi.Text);
            dataGridHizmet.DataSource = HizmetGetir();
            dataGridAboneOlmayan.DataSource = AboneOlmayanGetir();
        }
//Çıkış Button--------------------------------------------------------------
        private void Cikis_Click(object sender, EventArgs e)
        {

            if(textBox1.Text=="")
            {
                if (girissaat.Text == "")
                {
                    MessageBox.Show("Lütfen hizmet seçiniz.");
                }
                else
                {
                    DateTime deger;
                    DateTime zaman = DateTime.Now;

                    deger = DateTime.Parse((dataGridAboneOlmayan.CurrentRow.Cells["Arac_giris_saati"].Value).ToString());
                    int tutar = deger.Hour - zaman.Hour;
                    tutar = Math.Abs(tutar);
                    int fiyat = tutar * 5;
                    if (tutar == 0)
                    {
                        int sonuc = fiyat + 5;
                        string Hizmet_id = dataGridAboneOlmayan.CurrentRow.Cells[0].Value.ToString();

                        HizmetEkleCikis(Hizmet_id, saat.Text, sonuc.ToString());
                        dataGridAboneOlmayan.DataSource = AboneOlmayanGetir();
                        MessageBox.Show("Ücret :" + sonuc.ToString() + " TL ");
                    }
                    else
                    {
                        string Hizmet_id = dataGridAboneOlmayan.CurrentRow.Cells[0].Value.ToString();
               
                        HizmetEkleCikis(Hizmet_id, saat.Text, fiyat.ToString());
                        dataGridAboneOlmayan.DataSource = AboneOlmayanGetir();
                        MessageBox.Show("Ücret :" + fiyat.ToString() + " TL ");
                    }
                }
             }
            else
            {
                string Hizmet_id = dataGridHizmet.CurrentRow.Cells[0].Value.ToString();
                HizmetEkleCikis(Hizmet_id, saat.Text, "");
                dataGridHizmet.DataSource = HizmetGetir();
                MessageBox.Show("Abone olduğu için ücret tahsil edilmedi. ");
            }


        }

        private void dataGridHizmet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            girissaat.Text = dataGridHizmet.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridHizmet.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridAboneOlmayan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            girissaat.Text = dataGridAboneOlmayan.CurrentRow.Cells[3].Value.ToString();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Secim = new DialogResult();
                Secim = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    string Hizmet_id = dataGridHizmet.CurrentRow.Cells[0].Value.ToString();
                    HizmetSil(Hizmet_id);
                    dataGridHizmet.DataSource = HizmetGetir();
                }
            }
            catch
            {
                MessageBox.Show("Satır seçiniz!");
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            plakaara.Visible = true;
            label1.Visible = true;
            dataGridMusteri.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label8.Visible = false;
            Musteri_id.Visible = true;
            Musteri_ad.Visible = true;
            Musteri_soyad.Visible = true;
            Abonelik_tipi.Visible = true;
            label6.Visible = false;
            Arac_plaka.Visible = false;
            dataGridHizmet.Visible = true;
            dataGridAboneOlmayan.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            plakaara.Visible = false;
            label1.Visible = false;
            dataGridMusteri.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = true;
            Musteri_id.Visible = false;
            Musteri_ad.Visible = false;
            Musteri_soyad.Visible = false;
            Abonelik_tipi.Visible = false;
            label6.Visible = true;
            Arac_plaka.Visible = true;
            dataGridHizmet.Visible = true;
            Musteri_id.Text = "";
            Musteri_ad.Text = "";
            Musteri_soyad.Text = "";
            Abonelik_tipi.Text = "";
            dataGridHizmet.Visible = false;
            dataGridAboneOlmayan.Visible = true;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridMusteri.DataSource = MusteriGetir();
            dataGridHizmet.DataSource = HizmetGetir();
            dataGridAboneOlmayan.DataSource = AboneOlmayanGetir();
        }
    }
}
