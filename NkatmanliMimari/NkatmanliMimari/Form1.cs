using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer1;
using LogicLayer;

namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LlPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAd.Text;
            ent.Soyad= txtSoyad.Text;
            ent.Sehir = txtSehir.Text;
            ent.Gorev = txtGorev.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LlPersonelEkle(ent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtId.Text);
            LogicPersonel.LlPersonelSil(ent.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtId.Text);
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sehir = txtSehir.Text;
            ent.Gorev= txtGorev.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LlPersonelGuncelle(ent);
        }
    }
}
