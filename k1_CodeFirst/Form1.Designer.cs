
namespace k1_CodeFirst
{
    partial class Form1
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
            this.btnKategoriGetir = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnSiparisleriGetir = new System.Windows.Forms.Button();
            this.btnKargolariGetir = new System.Windows.Forms.Button();
            this.btnSiparisDetaylariniGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriGetir
            // 
            this.btnKategoriGetir.Location = new System.Drawing.Point(82, 33);
            this.btnKategoriGetir.Name = "btnKategoriGetir";
            this.btnKategoriGetir.Size = new System.Drawing.Size(259, 92);
            this.btnKategoriGetir.TabIndex = 0;
            this.btnKategoriGetir.Text = "Kategorileri Getir";
            this.btnKategoriGetir.UseVisualStyleBackColor = true;
            this.btnKategoriGetir.Click += new System.EventHandler(this.btnKategoriGetir_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(55, 145);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(612, 381);
            this.lstSonuc.TabIndex = 1;
            // 
            // btnSiparisleriGetir
            // 
            this.btnSiparisleriGetir.Location = new System.Drawing.Point(363, 33);
            this.btnSiparisleriGetir.Name = "btnSiparisleriGetir";
            this.btnSiparisleriGetir.Size = new System.Drawing.Size(280, 44);
            this.btnSiparisleriGetir.TabIndex = 2;
            this.btnSiparisleriGetir.Text = "Siparişleri Getir";
            this.btnSiparisleriGetir.UseVisualStyleBackColor = true;
            this.btnSiparisleriGetir.Click += new System.EventHandler(this.btnSiparisleriGetir_Click);
            // 
            // btnKargolariGetir
            // 
            this.btnKargolariGetir.Location = new System.Drawing.Point(363, 83);
            this.btnKargolariGetir.Name = "btnKargolariGetir";
            this.btnKargolariGetir.Size = new System.Drawing.Size(280, 42);
            this.btnKargolariGetir.TabIndex = 3;
            this.btnKargolariGetir.Text = "Kargoları Getir";
            this.btnKargolariGetir.UseVisualStyleBackColor = true;
            this.btnKargolariGetir.Click += new System.EventHandler(this.btnKargolariGetir_Click);
            // 
            // btnSiparisDetaylariniGetir
            // 
            this.btnSiparisDetaylariniGetir.Location = new System.Drawing.Point(649, 33);
            this.btnSiparisDetaylariniGetir.Name = "btnSiparisDetaylariniGetir";
            this.btnSiparisDetaylariniGetir.Size = new System.Drawing.Size(280, 44);
            this.btnSiparisDetaylariniGetir.TabIndex = 4;
            this.btnSiparisDetaylariniGetir.Text = "Sipariş Detaylarını Getir";
            this.btnSiparisDetaylariniGetir.UseVisualStyleBackColor = true;
            this.btnSiparisDetaylariniGetir.Click += new System.EventHandler(this.btnSiparisDetaylariniGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 560);
            this.Controls.Add(this.btnSiparisDetaylariniGetir);
            this.Controls.Add(this.btnKargolariGetir);
            this.Controls.Add(this.btnSiparisleriGetir);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnKategoriGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriGetir;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnSiparisleriGetir;
        private System.Windows.Forms.Button btnKargolariGetir;
        private System.Windows.Forms.Button btnSiparisDetaylariniGetir;
    }
}

