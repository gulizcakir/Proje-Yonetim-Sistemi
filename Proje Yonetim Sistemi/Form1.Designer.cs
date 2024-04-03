namespace Proje_Yonetim_Sistemi
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtPsswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkYeniKayıt = new System.Windows.Forms.LinkLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.grpBxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(215, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJE YÖNETİM SİSTEMİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpBxLogin.Controls.Add(this.btnGiris);
            this.grpBxLogin.Controls.Add(this.txtPsswd);
            this.grpBxLogin.Controls.Add(this.label3);
            this.grpBxLogin.Controls.Add(this.txtUserName);
            this.grpBxLogin.Controls.Add(this.label2);
            this.grpBxLogin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxLogin.Location = new System.Drawing.Point(148, 104);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Size = new System.Drawing.Size(474, 233);
            this.grpBxLogin.TabIndex = 1;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "LOGİN";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.Menu;
            this.btnGiris.Location = new System.Drawing.Point(338, 180);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(120, 38);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtPsswd
            // 
            this.txtPsswd.Location = new System.Drawing.Point(181, 126);
            this.txtPsswd.Name = "txtPsswd";
            this.txtPsswd.PasswordChar = '●';
            this.txtPsswd.Size = new System.Drawing.Size(148, 34);
            this.txtPsswd.TabIndex = 3;
            this.txtPsswd.Leave += new System.EventHandler(this.txtPsswd_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(181, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 34);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı adı:";
            // 
            // linkYeniKayıt
            // 
            this.linkYeniKayıt.AutoSize = true;
            this.linkYeniKayıt.Location = new System.Drawing.Point(528, 355);
            this.linkYeniKayıt.Name = "linkYeniKayıt";
            this.linkYeniKayıt.Size = new System.Drawing.Size(109, 18);
            this.linkYeniKayıt.TabIndex = 2;
            this.linkYeniKayıt.TabStop = true;
            this.linkYeniKayıt.Text = "İletişime Geçin\r\n";
            this.linkYeniKayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYeniKayıt_LinkClicked);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.linkYeniKayıt);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Yönetim Sistemi";
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtPsswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkYeniKayıt;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

