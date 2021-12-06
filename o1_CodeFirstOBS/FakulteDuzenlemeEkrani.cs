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
    public partial class FakulteDuzenlemeEkrani : Form
    {
        private ObsDbContext _db;
        public FakulteDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //labeldaki değeri alıyoruz dbden bu id ye eşit veriyi getiriyoruz.
            var id = Convert.ToInt32(lblID.Text);

            var fakulte = _db.Faculties.FirstOrDefault(x => x.Id == id);

            //gelen verideki alanları, design tarafından gelen değerlerle değiştiriyoruz.
            fakulte.Name = txtFakulteAdi.Text;
            fakulte.UpdatedById = -1;
            fakulte.UpdatedDate = DateTime.Now;

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Güncelleme başarılı");
            }
        }
    }
}
