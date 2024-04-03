using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Yonetim_Sistemi
{
    public partial class FormMain :Form
    {
        public List<Calisan> calisanlar = new List<Calisan>();
        public List<Kullanici> kullanicilar = new List<Kullanici>();
        public List<Proje> projeler = new List<Proje>();
        public List<string> projeDokumanlari = new List<string>();
        public BindingSource bindingSourceProjeler = new BindingSource();
        
        public FontDialog fontDialog;
        public ColorDialog colorDialog;
        DateTime iseBaslamaTarihi;


        public FormMain()
        {
            
            InitializeComponent();
            
            SaatGuncelleTimerBaslat();
            // Başlangıçta sadece bir panel gösterilecek, diğeri gizli olacak
            kullanicilar = new List<Kullanici>();
            calisanlar.Add(new Calisan
            {
                calisanTc = "12345678901",
                calsanAdi = "Ahmet Metin",
                calsanCinsiyet = "Erkek",
                calsanEgitimDurumu = "Lisans",
                telefonNumarasi = "555-1234",
                Resim = null  
            });

            calisanlar.Add(new Calisan
            {
                calisanTc = "23456789012",
                calsanAdi = "Ayşe Mertcan",
                calsanCinsiyet = "Kadın",
                calsanEgitimDurumu = "Yüksek Lisans",
                telefonNumarasi = "555-5678",
                Resim = null
            });

            calisanlar.Add(new Calisan
            {
                calisanTc = "34567890123",
                calsanAdi = "Mehmet Sabit",
                calsanCinsiyet = "Erkek",
                calsanEgitimDurumu = "Ön Lisans",
                telefonNumarasi = "555-9012",
                Resim = null
            });

            ProjeleriDataGridViewEkle(projeler);

        }


        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab == tabPageNewCalisan)
            {
                try
                {
                    // Gerekli alan kontrolü
                    if (!GerekliAlanlarDoluMu())
                    {
                        MessageBox.Show("Lütfen tüm gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Yeni çalışan oluştur
                    Calisan yeniCalisan = new Calisan
                    {
                        calisanTc = txtNewCalisanTC.Text,
                        calsanAdi = txtNewCalisanAd.Text,
                        calsanCinsiyet = radioButtonK.Checked ? "Kadın" : "Erkek",
                        calsanEgitimDurumu = cmbBoxEgitim.SelectedItem.ToString(),
                        telefonNumarasi = maskedTextBoxCalisanTel.Text,
                        Resim = ResmiByteDizisineDonustur(pictureBoxCalisan.Image),
                        IseBaslamaTarihi = iseBaslamaTarihi
                    };

                    // Calisan listesine ekle
                    calisanlar.Add(yeniCalisan);

                    // TODO: Veritabanına veya başka bir yerde saklama işlemi yapılabilir

                    MessageBox.Show("Yeni çalışan başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (tabCntrl.SelectedTab == tabPageNewP)
            {
                
                try
                {
                    // Gerekli bilgileri al
                    string projeAdi = txtProjeAdi.Text;
                    string stratejikEtki = txtProjeSEtki.Text;
                    string projeNo = txtProjeNo.Text;
                    Calisan projeYurutucusu = (Calisan)cmbBoxPY.SelectedItem;
                    string amac = rtxtProjeAmac.Text;
                    string problemTanimi = rtxtProjeProblem.Text;
                    string kapsam = rtxtProjeKapsam.Text;
                   
                    ProjeTipi projeTipi = (ProjeTipi)comboBoxPTipi.SelectedItem;

                    DateTime kayitTarihi = DateTime.Now;
                    DateTime projeBaslangici = dateTimePrjBaslangic.Value;
                    DateTime projeBitisi = dateTimePrjBitis.Value;
                    decimal parasalGetiri = decimal.Parse(txtParasalGetirisi.Text);
                    string parasalGetiriTipi = (string)cmbParasalGetiriTipi.SelectedItem.ToString();
                    List<Calisan> projeEkip = new List<Calisan>();
                    foreach (Calisan calisan in chcListBxProjeEkibi.CheckedItems)
                    {
                        projeEkip.Add(calisan);
                    }
                    List<string> projeDokumanlari = new List<string>();
                    foreach (string dokuman in projeDokumanlari)
                    {
                        projeDokumanlari.Add(dokuman);
                    }
                    

                    // Proje nesnesini oluşturdum.
                    Proje yeniProje = new Proje
                    {
                        ProjeAdi = projeAdi,
                        StratejikEtki = stratejikEtki,
                        ProjeNo = projeNo,
                        ProjeYurutucusu = projeYurutucusu,
                        Amac = amac,
                        ProblemTanimi = problemTanimi,
                        Kapsam = kapsam,
                        KayitTarihi = kayitTarihi,
                        ProjeBaslangici = projeBaslangici,
                        TahminiBitis = projeBitisi,
                        Durum = Durum.OnayBekliyor, // Varsayılan durumu belirtildi
                        ParasalGetiri = parasalGetiri,
                        ParasalGetiriTipi = parasalGetiriTipi,
                        ProjeEkip = projeEkip,
                        ProjeDokumanlari = projeDokumanlari,
                        ProjeTipi = projeTipi,
                        KilometreTaslari = new List<KilometreTasi>() // Boş bir liste ile başlatıldı
                    };

                    
                    TreeViewBilgileriProjeNesnesineEkle(yeniProje);
                    projeler.Add(yeniProje);
                    ProjeleriDataGridViewEkle(projeler);

                    MessageBox.Show("Yeni proje başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TemizleYeniProje();
                    projeDokumanlari.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TreeViewBilgileriProjeNesnesineEkle(Proje proje)
        {
            foreach (TreeNode kmTasiNode in treeViewKmG.Nodes)
            {
                KilometreTasi kilometreTasi = new KilometreTasi
                {
                    Ad = kmTasiNode.Text
                };

                foreach (TreeNode gorevNode in kmTasiNode.Nodes)
                {
                    Gorev gorev = new Gorev
                    {
                        Ad = gorevNode.Text
                    };

                    kilometreTasi.Gorevler.Add(gorev);
                }

                proje.KilometreTaslari.Add(kilometreTasi);
            }
        }


        private byte[] ResmiByteDizisineDonustur(Image resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private bool GerekliAlanlarDoluMu()
        {
            string telefonNumarasi = maskedTextBoxCalisanTel.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            return !(
                string.IsNullOrWhiteSpace(txtNewCalisanTC.Text) ||
                string.IsNullOrWhiteSpace(txtNewCalisanAd.Text) ||
                (!radioButtonK.Checked && !radioButtonE.Checked) ||
                cmbBoxEgitim.SelectedItem == null ||
                string.IsNullOrEmpty(telefonNumarasi) || telefonNumarasi.Length != 10  ||
                pictureBoxCalisan.Image == null
            );
        }

        private void pictureBoxCalisan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmi pictureBoxCalisan'a yükle
                pictureBoxCalisan.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Temizle()
        {
            // Giriş alanlarını temizle
            txtNewCalisanTC.Clear();
            txtNewCalisanAd.Clear();
            radioButtonK.Checked = false;
            radioButtonE.Checked = false;
            cmbBoxEgitim.SelectedIndex = -1;
            maskedTextBoxCalisanTel.Clear();
            pictureBoxCalisan.Image = null;
        }

        private void txtNewCalisanTC_Leave(object sender, EventArgs e)
        {
            if (txtNewCalisanTC.TextLength != 11 || !txtNewCalisanTC.Text.All(char.IsDigit))
            {
                MessageBox.Show("Geçersiz T.C. Kimlik Numarası. Lütfen 11 haneli bir sayı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewCalisanTC.Focus();
            }
        }

        private void VerileriListeyeEkle()
        {
            // Öncelikle ListView'in sütunlarını tanımlayalım
            listViewCalisanlar.Clear();
            listViewCalisanlar.View = View.Details;
            listViewCalisanlar.Columns.Add("TC", 100);
            listViewCalisanlar.Columns.Add("Adı", 150);
            listViewCalisanlar.Columns.Add("Cinsiyet", 80);
            listViewCalisanlar.Columns.Add("Eğitim Durumu", 150);
            listViewCalisanlar.Columns.Add("Telefon Numarası", 120);

            // Calisan listesini döngü ile dolaşarak her bir çalışanı ListView'e ekleyelim
            foreach (Calisan calisan in calisanlar)
            {
                ListViewItem item = new ListViewItem(calisan.calisanTc.ToString());
                item.SubItems.Add(calisan.calsanAdi);
                item.SubItems.Add(calisan.calsanCinsiyet);
                item.SubItems.Add(calisan.calsanEgitimDurumu);
                item.SubItems.Add(calisan.telefonNumarasi);

                listViewCalisanlar.Items.Add(item);
            }
        }


        private void tabPageCalisanlar_Enter(object sender, EventArgs e)
        {
            VerileriListeyeEkle();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            string yeniKullaniciAdi = txtNewUserName.Text;
            string yeniSifre = txtNewUserPassword.Text;

            if (string.IsNullOrEmpty(yeniKullaniciAdi) || string.IsNullOrEmpty(yeniSifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici yeniKullanici = new Kullanici(yeniKullaniciAdi, yeniSifre);
            kullanicilar.Add(yeniKullanici);

            MessageBox.Show("Yeni kullanıcı başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KullanicilariListeyeEkle();
            
        }
        private void KullanicilariListeyeEkle()
        {
            listViewCalisanlar.Clear();
            listViewCalisanlar.View = View.Details;
            listViewCalisanlar.Columns.Add("Kullanıcı Adı", 150);

            listBoxUsers.Items.Clear();
            foreach (Kullanici kullanici in kullanicilar)
            {
                listBoxUsers.Items.Add($"{kullanici.KullaniciAdi} - {kullanici.Sifre}");
            }

            txtNewUserName.Clear();
            txtNewUserPassword.Clear();
   
        }

        private void tabPageNewUser_Enter(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            KullanicilariListeyeEkle();

        }

        private void btnProjeDokumanEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Doküman Seç";
            openFileDialog.Filter = "Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaAdi = Path.GetFileName(openFileDialog.FileName);
                projeDokumanlari.Add(secilenDosyaAdi);
                GuncelleProjeDokumanListesi();
            }
        }

        private void GuncelleProjeDokumanListesi()
        {
            listBoxProjeDokumanlari.Items.Clear();
            listBoxProjeDokumanlari.Items.AddRange(projeDokumanlari.ToArray());
        }

       
        private void tabPageNewP_Enter(object sender, EventArgs e)
        {
            foreach (Calisan calisan in calisanlar)
            {
                cmbBoxPY.Items.Add(calisan);
                chcListBxProjeEkibi.Items.Add(calisan, false);
            }

            cmbBoxPY.DisplayMember = "calsanAdi";
            chcListBxProjeEkibi.DisplayMember = "calsanAdi";

        }

        private string OtomatikProjeNoOlustur()
        {
            // PRJ ön eki ile birlikte bir numara oluştur
            // Burada projeler listesindeki en son proje 
            //numarasını alıp bir artırma işlemi gerçekleştiriyoruz
            int siradakiProjeNo = projeler.Count + 1;
            string otomatikProjeNo = $"PRJ{DateTime.Now.Year}-{siradakiProjeNo:D4}";
            //-{txtProjeAdi.Text} proje adı da eklenebilir

            return otomatikProjeNo;
        }

        private void txtProjeAdi_Leave(object sender, EventArgs e)
        {
            txtProjeNo.Text = OtomatikProjeNoOlustur();
        }

        private void ProjeleriDataGridViewEkle(List<Proje> projeler)
        {
            dataGridViewProjeler.Rows.Clear(); 

            foreach (Proje proje in projeler)
            {
                // DataGridView'e eklenecek bir satır oluştur
                DataGridViewRow row = new DataGridViewRow();

                // Proje sınıfının her bir özelliğini DataGridView'e bir hücre olarak ekledim
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.ProjeNo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.ProjeAdi });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.Durum });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.ProjeYurutucusu != null ? proje.ProjeYurutucusu.calsanAdi : "" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.KayitTarihi });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.ProjeBaslangici });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.TahminiBitis });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proje.ProjeBitisi });

                // Oluşturulan satırı DataGridView'e ekledim
                dataGridViewProjeler.Rows.Add(row);

               
            }
            DataGridViewRenklendir();
        }

        private void TemizleYeniProje()
        {
            txtProjeAdi.Clear();
            txtProjeSEtki.Clear();
            txtProjeNo.Clear();
            cmbBoxPY.SelectedIndex = -1;
            rtxtProjeAmac.Clear();
            rtxtProjeProblem.Clear();
            rtxtProjeKapsam.Clear();
            comboBoxPTipi.SelectedIndex = -1;
            dateTimePrjBaslangic.Value = DateTime.Now;
            dateTimePrjBitis.Value = DateTime.Now;
            txtParasalGetirisi.Clear();
            cmbParasalGetiriTipi.SelectedIndex = -1;
            listBoxProjeDokumanlari.Items.Clear();
            treeViewKmG.Nodes.Clear();

            
            foreach (int i in chcListBxProjeEkibi.CheckedIndices)
            {
                chcListBxProjeEkibi.SetItemCheckState(i, CheckState.Unchecked);
            }
         
        }

   
        private void AnaForm_ProjeGuncelle(Proje guncellenenProje)
        {
            // Proje listesindeki ilgili projeyi güncelle
            Proje eskiProje = projeler.FirstOrDefault(p => p.ProjeNo == guncellenenProje.ProjeNo);
            if (eskiProje != null)
            {
                eskiProje.Durum = guncellenenProje.Durum;
                eskiProje.ProjeBitisi = guncellenenProje.ProjeBitisi;

                // DataGridView'i güncelle
                ProjeleriDataGridViewEkle(projeler);
                DataGridViewRenklendir();
            }
          

        }


        private void DataGridViewRenklendir()
        {
            //string tahminiBitisColumnName = "ProjeTbitis";
           
            foreach (DataGridViewRow row in dataGridViewProjeler.Rows)
            {
                string durum = Convert.ToString(row.Cells[ProjeDurumu.Index].Value);

                if (row.Cells[ProjeTbitis.Index].Value is DateTime tahminiBitis &&
                    tahminiBitis < DateTime.Now)
                {
                    SatiriRenklendir(row, Color.Red);

                    if (durum == "Tamamlandi")
                    {
                        SatiriRenklendir(row, Color.Green);
                    }
                    else if (durum == "Red")
                    {
                        SatiriRenklendir(row, Color.Gray);
                    }
                }
                else
                {
                    Color arkaPlanRenk;

                    switch (durum)
                    {
                        case "Tamamlandi":
                            arkaPlanRenk = Color.Green;
                            break;
                        case "DevamEdiyor":
                            arkaPlanRenk = Color.Yellow;
                            break;
                        case "Red":
                            arkaPlanRenk = Color.Gray;
                            break;
                        default:
                            arkaPlanRenk = dataGridViewProjeler.DefaultCellStyle.BackColor;
                            break;
                    }

                    SatiriRenklendir(row, arkaPlanRenk);
                }
            }



        }

        private void SatiriRenklendir(DataGridViewRow row, Color arkaPlanRenk)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = arkaPlanRenk;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Formu tam ekran aç
            WindowState = FormWindowState.Maximized;

            comboBoxPTipi.DataSource = Enum.GetValues(typeof(ProjeTipi));
            toolTipFotoEkle.SetToolTip(pictureBoxCalisan, "Fotoğraf eklemek için tıklayın");
            toolStripButtonKaydet.Text = "Kaydet";
            toolStripBtnGuncelle.Text = "Güncelle";
            toolStripBtnSil.Text = "Sil";
        }

        private void btnKmTasEkle_Click(object sender, EventArgs e)
        {
            string kmTasiAdi = txtKmTasi.Text;

            if (!string.IsNullOrEmpty(kmTasiAdi))
            {
                TreeNode kmTasiNode = new TreeNode(kmTasiAdi);
                treeViewKmG.Nodes.Add(kmTasiNode);
                txtKmTasi.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Lütfen bir kilometre taşı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            string gorevAdi = txtGorevler.Text;

            if (!string.IsNullOrEmpty(gorevAdi))
            {
                if (treeViewKmG.SelectedNode != null)
                {
                    TreeNode selectedNode = treeViewKmG.SelectedNode;
                    TreeNode gorevNode = new TreeNode(gorevAdi);
                    selectedNode.Nodes.Add(gorevNode);
                    txtGorevler.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Lütfen bir kilometre taşı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir görev adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab == tabPageHome)
            {
                // Aktif tab tabPageHome ise devam et
                if (dataGridViewProjeler.SelectedRows.Count > 0)
                {
                    // dataGridView1'de en az bir satır seçili ise devam et
                    DataGridViewRow selectedRow = dataGridViewProjeler.SelectedRows[0];
                    string selectedProjeNumarasi = selectedRow.Cells["ProjeNo"].Value.ToString();

                    Proje selectedProje = projeler.FirstOrDefault(p => p.ProjeNo == selectedProjeNumarasi);

                    // ProjeDetay formunu oluştur ve Proje nesnesini ileterek göster
                    if (selectedProje != null)
                    {
                        ProjeDetay projeDetayForm = new ProjeDetay(selectedProje);
                        projeDetayForm.ProjeGuncelle += AnaForm_ProjeGuncelle;
                        projeDetayForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir proje seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab == tabPageHome)
            {
                // Seçili satırın index'ini al
                int selectedIndex = dataGridViewProjeler.SelectedCells[0].RowIndex;

                // Seçili satırın ProjeNo'sunu bul
                string projeNo = dataGridViewProjeler.Rows[selectedIndex].Cells["ProjeNo"].Value.ToString();

                // Projeler listesindeki projeyi bul ve listeden sil
                Proje silinecekProje = projeler.FirstOrDefault(p => p.ProjeNo == projeNo);
                if (silinecekProje != null)
                {
                    projeler.Remove(silinecekProje);
                }

                // DataGridView'dan seçili satırı sil
                dataGridViewProjeler.Rows.RemoveAt(selectedIndex);

                // Proje bilgilerini güncelle
                ProjeleriDataGridViewEkle(projeler);

                MessageBox.Show("Proje başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }

  

            if(tabCntrl.SelectedTab== tabPageNewUser)
            {
                // Seçilen öğenin indeksini al
                int selectedIndex = listBoxUsers.SelectedIndex;

                // Eğer bir öğe seçili ise
                if (selectedIndex >= 0)
                {
                    listBoxUsers.Items.RemoveAt(selectedIndex);

                    if (kullanicilar != null && kullanicilar.Count > selectedIndex)
                    {
                        kullanicilar.RemoveAt(selectedIndex);                      
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if(tabCntrl.SelectedTab==tabPageCalisanlar)
            {
                
                int selectedIndex = listViewCalisanlar.SelectedIndices.Count > 0 ? listViewCalisanlar.SelectedIndices[0] : -1;

               
                if (selectedIndex >= 0)
                {
                    
                    listViewCalisanlar.Items.RemoveAt(selectedIndex);

                    if (calisanlar != null && calisanlar.Count > selectedIndex)
                    {
                        calisanlar.RemoveAt(selectedIndex);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void SaatGuncelleTimerBaslat()
        {
            Timer saatGuncelleTimer = new Timer();
            saatGuncelleTimer.Interval = 1000; // 1 saniyede bir güncelle
            saatGuncelleTimer.Tick += SaatGuncelleTimer_Tick;
            saatGuncelleTimer.Start();
        }

        private void SaatGuncelleTimer_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToString("HH:mm:ss");
            saatLabel.Text = "Saat: " + saat;
        }

       

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCntrl.SelectedTab = tabPageHome;
        }

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCntrl.SelectedTab = tabPageNewUser;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void projeListesiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabCntrl.SelectedTab = tabPageHome;
        }

        private void CalisanListesiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab != tabPageCalisanlar)
            {
                tabCntrl.SelectedTab = tabPageCalisanlar;
            }

           
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "XML Dosyaları|*.xml|Tüm Dosyalar|*.*";
                    saveFileDialog.Title = "Çalışan Listesini Kaydet";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // XML dosyasına veriyi kaydet
                        string dosyaYolu = saveFileDialog.FileName;

                        List<Calisan> calisanlarListesi = new List<Calisan>();

                        foreach (Calisan calisan1 in calisanlar)
                        {
                           calisanlarListesi.Add(calisan1);
                        }

                        CalisanlariKaydet(calisanlarListesi, dosyaYolu);

                        MessageBox.Show("Çalışan Listesi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
        }
        public class CalisanListesi
        {
            public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();
        }
        public static void CalisanlariKaydet(List<Calisan> calisanlar, string dosyaYolu)
        {
            try
            {
                // XML dosyasına veriyi kaydet
                using (var writer = new StreamWriter(dosyaYolu))
                {
                    var serializer = new XmlSerializer(typeof(CalisanListesi));
                    serializer.Serialize(writer, new CalisanListesi { Calisanlar = calisanlar });
                }

                Console.WriteLine("Çalışan Listesi Başarıyla Kaydedildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void kullanıcıListesiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab != tabPageNewUser)
            {
                tabCntrl.SelectedTab = tabPageNewUser;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Dosyaları|*.xml|Tüm Dosyalar|*.*";
                saveFileDialog.Title = "Kullanıcı Listesini Kaydet";

                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string dosyaYolu = saveFileDialog.FileName;
                    KullanicilariKaydet(kullanicilar, dosyaYolu);
                    MessageBox.Show("Kullanıcı Listesi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void KullanicilariKaydet(List<Kullanici> kullanicilar, string dosyaYolu)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kullanici>));
            using (TextWriter writer = new StreamWriter(dosyaYolu))
            {
                serializer.Serialize(writer, kullanicilar);
            }

        }

        private void projeListesiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tabCntrl.SelectedTab != tabPageHome)
            {
                tabCntrl.SelectedTab = tabPageHome;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Dosyaları|*.xml|Tüm Dosyalar|*.*";
                saveFileDialog.Title = "Proje Listesini Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = saveFileDialog.FileName;
                    ProjeleriKaydet(projeler, dosyaYolu);
                    MessageBox.Show("Proje Listesi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void ProjeleriKaydet(List<Proje> projeler, string dosyaYolu)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Proje>));
            using (TextWriter writer = new StreamWriter(dosyaYolu))
            {
                serializer.Serialize(writer, projeler);
            }
        }

        private void tabCntrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab == tabPageNewUser || tabCntrl.SelectedTab == tabPageCalisanlar
                || tabCntrl.SelectedTab == tabPageNewCalisan || tabCntrl.SelectedTab == tabPageNewP)

            {
                toolStripBtnGuncelle.Enabled = false; 
                
            }
            else
            {
                toolStripBtnGuncelle.Enabled = true; 
            }

            if (tabCntrl.SelectedTab == tabPageNewP || tabCntrl.SelectedTab == tabPageNewP)
            {
                toolStripBtnSil.Enabled = false;
            }
            else
            {
                toolStripBtnSil.Enabled = true; // toolStripButton2'yi aktif yap
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO : Veritabanı yeni liste aktarımı işlemleri

            MessageBox.Show("Oturumunuz kapatılıyor.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridViewProjeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjeler.Rows[e.RowIndex];

                // Satırdan verileri al
                string projeNo = selectedRow.Cells["ProjeNo"].Value.ToString();

                // Proje listesinde ilgili projeyi bul
                Proje selectedProje = projeler.FirstOrDefault(p => p.ProjeNo == projeNo);

                // Eğer proje bulunduysa KmTasiForm'u oluştur ve verileri ileterek göster
                if (selectedProje != null)
                {
                    KmTasi kmTasiForm = new KmTasi (selectedProje.KilometreTaslari);
                    kmTasiForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Proje bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNewUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş bir sayı veya harf değilse ve karakter uzunluğu 6'dan küçükse kabul et
            if (!char.IsLetterOrDigit(e.KeyChar) || txtNewUserPassword.Text.Length < 6)
            {
                e.Handled = false; // Tuşu kabul et
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtGorevler_TextChanged(object sender, EventArgs e)
        {
            // Eğer kilometre taşı seçili değilse
            if (treeViewKmG.SelectedNode == null)
            {
                MessageBox.Show("Lütfen görev eklemek için önce bir kilometre taşı seçtiğinizden emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGorevler.Clear(); 
                return;
            }
              
        }

        private void mnthClIseBaslamaTarihi_DateSelected(object sender, DateRangeEventArgs e)
        {
            iseBaslamaTarihi = e.Start;
        }

        private void txtNewUserPassword_Leave(object sender, EventArgs e)
        {
            
            int minimumUzunluk = 6;

            // Şifre kontrolü
            string sifre = txtNewUserPassword.Text;

            if (sifre.Length < minimumUzunluk)
            {
                MessageBox.Show($"Şifre en az {minimumUzunluk} karakter uzunluğunda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewUserPassword.Focus();
                return;
            }

            // Şifre içinde en az bir harf ve bir sayı bulunmalıdır
            if (!sifre.Any(char.IsLetter) || !sifre.Any(char.IsDigit))
            {
                MessageBox.Show("Şifre en az bir harf ve bir sayı içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewUserPassword.Focus();
            }

        }
    }
    
}


    

