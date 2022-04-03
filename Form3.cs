using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GY_EntityFramework
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DbEntitySchoolEntities db = new DbEntitySchoolEntities();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnOrtalama_Click(object sender, EventArgs e)
        {

        }

        private void BtnNotListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLNOTLAR.ToList();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR n = new TBLNOTLAR();
            n.SINAV1 = TxtSinav1.Text;
            n.SINAV2 = TxtSinav2.Text;
            n.SINAV3 = TxtSinav3.Text;
            n.ORTALAMA = TxtOrtalama.Text;
            n.DURUM = TxtDurum.Text;

            db.TBLNOTLAR.Add(n);
            db.SaveChanges();
            MessageBox.Show("Notlar Eklenmiştir.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrencNotiID.Text);
            var x = db.TBLNOTLAR.Find(id);
            db.TBLNOTLAR.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Notlar sistemden silindi.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
