using o1_CodeFirstOBS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o1_CodeFirstOBS
{
    public partial class BolumListelemeEkrani : Form
    {
        private ObsDbContext _db;
        public BolumListelemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }
        public void Listele()
        {
            var bolumler = _db.Departments.Include(x => x.Faculty).ToList();

            foreach (var bolum in bolumler)
            {
                ListViewItem li = new ListViewItem(bolum.Id.ToString());
                li.SubItems.Add(bolum.Faculty.Name);
                li.SubItems.Add(bolum.Name);
                li.SubItems.Add(bolum.CreatedDate.ToString("dd/MM/yyyy HH:mm"));
                li.SubItems.Add(bolum.IsActive ? "Aktif" : "Pasif");

                lstvBolumler.Items.Add(li);
            }
        }
        private void BolumListelemeEkrani_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenId = lstvBolumler.SelectedItems[0].Text;

            BolumDuzenlemeEkrani bde = new BolumDuzenlemeEkrani();
            bde.lblID.Text = secilenId;
            bde.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstvBolumler.SelectedItems[0] != null)
            {
                var secilenElemanId = Convert.ToInt32(lstvBolumler.SelectedItems[0].Text);

                var bolum = _db.Departments.FirstOrDefault(x => x.Id == secilenElemanId);

                if (bolum == null)
                {
                    MessageBox.Show("Bu Id'e ait bir kayıt bulunamadı");
                    return;
                }

                bolum.IsActive = false;
                bolum.UpdatedDate = DateTime.Now;
                bolum.UpdatedById = -1;

                var sonuc = _db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Bolum silindi");
                }
            }
            else
            {
                MessageBox.Show("Öncelikle bir bölüm seçiniz");
            }

            this.Close();
            Listele();
        }
    }
}
