using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACEDELAYER;
using BUSINESSLOGICLAYER;

namespace UDEMY_UYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OgrenciListesi()
        {
            List<ENTITYOGRENCI> OgrList = BLLOGRENCI.LISTELE();
            dataGridView1.DataSource = OgrList;
            this.Text = "ogrenciListesi";
        }

        public void KulupListesi()
        {
            List<ENTITYKULUP> KlpLst = BLLKULUP.LISTELE();
            CmbKulup.DisplayMember = "KULUPAD";
            CmbKulup.ValueMember = "KULUPID";
            CmbKulup.DataSource = KlpLst;
            dataGridView1.DataSource = KlpLst;
            this.Text = "kulupListesi";
        }

        public void NotListesi()
        {
            List<ENTITYNOTLAR> NotList = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = NotList;
            this.Text = "notListesi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void BtOgrKaydet_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.FOTOGRAF = TxtFotograf.Text;
            ent.KULUPID = Convert.ToInt16(CmbKulup.SelectedValue);

            BLLOGRENCI.EKLE(ent);
            MessageBox.Show("Kayit eklendi");
            OgrenciListesi();
        }

        private void BtOgrSil_Click(object sender, EventArgs e)
        {
            
        }

        private void BtOgrList_Click(object sender, EventArgs e)
        {
            OgrenciListesi();
        }

        private void BtOgrGun_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.FOTOGRAF = TxtFotograf.Text;
            ent.KULUPID = Convert.ToInt16(CmbKulup.SelectedValue);
            ent.ID = Convert.ToInt16(TxtOgrId.Text);
            BLLOGRENCI.GUNCELLE(ent);
            MessageBox.Show("Ogrenci Bilgileri güncellendi");

            OgrenciListesi();
            
        }

        private void BtNotList_Click(object sender, EventArgs e)
        {
            NotListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.Text == "ogrenciListesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtFotograf.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            }

            if(this.Text== "notListesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtNotId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtS1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtS2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtS3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                TxtProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                TxtOrt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                    
            }
        }

        private void BtNotGun_Click(object sender, EventArgs e)
        {
            ENTITYNOTLAR ent = new ENTITYNOTLAR();
            ent.OGRENCIID = Convert.ToInt16(TxtNotId.Text);
            ent.SINAV1 = Convert.ToInt16(TxtS1.Text);
            ent.SINAV2 = Convert.ToInt16(TxtS2.Text);
            ent.SINAV3 = Convert.ToInt16(TxtS3.Text);
            ent.PROJE = Convert.ToInt16(TxtProje.Text);
            ent.ORTALAMA = Convert.ToDouble(TxtProje.Text);
            ent.DURUM = TxtProje.Text;
            BLLNOTLAR.GUNCELLE(ent);
            MessageBox.Show("Notlar Guncellendi");
            NotListesi();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3,proje;
            double ortalama;
            string durum;

            s1 = Convert.ToInt16(TxtS1.Text);
            s2 = Convert.ToInt16(TxtS2.Text);
            s3 = Convert.ToInt16(TxtS3.Text);
            proje = Convert.ToInt16(TxtProje.Text);

            ortalama = (s1 + s2 + s3 + proje)/4;
            TxtOrt.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                durum = "True";
            }

            else
            {
                durum = "False";
            }

            TxtDurum.Text = durum;
        }

        private void BtKulupGun_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPID = Convert.ToInt16(TxtKulupId.Text);
            ent.KULUPAD = TxtKulupAd.Text;
            BLLKULUP.GUNCELLE(ent);
            MessageBox.Show("Kulup Güncellendi");
            KulupListesi();
        }

        private void BtnKlpList_Click(object sender, EventArgs e)
        {
            KulupListesi();
        }

        private void BtKulKaydet_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = TxtKulupAd.Text;
            BLLKULUP.EKLE(ent);
            MessageBox.Show("Kulup eklendi");
            KulupListesi();
        }

        private void BtKulupSil_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPID = Convert.ToInt16(TxtKulupId.Text);
            BLLKULUP.SIL(ent.KULUPID);
            MessageBox.Show("Kulup Silme Başarılı");
            KulupListesi();
        }
    }
}
