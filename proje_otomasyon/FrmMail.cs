using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace proje_otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMail.Text = mail;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();//mail mesaj sınıfından bir nesne türettik
            SmtpClient istemci = new SmtpClient();//bir tane istemci nesnesi türetiliyor,kapıyı tıklatma işlemi yapıyoruz.
            istemci.Credentials = new System.Net.NetworkCredential("Mail","Şİfre");//istemcinin kimliği=networkcredential ağ kimliği demek ilk çift tırnağa mailadresi ikinciye şifre yazılacak
            istemci.Port = 587;//port numarası -->türkiyede kullanılan mail adresi port no 587 old. böyşe yazıldı.mail adresinin port numarası
            istemci.Host = "smtp.live.com";//istemcinin sunucusu
            istemci.EnableSsl = true;//yol boyunca şifreleme işlemi yapacak.
            mesajim.To.Add(RchMesaj.Text);//mesajımın içine ekle.
            mesajim.From = new MailAddress("Mail");
            mesajim.Subject = TxtKonu.Text;
            mesajim.Body = RchMesaj.Text;
            istemci.Send (mesajim);

        
        }
    }
}
