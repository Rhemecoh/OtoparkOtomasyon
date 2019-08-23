using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //
using System.Data; // 
namespace OtoparkOtomasyon
{
    public partial class HizmetGuncelle : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=UMUT-LAPTOP\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut;
        protected void baglanticontrol()
        {
            try { baglanti.Close(); }
            catch { }
        }
        public HizmetGuncelle()
        {
            InitializeComponent();
        }
        Hizmet Hizmet = new Hizmet();
        private void HizmetGuncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HizmetGetir();
        }

        public DataTable HizmetGetir()
        {
            baglanticontrol();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblHizmet", baglanti);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            baglanti.Close();
            return tbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri_id.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Arac_plaka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Arac_giris_saati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Arac_cikis_saati.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        public void HizmetGun(string Hizmet_id,string Musteri_id, string Arac_plaka, string Arac_giris_saati, string Arac_cikis_saati)
        {
            komut = new SqlCommand("update tblHizmet set Musteri_id='" + Musteri_id + "', Arac_plaka='" + Arac_plaka + "', Arac_giris_saati='" + Arac_giris_saati + "', Arac_cikis_saati='" + Arac_cikis_saati + "'where Hizmet_id=" + Hizmet_id, baglanti);
            try
            {
                baglanticontrol();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri güncelleme işlemi başarılı.");
            }
            catch
            {
                MessageBox.Show("Müşteri güncelleme işlemi yapılamadı!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Musteri_id.Text == "")
            {
                MessageBox.Show("Lütfen satır seçiniz");

            }
            else
            {
                string Hizmet_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                HizmetGun(Hizmet_id,Musteri_id.Text, Arac_plaka.Text, Arac_giris_saati.Text, Arac_cikis_saati.Text);
                dataGridView1.DataSource = HizmetGetir();
            }

        }
    }
}
