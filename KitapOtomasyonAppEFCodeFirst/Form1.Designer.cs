namespace KitapOtomasyonAppEFCodeFirst
{
    partial class Form1
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboxkturu = new System.Windows.Forms.ComboBox();
            this.cboxyevi = new System.Windows.Forms.ComboBox();
            this.cboxyazar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.dgridKitap = new System.Windows.Forms.DataGridView();
            this.pnlText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(454, 156);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 36);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(454, 119);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(91, 31);
            this.btnVazgec.TabIndex = 38;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(454, 81);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(91, 32);
            this.btnBul.TabIndex = 37;
            this.btnBul.Text = "KİTAP BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(454, 40);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 35);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboxkturu
            // 
            this.cboxkturu.FormattingEnabled = true;
            this.cboxkturu.Location = new System.Drawing.Point(184, 165);
            this.cboxkturu.Name = "cboxkturu";
            this.cboxkturu.Size = new System.Drawing.Size(121, 21);
            this.cboxkturu.TabIndex = 35;
            // 
            // cboxyevi
            // 
            this.cboxyevi.FormattingEnabled = true;
            this.cboxyevi.Location = new System.Drawing.Point(184, 129);
            this.cboxyevi.Name = "cboxyevi";
            this.cboxyevi.Size = new System.Drawing.Size(121, 21);
            this.cboxyevi.TabIndex = 34;
            // 
            // cboxyazar
            // 
            this.cboxyazar.FormattingEnabled = true;
            this.cboxyazar.Location = new System.Drawing.Point(184, 200);
            this.cboxyazar.Name = "cboxyazar";
            this.cboxyazar.Size = new System.Drawing.Size(121, 21);
            this.cboxyazar.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Basım Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Yayın Evi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Yazar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kitap Adı";
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.SystemColors.Control;
            this.pnlText.Controls.Add(this.txtSayfaSayisi);
            this.pnlText.Controls.Add(this.txtBasimYili);
            this.pnlText.Controls.Add(this.txtKitapAdi);
            this.pnlText.Location = new System.Drawing.Point(184, 13);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(139, 105);
            this.pnlText.TabIndex = 32;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(0, 80);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(121, 20);
            this.txtSayfaSayisi.TabIndex = 2;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBasimYili.Location = new System.Drawing.Point(0, 43);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(121, 20);
            this.txtBasimYili.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(0, 9);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // dgridKitap
            // 
            this.dgridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKitap.Location = new System.Drawing.Point(98, 251);
            this.dgridKitap.Name = "dgridKitap";
            this.dgridKitap.Size = new System.Drawing.Size(547, 158);
            this.dgridKitap.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.dgridKitap);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cboxkturu);
            this.Controls.Add(this.cboxyevi);
            this.Controls.Add(this.cboxyazar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.ComboBox cboxkturu;
        public System.Windows.Forms.ComboBox cboxyevi;
        public System.Windows.Forms.ComboBox cboxyazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.DataGridView dgridKitap;
        public System.Windows.Forms.TextBox txtBasimYili;
        public System.Windows.Forms.TextBox txtSayfaSayisi;
        public System.Windows.Forms.TextBox txtKitapAdi;
    }
}

