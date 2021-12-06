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
    public partial class BolumDuzenlemeEkrani : Form
    {
        private ObsDbContext _db;
        public BolumDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }

        int secilenId;
        private void BolumDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            secilenId = Convert.ToInt32(lblID.Text);

            var bolum = _db.Departments.Include(x=>x.Faculty).FirstOrDefault(x => x.Id == secilenId);
            if (bolum == null)
            {
                MessageBox.Show("Bu Id de bir eleman bulunamadı");
            }

            txtBolumAdi.Text = bolum.Name;

            //Fakülteleri getirip cmb' e ekleyelim
            var fakulteler = _db.Faculties.Where(x => x.IsActive).ToList();
            foreach (var fakulte in fakulteler)
            {
                cmbFakulteler.Items.Add(fakulte);
            }
            cmbFakulteler.SelectedItem = bolum.Faculty;

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var guncellenecekBolum = _db.Departments.FirstOrDefault(x => x.Id == secilenId);
            if (guncellenecekBolum == null)
            {
                MessageBox.Show("Eleman bulunamadı");
                return;
            }
            guncellenecekBolum.Name = txtBolumAdi.Text;
            guncellenecekBolum.FacultyId = ((Faculty)cmbFakulteler.SelectedItem).Id;
            guncellenecekBolum.UpdatedById = -1;
            guncellenecekBolum.UpdatedDate = DateTime.Now;

            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Güncelleme başarılı");

            }
        }
    }
}
