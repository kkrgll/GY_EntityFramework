namespace GY_EntityFramework
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDersID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDersDegistir = new System.Windows.Forms.Button();
            this.BtnDersSil = new System.Windows.Forms.Button();
            this.BtnDersKaydet = new System.Windows.Forms.Button();
            this.BtnDersListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 159);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtDersAd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtDersID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(164, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(79, 52);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(100, 20);
            this.TxtDersAd.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "AD";
            // 
            // TxtDersID
            // 
            this.TxtDersID.Location = new System.Drawing.Point(79, 26);
            this.TxtDersID.Name = "TxtDersID";
            this.TxtDersID.Size = new System.Drawing.Size(100, 20);
            this.TxtDersID.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "ID";
            // 
            // BtnDersDegistir
            // 
            this.BtnDersDegistir.Location = new System.Drawing.Point(12, 315);
            this.BtnDersDegistir.Name = "BtnDersDegistir";
            this.BtnDersDegistir.Size = new System.Drawing.Size(108, 23);
            this.BtnDersDegistir.TabIndex = 27;
            this.BtnDersDegistir.Text = "Dersi Değiştir";
            this.BtnDersDegistir.UseVisualStyleBackColor = true;
            this.BtnDersDegistir.Click += new System.EventHandler(this.BtnDersDegistir_Click);
            // 
            // BtnDersSil
            // 
            this.BtnDersSil.Location = new System.Drawing.Point(12, 275);
            this.BtnDersSil.Name = "BtnDersSil";
            this.BtnDersSil.Size = new System.Drawing.Size(108, 23);
            this.BtnDersSil.TabIndex = 26;
            this.BtnDersSil.Text = " Dersi Sil";
            this.BtnDersSil.UseVisualStyleBackColor = true;
            this.BtnDersSil.Click += new System.EventHandler(this.BtnDersSil_Click);
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.Location = new System.Drawing.Point(12, 234);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(108, 23);
            this.BtnDersKaydet.TabIndex = 25;
            this.BtnDersKaydet.Text = "Ders Kaydet";
            this.BtnDersKaydet.UseVisualStyleBackColor = true;
            this.BtnDersKaydet.Click += new System.EventHandler(this.BtnDersKaydet_Click);
            // 
            // BtnDersListele
            // 
            this.BtnDersListele.Location = new System.Drawing.Point(13, 195);
            this.BtnDersListele.Name = "BtnDersListele";
            this.BtnDersListele.Size = new System.Drawing.Size(107, 23);
            this.BtnDersListele.TabIndex = 24;
            this.BtnDersListele.Text = "Ders Listele";
            this.BtnDersListele.UseVisualStyleBackColor = true;
            this.BtnDersListele.Click += new System.EventHandler(this.BtnDersListele_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 385);
            this.Controls.Add(this.BtnDersDegistir);
            this.Controls.Add(this.BtnDersSil);
            this.Controls.Add(this.BtnDersKaydet);
            this.Controls.Add(this.BtnDersListele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDersID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnDersDegistir;
        private System.Windows.Forms.Button BtnDersSil;
        private System.Windows.Forms.Button BtnDersKaydet;
        private System.Windows.Forms.Button BtnDersListele;
    }
}