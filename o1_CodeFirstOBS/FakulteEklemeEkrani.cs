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
    public partial class FakulteEklemeEkrani : Form
    {

        //fieldlar
        private ObsDbContext _db;

        //sonra constructure
        public FakulteEklemeEkrani()
        {
            InitializeComponent();
            _db = new ObsDbContext();
        }
        //sonra metodlar
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Faculty yeniFakulte = new Faculty()
            {
                //Id: EF kendisi ekleyecek
                Name = txtFakulte.Text,
                CreatedById = -1,
                CreatedDate = DateTime.Now,
                IsActive = true
            };
            _db.Faculties.Add(yeniFakulte);

            var sonuc =_db.SaveChanges(); //execute
            if (sonuc>0)
            {
                MessageBox.Show("Fakülte başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Fakülte eklenemedi");
            }


        }
    }
}
