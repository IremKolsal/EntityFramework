
namespace k1_CodeFirst
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.lstSiparisDetaylari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSepettekiUrunSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSepettekiDetaySayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(12, 64);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(776, 212);
            this.lstSiparisler.TabIndex = 0;
            this.lstSiparisler.SelectedIndexChanged += new System.EventHandler(this.lstSiparisler_SelectedIndexChanged);
            // 
            // lstSiparisDetaylari
            // 
            this.lstSiparisDetaylari.FormattingEnabled = true;
            this.lstSiparisDetaylari.Location = new System.Drawing.Point(12, 299);
            this.lstSiparisDetaylari.Name = "lstSiparisDetaylari";
            this.lstSiparisDetaylari.Size = new System.Drawing.Size(776, 251);
            this.lstSiparisDetaylari.TabIndex = 1;
            this.lstSiparisDetaylari.SelectedIndexChanged += new System.EventHandler(this.lstSiparisDetaylari_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siparişler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sipariş Detayları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ARA TOPLAM:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(112, 562);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(0, 13);
            this.lblAraToplam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genel Toplam:";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(112, 592);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sepetteki Ürün Sayısı:";
            // 
            // lblSepettekiUrunSayisi
            // 
            this.lblSepettekiUrunSayisi.AutoSize = true;
            this.lblSepettekiUrunSayisi.Location = new System.Drawing.Point(147, 627);
            this.lblSepettekiUrunSayisi.Name = "lblSepettekiUrunSayisi";
            this.lblSepettekiUrunSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblSepettekiUrunSayisi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sepetteki detay sayısı:";
            // 
            // lblSepettekiDetaySayisi
            // 
            this.lblSepettekiDetaySayisi.AutoSize = true;
            this.lblSepettekiDetaySayisi.Location = new System.Drawing.Point(147, 661);
            this.lblSepettekiDetaySayisi.Name = "lblSepettekiDetaySayisi";
            this.lblSepettekiDetaySayisi.Size = new System.Drawing.Size(0, 13);
            this.lblSepettekiDetaySayisi.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 732);
            this.Controls.Add(this.lblSepettekiDetaySayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSepettekiUrunSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisDetaylari);
            this.Controls.Add(this.lstSiparisler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.ListBox lstSiparisDetaylari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSepettekiUrunSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSepettekiDetaySayisi;
    }
}