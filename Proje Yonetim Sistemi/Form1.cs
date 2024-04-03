using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proje_Yonetim_Sistemi
{
    public partial class FormLogin : Form
    {
        private List<Kullanici> kullanicilar;
        // FormMain'i aç
        FormMain formMain = new FormMain();
        public FormLogin()
        {
            InitializeComponent();

            // Örnek kullanıcı ekleyelim
            kullanicilar = new List<Kullanici>();
            kullanicilar=formMain.kullanicilar;
            kullanicilar.Add(new Kullanici("kullanıcı", "a12345"));
           

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUserName.Text;
            string sifre = txtPsswd.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici girisYapanKullanici = kullanicilar.Find(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

            if (girisYapanKullanici != null)
            {
                MessageBox.Show("Giriş başarılı!");

                // FormLogin'i kapat
                this.Hide();
                txtPsswd.Clear();
                txtUserName.Clear();
                //// FormMain'i aç
                //FormMain formMain = new FormMain();
                formMain.ShowDialog();

                // FormMain kapatıldıktan sonra tekrar FormLogin'i göster
                this.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Leave_1(object sender, EventArgs e)
        {
            KontrolBosAlan(txtUserName, "Kullanıcı Adı");
        }


       private void txtPsswd_Leave_1(object sender, EventArgs e)
        {
            KontrolBosAlan(txtPsswd, "Şifre");
        }

        private void KontrolBosAlan(TextBox textBox, string alanAdi)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"{alanAdi} alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
            }
        }

        private void linkYeniKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ege.edu.tr/tr-0/anasayfa.html");
        }
    }
    
}
