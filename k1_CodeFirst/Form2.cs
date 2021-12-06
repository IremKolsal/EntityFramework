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
    public partial class Form2 : Form
    {
        /*
         Proje açıldığında veritabanındaki en son verilen 10 sipariş lstSiparişler listesine eklensin. OrderId, OrderDate
        
         Listeden(lstSiparisler) bir siparis secildiğinde o siparisin detaylari Db'den getirilerek lstSiparisDetaylari listesine eklensin.ProductName, UnitPrice, Quantity

         **Listelerin içini doldururken nesneleri bütünüyle atınız ve alırken o nesneye cast ederek alabilirsiniz.
         **listede istenilen şekilde adlandırmanın görülmesi için sınıf içinde ToString() metodunu override edebilirsiniz.
         */
        public Form2()
        {
            InitializeComponent();
        }

        NorthwindDbContext _db = new NorthwindDbContext();
        public void Listele()
        {
            var orders = _db.Orders.OrderByDescending(x => x.OrderDate).Take(10).ToList();
            foreach (var order in orders)
            {
                lstSiparisler.Items.Add(order);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void lstSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSiparisDetaylari.Items.Clear();

            var selectedOrder = (Order)lstSiparisler.SelectedItem;

            var orderDetails = _db.OrderDetails.Include(x => x.Product).Where(x => x.OrderID == selectedOrder.OrderID).ToList();

            foreach (var item in orderDetails)
            {
                lstSiparisDetaylari.Items.Add(item);
            }

            //sepetteki detay sayisi
            var detaySayisi = orderDetails.Count();
            lblSepettekiDetaySayisi.Text = detaySayisi.ToString();

            //sepetteki urun sayisi
            var urunSayisi = orderDetails.Sum(x => x.Quantity);
            lblSepettekiUrunSayisi.Text = urunSayisi.ToString();

            //genel toplam
            var genelToplam = orderDetails.Sum(x => x.UnitPrice * x.Quantity * (1 - Convert.ToDecimal(x.Discount)));
            lblGenelToplam.Text = genelToplam.ToString();
        }



        //lstSiparisDetay'dan bir detay seçtiğimizde o seçilen ürüne ödenecek ara toplamı bulunuz lblAraToplamda gösteriniz.
        //tutar = UnitPrice* Quantity * (1-Discount)
        private void lstSiparisDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrderDetail = (OrderDetail)lstSiparisDetaylari.SelectedItem;
            var subTutorial = selectedOrderDetail.UnitPrice * selectedOrderDetail.Quantity * (1 - Convert.ToDecimal(selectedOrderDetail.Discount));

            lblAraToplam.Text = subTutorial.ToString();




        }

    }
}
