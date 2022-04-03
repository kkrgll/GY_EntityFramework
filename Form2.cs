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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbEntitySchoolEntities db = new DbEntitySchoolEntities();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDersListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLDERSLER.ToList();
           
        }

        private void BtnDersKaydet_Click(object sender, EventArgs e)
        {
            TBLDERSLER d=new TBLDERSLER();
            d.DERSAD = TxtDersAd.Text;

            db.TBLDERSLER.Add(d);
            db.SaveChanges();
            MessageBox.Show("Ders Eklenmiştir.");
        }

        private void BtnDersSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtDersID.Text);
            var x = db.TBLDERSLER.Find(id);
            db.TBLDERSLER.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ders sistemden silindi.");
        }

        private void BtnDersDegistir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtDersID.Text);
            var x = db.TBLDERSLER.Find(id);
            x.DERSAD=TxtDersAd.Text;
            db.SaveChanges();
            MessageBox.Show("Ders adı güncellendi.");
        }
    }
}
