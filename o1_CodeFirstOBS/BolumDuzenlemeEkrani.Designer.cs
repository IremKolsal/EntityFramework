﻿
namespace o1_CodeFirstOBS
{
    partial class BolumDuzenlemeEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.cmbFakulteler = new System.Windows.Forms.ComboBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.txtFakulteAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bolum adı giriniz:";
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(204, 168);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(412, 20);
            this.txtBolumAdi.TabIndex = 15;
            // 
            // cmbFakulteler
            // 
            this.cmbFakulteler.FormattingEnabled = true;
            this.cmbFakulteler.Location = new System.Drawing.Point(204, 103);
            this.cmbFakulteler.Name = "cmbFakulteler";
            this.cmbFakulteler.Size = new System.Drawing.Size(412, 21);
            this.cmbFakulteler.TabIndex = 14;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(541, 210);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 13;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtFakulteAdi
            // 
            this.txtFakulteAdi.Location = new System.Drawing.Point(228, 103);
            this.txtFakulteAdi.Name = "txtFakulteAdi";
            this.txtFakulteAdi.Size = new System.Drawing.Size(326, 20);
            this.txtFakulteAdi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fakülte Adı:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(204, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // BolumDuzenlemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.cmbFakulteler);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.txtFakulteAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "BolumDuzenlemeEkrani";
            this.Text = "BolumDuzenlemeEkrani";
            this.Load += new System.EventHandler(this.BolumDuzenlemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.ComboBox cmbFakulteler;
        private System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.TextBox txtFakulteAdi;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}