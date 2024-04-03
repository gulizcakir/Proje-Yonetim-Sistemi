namespace Proje_Yonetim_Sistemi
{
    partial class KmTasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KmTasi));
            this.treeViewKmTasiDetay = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewKmTasiDetay
            // 
            this.treeViewKmTasiDetay.CheckBoxes = true;
            this.treeViewKmTasiDetay.Location = new System.Drawing.Point(54, 74);
            this.treeViewKmTasiDetay.Name = "treeViewKmTasiDetay";
            this.treeViewKmTasiDetay.Size = new System.Drawing.Size(667, 351);
            this.treeViewKmTasiDetay.TabIndex = 0;
            this.treeViewKmTasiDetay.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewKmTasiDetay_AfterCheck);
            this.treeViewKmTasiDetay.DoubleClick += new System.EventHandler(this.treeViewKmTasiDetay_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görevlerin üzerine tıklayarak font ve renk değiştirebilirsiniz.";
            // 
            // KmTasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewKmTasiDetay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KmTasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KmTasi";
            this.Load += new System.EventHandler(this.KmTasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewKmTasiDetay;
        private System.Windows.Forms.Label label1;
    }
}