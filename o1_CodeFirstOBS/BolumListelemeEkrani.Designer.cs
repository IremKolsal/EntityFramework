
namespace o1_CodeFirstOBS
{
    partial class BolumListelemeEkrani
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
            this.components = new System.ComponentModel.Container();
            this.lstvBolumler = new System.Windows.Forms.ListView();
            this.lviId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviFakulteAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviBolumAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviCreatedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviIsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvBolumler
            // 
            this.lstvBolumler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviId,
            this.lviFakulteAdi,
            this.lviBolumAdi,
            this.lviCreatedDate,
            this.lviIsActive});
            this.lstvBolumler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvBolumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvBolumler.FullRowSelect = true;
            this.lstvBolumler.GridLines = true;
            this.lstvBolumler.HideSelection = false;
            this.lstvBolumler.Location = new System.Drawing.Point(0, 0);
            this.lstvBolumler.MultiSelect = false;
            this.lstvBolumler.Name = "lstvBolumler";
            this.lstvBolumler.Size = new System.Drawing.Size(800, 450);
            this.lstvBolumler.TabIndex = 0;
            this.lstvBolumler.UseCompatibleStateImageBehavior = false;
            this.lstvBolumler.View = System.Windows.Forms.View.Details;
            // 
            // lviId
            // 
            this.lviId.Text = "BolumID";
            this.lviId.Width = 53;
            // 
            // lviFakulteAdi
            // 
            this.lviFakulteAdi.Text = "Fakulte Adı";
            this.lviFakulteAdi.Width = 236;
            // 
            // lviBolumAdi
            // 
            this.lviBolumAdi.Text = "Bolum Adı";
            this.lviBolumAdi.Width = 219;
            // 
            // lviCreatedDate
            // 
            this.lviCreatedDate.Text = "Oluşturulma Tarihi";
            this.lviCreatedDate.Width = 162;
            // 
            // lviIsActive
            // 
            this.lviIsActive.Text = "Aktif Mi";
            this.lviIsActive.Width = 96;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // BolumListelemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvBolumler);
            this.Name = "BolumListelemeEkrani";
            this.Text = "BolumListelemeEkrani";
            this.Load += new System.EventHandler(this.BolumListelemeEkrani_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader lviId;
        private System.Windows.Forms.ColumnHeader lviFakulteAdi;
        private System.Windows.Forms.ColumnHeader lviBolumAdi;
        private System.Windows.Forms.ColumnHeader lviCreatedDate;
        private System.Windows.Forms.ColumnHeader lviIsActive;
        private System.Windows.Forms.ListView lstvBolumler;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}