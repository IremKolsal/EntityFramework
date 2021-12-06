using k1_CodeFirst.Entities;
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

namespace k1_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKategoriGetir_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();
            //db bağlantısı
            NorthwindDbContext db = new NorthwindDbContext(); //instance

            //db den veri çekelim
            var kategoriler = db.Categories.ToList(); //select * from Categories
            //var kategoriAdi = db.Categories.Select(x => x.CategoryName).ToList();

            //design'a listbox ekleyiniz ve kategorilerin adını listeleyiniz.
            foreach (var kategori in kategoriler)
            {
                lstSonuc.Items.Add(kategori.CategoryName);
            }

            //kategori id'si 5 olan kategoriyi getiriniz
            var sonuc = db.Categories.FirstOrDefault(x => x.CategoryID == 5);
            if (sonuc != null)
            {
                MessageBox.Show($"Id'si 5 olan kategorinin adı: {sonuc.CategoryName}");
            }


            //KategoriAdı içinde e geçen kategorileri listeleyiniz.
            var sonuc1 = db.Categories.Where(x => x.CategoryName.Contains("e")).ToList();


            //kategoriId'si 1 olan kategorinin ürünlerini de getiriniz.
            var sonuc2 = db.Categories.Include(x => x.Products).FirstOrDefault(x => x.CategoryID == 1); //using System.Data.Entity


        }

        private void btnSiparisleriGetir_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            var siparisler = db.Orders
                .Include(x => x.Shipper)
                .Take(20)
                .ToList();

            lstSonuc.Items.Clear();

            foreach (var siparis in siparisler)
            {
                lstSonuc.Items.Add($"{siparis.OrderID}-{siparis.OrderDate.Value.ToString("dd/MM/yy")}-{siparis.Shipper.CompanyName}"); //HasValue-boolean 
            }
        }

        private void btnKargolariGetir_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            var kargolar = db.Shippers.ToList();

            lstSonuc.Items.Clear();

            foreach (var kargo in kargolar)
            {
                lstSonuc.Items.Add($"{kargo.CompanyName} - {kargo.Phone}");
            }
        }

        private void btnSiparisDetaylariniGetir_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            //var orderOrderDetails = db.Orders.Include(x => x.OrderDetails).Take(3).ToList();

            //var productOrderDetails = db.Products.Include(x => x.OrderDetails).Take(2).ToList();

            var orderDetailOrderProduct = db.OrderDetails.Include(x => x.Order).Include(x => x.Product).Take(3).ToList();
        }
    }
}
