namespace Proje_Yonetim_Sistemi
{
    partial class ProjeDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPrjDurumu = new System.Windows.Forms.GroupBox();
            this.btnPrjDetay = new System.Windows.Forms.Button();
            this.checkBoxBitir = new System.Windows.Forms.CheckBox();
            this.checkBoxDevam = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.txtDetayPNo = new System.Windows.Forms.TextBox();
            this.txtDeatyProjeAdi = new System.Windows.Forms.TextBox();
            this.txtDetayProjeYurutucu = new System.Windows.Forms.TextBox();
            this.txtDetayProjeDurumu = new System.Windows.Forms.TextBox();
            this.txtDetayProjeBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetayTahiniBT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeayBitisTarihi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrcUpDownParasalGetiriG = new System.Windows.Forms.NumericUpDown();
            this.cmbParasalGetiriTipi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxPrjDurumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownParasalGetiriG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proje Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proje Yürütücü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proje Durumu:";
            // 
            // groupBoxPrjDurumu
            // 
            this.groupBoxPrjDurumu.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxPrjDurumu.Controls.Add(this.btnPrjDetay);
            this.groupBoxPrjDurumu.Controls.Add(this.checkBoxBitir);
            this.groupBoxPrjDurumu.Controls.Add(this.checkBoxDevam);
            this.groupBoxPrjDurumu.Controls.Add(this.checkBoxRed);
            this.groupBoxPrjDurumu.Location = new System.Drawing.Point(15, 45);
            this.groupBoxPrjDurumu.Name = "groupBoxPrjDurumu";
            this.groupBoxPrjDurumu.Size = new System.Drawing.Size(1033, 149);
            this.groupBoxPrjDurumu.TabIndex = 4;
            this.groupBoxPrjDurumu.TabStop = false;
            this.groupBoxPrjDurumu.Text = "Proje Durumunu Güncelle";
            // 
            // btnPrjDetay
            // 
            this.btnPrjDetay.Location = new System.Drawing.Point(865, 42);
            this.btnPrjDetay.Name = "btnPrjDetay";
            this.btnPrjDetay.Size = new System.Drawing.Size(104, 39);
            this.btnPrjDetay.TabIndex = 3;
            this.btnPrjDetay.Text = "Güncelle";
            this.btnPrjDetay.UseVisualStyleBackColor = true;
            this.btnPrjDetay.Click += new System.EventHandler(this.btnPrjDetay_Click);
            // 
            // checkBoxBitir
            // 
            this.checkBoxBitir.AutoSize = true;
            this.checkBoxBitir.Location = new System.Drawing.Point(323, 50);
            this.checkBoxBitir.Name = "checkBoxBitir";
            this.checkBoxBitir.Size = new System.Drawing.Size(121, 24);
            this.checkBoxBitir.TabIndex = 2;
            this.checkBoxBitir.Text = "Tamamlandı";
            this.checkBoxBitir.UseVisualStyleBackColor = true;
            this.checkBoxBitir.CheckedChanged += new System.EventHandler(this.checkBoxBitir_CheckedChanged);
            // 
            // checkBoxDevam
            // 
            this.checkBoxDevam.AutoSize = true;
            this.checkBoxDevam.Location = new System.Drawing.Point(166, 50);
            this.checkBoxDevam.Name = "checkBoxDevam";
            this.checkBoxDevam.Size = new System.Drawing.Size(133, 24);
            this.checkBoxDevam.TabIndex = 1;
            this.checkBoxDevam.Text = "Devam Ediyor";
            this.checkBoxDevam.UseVisualStyleBackColor = true;
            this.checkBoxDevam.CheckedChanged += new System.EventHandler(this.checkBoxDevam_CheckedChanged);
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.Location = new System.Drawing.Point(70, 50);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(65, 24);
            this.checkBoxRed.TabIndex = 0;
            this.checkBoxRed.Text = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            this.checkBoxRed.CheckedChanged += new System.EventHandler(this.checkBoxRed_CheckedChanged);
            // 
            // txtDetayPNo
            // 
            this.txtDetayPNo.Location = new System.Drawing.Point(163, 42);
            this.txtDetayPNo.Name = "txtDetayPNo";
            this.txtDetayPNo.ReadOnly = true;
            this.txtDetayPNo.Size = new System.Drawing.Size(119, 26);
            this.txtDetayPNo.TabIndex = 5;
            // 
            // txtDeatyProjeAdi
            // 
            this.txtDeatyProjeAdi.Location = new System.Drawing.Point(163, 108);
            this.txtDeatyProjeAdi.Name = "txtDeatyProjeAdi";
            this.txtDeatyProjeAdi.Size = new System.Drawing.Size(119, 26);
            this.txtDeatyProjeAdi.TabIndex = 6;
            // 
            // txtDetayProjeYurutucu
            // 
            this.txtDetayProjeYurutucu.Location = new System.Drawing.Point(151, 145);
            this.txtDetayProjeYurutucu.Name = "txtDetayProjeYurutucu";
            this.txtDetayProjeYurutucu.ReadOnly = true;
            this.txtDetayProjeYurutucu.Size = new System.Drawing.Size(119, 26);
            this.txtDetayProjeYurutucu.TabIndex = 7;
            // 
            // txtDetayProjeDurumu
            // 
            this.txtDetayProjeDurumu.Location = new System.Drawing.Point(151, 196);
            this.txtDetayProjeDurumu.Name = "txtDetayProjeDurumu";
            this.txtDetayProjeDurumu.ReadOnly = true;
            this.txtDetayProjeDurumu.Size = new System.Drawing.Size(119, 26);
            this.txtDetayProjeDurumu.TabIndex = 8;
            // 
            // txtDetayProjeBaslangicTarihi
            // 
            this.txtDetayProjeBaslangicTarihi.Location = new System.Drawing.Point(572, 45);
            this.txtDetayProjeBaslangicTarihi.Name = "txtDetayProjeBaslangicTarihi";
            this.txtDetayProjeBaslangicTarihi.ReadOnly = true;
            this.txtDetayProjeBaslangicTarihi.Size = new System.Drawing.Size(119, 26);
            this.txtDetayProjeBaslangicTarihi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Başlangıç Tarihi:";
            // 
            // txtDetayTahiniBT
            // 
            this.txtDetayTahiniBT.Location = new System.Drawing.Point(572, 108);
            this.txtDetayTahiniBT.Name = "txtDetayTahiniBT";
            this.txtDetayTahiniBT.Size = new System.Drawing.Size(119, 26);
            this.txtDetayTahiniBT.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tahmini Bitiş Tarihi:";
            // 
            // txtDeayBitisTarihi
            // 
            this.txtDeayBitisTarihi.Location = new System.Drawing.Point(572, 173);
            this.txtDeayBitisTarihi.Name = "txtDeayBitisTarihi";
            this.txtDeayBitisTarihi.ReadOnly = true;
            this.txtDeayBitisTarihi.Size = new System.Drawing.Size(119, 26);
            this.txtDeayBitisTarihi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bitiş Tarihi:";
            // 
            // nmrcUpDownParasalGetiriG
            // 
            this.nmrcUpDownParasalGetiriG.Location = new System.Drawing.Point(892, 102);
            this.nmrcUpDownParasalGetiriG.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrcUpDownParasalGetiriG.Name = "nmrcUpDownParasalGetiriG";
            this.nmrcUpDownParasalGetiriG.Size = new System.Drawing.Size(120, 26);
            this.nmrcUpDownParasalGetiriG.TabIndex = 55;
            // 
            // cmbParasalGetiriTipi
            // 
            this.cmbParasalGetiriTipi.FormattingEnabled = true;
            this.cmbParasalGetiriTipi.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.cmbParasalGetiriTipi.Location = new System.Drawing.Point(888, 48);
            this.cmbParasalGetiriTipi.Name = "cmbParasalGetiriTipi";
            this.cmbParasalGetiriTipi.Size = new System.Drawing.Size(124, 28);
            this.cmbParasalGetiriTipi.TabIndex = 54;
            this.cmbParasalGetiriTipi.SelectedIndexChanged += new System.EventHandler(this.cmbParasalGetiriTipi_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(742, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Parasal Getirisi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(738, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Parasal Getiri Tipi:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDetayProjeDurumu);
            this.splitContainer1.Panel1.Controls.Add(this.txtDetayProjeYurutucu);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPrjDurumu);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 473);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 56;
            // 
            // ProjeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 488);
            this.Controls.Add(this.nmrcUpDownParasalGetiriG);
            this.Controls.Add(this.cmbParasalGetiriTipi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDeayBitisTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetayTahiniBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetayProjeBaslangicTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeatyProjeAdi);
            this.Controls.Add(this.txtDetayPNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjeDetay";
            this.Text = "Proje Detay";
            this.Load += new System.EventHandler(this.ProjeDetay_Load);
            this.groupBoxPrjDurumu.ResumeLayout(false);
            this.groupBoxPrjDurumu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownParasalGetiriG)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPrjDurumu;
        private System.Windows.Forms.CheckBox checkBoxBitir;
        private System.Windows.Forms.CheckBox checkBoxDevam;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.Button btnPrjDetay;
        private System.Windows.Forms.TextBox txtDetayPNo;
        private System.Windows.Forms.TextBox txtDeatyProjeAdi;
        private System.Windows.Forms.TextBox txtDetayProjeYurutucu;
        private System.Windows.Forms.TextBox txtDetayProjeDurumu;
        private System.Windows.Forms.TextBox txtDetayProjeBaslangicTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetayTahiniBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeayBitisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrcUpDownParasalGetiriG;
        private System.Windows.Forms.ComboBox cmbParasalGetiriTipi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}