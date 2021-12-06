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
    public partial class FakulteyeBolumEklemeEkrani : Form
    {
        private ObsDbContext _db;
        public FakulteyeBolumEklemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }

        private void FakulteyeBolumEklemeEkrani_Load(object sender, EventArgs e)
        {
            var fakulteler = _db.Faculties.Where(x => x.IsActive).ToList();
            foreach (var fakulte in fakulteler)
            {
                cmbFakulteler.Items.Add(fakulte);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var bolum = new Department()
            {
                Name = txtBolumAdi.Text,
                FacultyId = ((Faculty)cmbFakulteler.SelectedItem).Id, //fakulteyi cast ederiz
                CreatedById = -1,
                CreatedDate = DateTime.Now,
                IsActive = true
            };
            _db.Departments.Add(bolum);

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Bölüm ekleme başarılı");
            }
        }
    }
}
