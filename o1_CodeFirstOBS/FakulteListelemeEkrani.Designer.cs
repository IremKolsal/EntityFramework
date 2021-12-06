
namespace o1_CodeFirstOBS
{
    partial class FakulteListelemeEkrani
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
            this.lstvFakulteler = new System.Windows.Forms.ListView();
            this.lviId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviFakulteAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviCreatedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviIsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvFakulteler
            // 
            this.lstvFakulteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviId,
            this.lviFakulteAdi,
            this.lviCreatedDate,
            this.lviIsActive});
            this.lstvFakulteler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvFakulteler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvFakulteler.FullRowSelect = true;
            this.lstvFakulteler.GridLines = true;
            this.lstvFakulteler.HideSelection = false;
            this.lstvFakulteler.Location = new System.Drawing.Point(0, 0);
            this.lstvFakulteler.MultiSelect = false;
            this.lstvFakulteler.Name = "lstvFakulteler";
            this.lstvFakulteler.Size = new System.Drawing.Size(758, 481);
            this.lstvFakulteler.TabIndex = 0;
            this.lstvFakulteler.UseCompatibleStateImageBehavior = false;
            this.lstvFakulteler.View = System.Windows.Forms.View.Details;
            // 
            // lviId
            // 
            this.lviId.Text = "ID";
            // 
            // lviFakulteAdi
            // 
            this.lviFakulteAdi.Text = "Fakulte Adı";
            this.lviFakulteAdi.Width = 172;
            // 
            // lviCreatedDate
            // 
            this.lviCreatedDate.Text = "Oluşturma Tarihi";
            this.lviCreatedDate.Width = 182;
            // 
            // lviIsActive
            // 
            this.lviIsActive.Text = "Aktif Mi";
            this.lviIsActive.Width = 187;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duzenleToolStripMenuItem.Text = "Duzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // FakulteListelemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 481);
            this.Controls.Add(this.lstvFakulteler);
            this.Name = "FakulteListelemeEkrani";
            this.Text = "FakulteListelemeEkrani";
            this.Load += new System.EventHandler(this.FakulteListelemeEkrani_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvFakulteler;
        private System.Windows.Forms.ColumnHeader lviId;
        private System.Windows.Forms.ColumnHeader lviFakulteAdi;
        private System.Windows.Forms.ColumnHeader lviCreatedDate;
        private System.Windows.Forms.ColumnHeader lviIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}