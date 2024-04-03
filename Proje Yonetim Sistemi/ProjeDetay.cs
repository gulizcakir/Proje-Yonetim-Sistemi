using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Yonetim_Sistemi
{
    public partial class ProjeDetay : Form
    {
        public Proje detayProje;
        public event Action<Proje> ProjeGuncelle;
        bool formYuklendi;

        public ProjeDetay(Proje proje)
        {
            InitializeComponent();
            detayProje = proje;
        }

        private void ProjeDetay_Load(object sender, EventArgs e)
        {
            // Proje bilgilerini form kontrollerine yerleştir
            txtDetayPNo.Text = detayProje.ProjeNo;
            txtDeatyProjeAdi.Text = detayProje.ProjeAdi;
            txtDetayProjeYurutucu.Text = detayProje.ProjeYurutucusu.calsanAdi; // Varsayılan olarak sadece ismi alındı, isteğinize göre düzenleyebilirsiniz.
            txtDetayProjeDurumu.Text = detayProje.Durum.ToString();
            txtDetayProjeBaslangicTarihi.Text = detayProje.ProjeBaslangici.ToString();
            txtDetayTahiniBT.Text = detayProje.TahminiBitis.ToString();
            cmbParasalGetiriTipi.Text = detayProje.ParasalGetiriTipi.ToString();
            nmrcUpDownParasalGetiriG.Value = detayProje.ParasalGetiri;     
            checkBoxRed.Checked = detayProje.Durum == Durum.Red;
            checkBoxDevam.Checked = detayProje.Durum == Durum.DevamEdiyor;
            checkBoxBitir.Checked = detayProje.Durum == Durum.Tamamlandi;
            formYuklendi = true;
        }

        private void btnPrjDetay_Click(object sender, EventArgs e)
        {
            // CheckBox durumuna göre proje durumunu güncelle
            if (checkBoxRed.Checked)
            {
                detayProje.Durum = Durum.Red;
            }
            else if (checkBoxDevam.Checked)
            {
                detayProje.Durum = Durum.DevamEdiyor;
            }
            else if (checkBoxBitir.Checked)
            {
                detayProje.Durum = Durum.Tamamlandi;
                detayProje.ProjeBitisi = DateTime.Now;
                txtDeayBitisTarihi.Text = DateTime.Now.ToString();
            }
            detayProje.ProjeAdi = txtDeatyProjeAdi.Text;
            detayProje.TahminiBitis = DateTime.Parse (txtDetayTahiniBT.Text);
            detayProje.ParasalGetiriTipi = cmbParasalGetiriTipi.Text;
            detayProje.ParasalGetiri = nmrcUpDownParasalGetiriG.Value;


            ProjeGuncelle?.Invoke(detayProje);

            MessageBox.Show("Proje durumu güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Formu kapat
            this.Close();
        }

        private void checkBoxBitir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBitir.Checked)
            {
                checkBoxRed.Checked = false;
                checkBoxDevam.Checked = false;
            }

            if (checkBoxBitir.Checked)
            {
                txtDeayBitisTarihi.Text = DateTime.Now.ToString(); 
            }
            else
            {
                txtDeayBitisTarihi.Text = string.Empty; 
            }
        }

        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRed.Checked)
            {
                checkBoxDevam.Checked = false;
                checkBoxBitir.Checked = false;
            }
        }

        private void checkBoxDevam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDevam.Checked)
            {
                checkBoxRed.Checked = false;
                checkBoxBitir.Checked = false;
            }
        }

        private void cmbParasalGetiriTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formYuklendi == true)

            {
                DialogResult result = MessageBox.Show("Parasal getiri tipini değiştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string EskiGetiriTipi = cmbParasalGetiriTipi.SelectedItem.ToString();
                if (result == DialogResult.Yes)
                {
                    // Kullanıcının evet'i seçtiği durum

                    string selectedValue = cmbParasalGetiriTipi.SelectedItem.ToString();

                }
                else
                {
                    // Kullanıcının hayır'ı seçtiği durum
                    //değişiklik yapmayacak
                    cmbParasalGetiriTipi.SelectedItem = EskiGetiriTipi;
                }

            }

        }
    }
}
