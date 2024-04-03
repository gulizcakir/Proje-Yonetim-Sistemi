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
    public partial class KmTasi : Form
    {
        public KmTasi(List<KilometreTasi> KilometreTaslari)
        {
            InitializeComponent();


            Load += KmTasi_Load; // Form yüklendiğinde işlemleri yapmak için olaya abone olun


            foreach (KilometreTasi kmTasi in KilometreTaslari)
            {
                TreeNode KmTNode = new TreeNode(kmTasi.Ad.ToString());
                treeViewKmTasiDetay.Nodes.Add(KmTNode);

                if (kmTasi.Gorevler != null)
                {
                    foreach (Gorev gorev in kmTasi.Gorevler)
                    {
                        TreeNode gorevN = new TreeNode(gorev.Ad);
                        KmTNode.Nodes.Add(gorevN);
                    }
                }
            }

        }


        private void KmTasi_Load(object sender, EventArgs e)
        {

        }


        private void treeViewKmTasiDetay_DoubleClick(object sender, EventArgs e)
        {
            // Çift tıklanan düğümü kontrol et
            if (treeViewKmTasiDetay.SelectedNode != null)
            {
                // Font Dialog'u göster
                using (FontDialog fontDialog = new FontDialog())
                {
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Font'u seçilen düğüme uygula
                        treeViewKmTasiDetay.SelectedNode.NodeFont = fontDialog.Font;
                    }
                }

                // Renk Dialog'u göster
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Rengi seçilen düğüme uygula
                        treeViewKmTasiDetay.SelectedNode.ForeColor = colorDialog.Color;
                    }
                }
            }
        }

        private void treeViewKmTasiDetay_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Tıklanan TreeNode'ın üstünü çiz
            e.Node.NodeFont = new Font(treeViewKmTasiDetay.Font, FontStyle.Italic | FontStyle.Strikeout);

            // Tıklanan TreeNode'ın rengini yeşil yap
            e.Node.ForeColor = Color.Green;
        }
    }
}
