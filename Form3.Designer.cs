namespace GY_EntityFramework
{
    partial class Form3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOgrencNotiID = new System.Windows.Forms.TextBox();
            this.OgrenciNotID = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOrtalama = new System.Windows.Forms.Button();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.BtnNotListele = new System.Windows.Forms.Button();
            this.BtnNotSil = new System.Windows.Forms.Button();
            this.BtnNotKaydet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtOgrencNotiID);
            this.groupBox2.Controls.Add(this.OgrenciNotID);
            this.groupBox2.Controls.Add(this.TxtDurum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtOrtalama);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtSinav3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtSinav2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtSinav1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(28, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 203);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // TxtOgrencNotiID
            // 
            this.TxtOgrencNotiID.Location = new System.Drawing.Point(88, 31);
            this.TxtOgrencNotiID.Name = "TxtOgrencNotiID";
            this.TxtOgrencNotiID.Size = new System.Drawing.Size(100, 20);
            this.TxtOgrencNotiID.TabIndex = 24;
            this.TxtOgrencNotiID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OgrenciNotID
            // 
            this.OgrenciNotID.AutoSize = true;
            this.OgrenciNotID.Location = new System.Drawing.Point(20, 34);
            this.OgrenciNotID.Name = "OgrenciNotID";
            this.OgrenciNotID.Size = new System.Drawing.Size(58, 13);
            this.OgrenciNotID.TabIndex = 23;
            this.OgrenciNotID.Text = "Öğrenci ID";
            this.OgrenciNotID.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(88, 161);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(100, 20);
            this.TxtDurum.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "DURUM";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(88, 135);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.TxtOrtalama.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ORTALAMA";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(88, 109);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SINAV 3";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(88, 83);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SINAV 2";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(88, 57);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "SINAV 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 202);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnOrtalama
            // 
            this.BtnOrtalama.Location = new System.Drawing.Point(295, 245);
            this.BtnOrtalama.Name = "BtnOrtalama";
            this.BtnOrtalama.Size = new System.Drawing.Size(107, 59);
            this.BtnOrtalama.TabIndex = 24;
            this.BtnOrtalama.Text = "Ortalama Hesapla";
            this.BtnOrtalama.UseVisualStyleBackColor = true;
            this.BtnOrtalama.Click += new System.EventHandler(this.BtnOrtalama_Click);
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.Location = new System.Drawing.Point(295, 326);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(107, 59);
            this.BtnNotGuncelle.TabIndex = 25;
            this.BtnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnNotListele
            // 
            this.BtnNotListele.Location = new System.Drawing.Point(432, 262);
            this.BtnNotListele.Name = "BtnNotListele";
            this.BtnNotListele.Size = new System.Drawing.Size(108, 23);
            this.BtnNotListele.TabIndex = 26;
            this.BtnNotListele.Text = "Listele";
            this.BtnNotListele.UseVisualStyleBackColor = true;
            this.BtnNotListele.Click += new System.EventHandler(this.BtnNotListele_Click);
            // 
            // BtnNotSil
            // 
            this.BtnNotSil.Location = new System.Drawing.Point(432, 348);
            this.BtnNotSil.Name = "BtnNotSil";
            this.BtnNotSil.Size = new System.Drawing.Size(108, 23);
            this.BtnNotSil.TabIndex = 28;
            this.BtnNotSil.Text = "Sil";
            this.BtnNotSil.UseVisualStyleBackColor = true;
            this.BtnNotSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnNotKaydet
            // 
            this.BtnNotKaydet.Location = new System.Drawing.Point(432, 307);
            this.BtnNotKaydet.Name = "BtnNotKaydet";
            this.BtnNotKaydet.Size = new System.Drawing.Size(108, 23);
            this.BtnNotKaydet.TabIndex = 27;
            this.BtnNotKaydet.Text = "Kaydet";
            this.BtnNotKaydet.UseVisualStyleBackColor = true;
            this.BtnNotKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.BtnNotSil);
            this.Controls.Add(this.BtnNotKaydet);
            this.Controls.Add(this.BtnNotListele);
            this.Controls.Add(this.BtnNotGuncelle);
            this.Controls.Add(this.BtnOrtalama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOrtalama;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.Button BtnNotListele;
        private System.Windows.Forms.Button BtnNotSil;
        private System.Windows.Forms.Button BtnNotKaydet;
        private System.Windows.Forms.TextBox TxtOgrencNotiID;
        private System.Windows.Forms.Label OgrenciNotID;
    }
}