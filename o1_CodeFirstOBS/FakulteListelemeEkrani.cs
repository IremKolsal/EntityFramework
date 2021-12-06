using o1_CodeFirstOBS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o1_CodeFirstOBS
{
    public partial class FakulteListelemeEkrani : Form
    {
        private ObsDbContext _db;
        public FakulteListelemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }

        public void Listele()
        {
            //dbden fakülteleri getir
            var fakulteler = _db.Faculties.Where(x => x.IsActive).ToList();


            //listviewda satır satır göster.
            foreach (var fakulte in fakulteler)
            {
                ListViewItem li = new ListViewItem(fakulte.Id.ToString());
                li.SubItems.Add(fakulte.Name);
                li.SubItems.Add(fakulte.CreatedDate.ToString("dd/MM/yyyy HH:mm"));
                li.SubItems.Add(fakulte.IsActive ? "Aktif" : "Pasif");

                lstvFakulteler.Items.Add(li);
            }
        }

        private void FakulteListelemeEkrani_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenElemanId = lstvFakulteler.SelectedItems[0].Text; //id

            var secilenId = Convert.ToInt32(secilenElemanId);

            var fakulte = _db.Faculties.FirstOrDefault(x => x.Id == secilenId);

            if (fakulte == null) // null check
            {
                MessageBox.Show("Bu Id'e ait bir kayıt bulunamadı");
                return;
            }

            FakulteDuzenlemeEkrani fde = new FakulteDuzenlemeEkrani();

            fde.lblID.Text = fakulte.Id.ToString();
            fde.txtFakulteAdi.Text = fakulte.Name;

            fde.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenElemanId = Convert.ToInt32(lstvFakulteler.SelectedItems[0].Text);

            var fakulte = _db.Faculties.FirstOrDefault(x => x.Id == secilenElemanId);

            if (fakulte == null) // null check
            {
                MessageBox.Show("Bu Id'e ait bir kayıt bulunamadı");
                return;
            }
            //_db.Faculties.Remove(fakulte); // hard delete
            fakulte.IsActive = false; // soft delete
            fakulte.UpdatedDate = DateTime.Now;
            fakulte.UpdatedById = -1;

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Fakülte silindi");
            }
            this.Close();
            Listele();
        }
    }
}
