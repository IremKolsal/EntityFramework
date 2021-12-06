
namespace o1_CodeFirstOBS
{
    partial class FakulteyeBolumEklemeEkrani
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
            this.cmbFakulteler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFakulteler
            // 
            this.cmbFakulteler.FormattingEnabled = true;
            this.cmbFakulteler.Location = new System.Drawing.Point(222, 50);
            this.cmbFakulteler.Name = "cmbFakulteler";
            this.cmbFakulteler.Size = new System.Drawing.Size(412, 21);
            this.cmbFakulteler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülteyi Seçiniz";
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(222, 115);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(412, 20);
            this.txtBolumAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bolum adı giriniz:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(512, 156);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FakulteyeBolumEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 239);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFakulteler);
            this.Name = "FakulteyeBolumEklemeEkrani";
            this.Text = "FakulteyeBolumEklemeEkrani";
            this.Load += new System.EventHandler(this.FakulteyeBolumEklemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFakulteler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
    }
}