using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje_otomasyon
{
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtBaslik.Text = "";
            TxtId.Text = "";
            TxtKime.Text = "";
            TxtOlusturan.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
            RchDetay.Text = "";
            MskTarih.Focus();


        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,KIME) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtKime.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            MessageBox.Show("Not Bilgisi Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //focus row handle fareyle imlecin seçtiği satır.
            if (dr != null)// DR BOŞ Bİ SATIR DEĞİLSE
            {
                TxtId.Text = dr["ID"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                TxtKime.Text = dr["KIME"].ToString();
              
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Not Bilgisini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                temizle();
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır seçeneğine tıklandığında çalıştırılacak kodlar



            }
            else if (secenek == DialogResult.Cancel)
            {
                //code for Cancel
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Not bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_NOTLAR set TARIH=@p1,SAAT=@p2,BASLIK=@p3,DETAY=@p4, OLUSTURAN=@p5,KIME=@p6 where ID=@p7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTarih.Text);
                komut.Parameters.AddWithValue("@p2", MskSaat.Text);
                komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
                komut.Parameters.AddWithValue("@p4", RchDetay.Text);
                komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
                komut.Parameters.AddWithValue("@p6", TxtKime.Text);
                komut.Parameters.AddWithValue("@p7", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();

            }
            else if (secenek == DialogResult.No)
            {
                //Hayır seçeneğine tıklandığında çalıştırılacak kodlar



            }
            else if (secenek == DialogResult.Cancel)
            {
                //code for Cancel
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
               fr.metin=dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
