namespace SiparisVer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNakliye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numIndirim = new System.Windows.Forms.NumericUpDown();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lsvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(720, 384);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(245, 28);
            this.cmbMusteri.TabIndex = 4;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(720, 434);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(245, 28);
            this.cmbPersonel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel";
            // 
            // cmbNakliye
            // 
            this.cmbNakliye.FormattingEnabled = true;
            this.cmbNakliye.Location = new System.Drawing.Point(720, 479);
            this.cmbNakliye.Name = "cmbNakliye";
            this.cmbNakliye.Size = new System.Drawing.Size(245, 28);
            this.cmbNakliye.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nakliye";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(14, 358);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(150, 27);
            this.numAdet.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "İndirim";
            // 
            // numIndirim
            // 
            this.numIndirim.Location = new System.Drawing.Point(170, 358);
            this.numIndirim.Name = "numIndirim";
            this.numIndirim.Size = new System.Drawing.Size(150, 27);
            this.numIndirim.TabIndex = 2;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 12);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 29;
            this.dgvUrunler.Size = new System.Drawing.Size(1066, 320);
            this.dgvUrunler.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(326, 358);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lsvUrunler
            // 
            this.lsvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvUrunler.FullRowSelect = true;
            this.lsvUrunler.GridLines = true;
            this.lsvUrunler.Location = new System.Drawing.Point(12, 391);
            this.lsvUrunler.Name = "lsvUrunler";
            this.lsvUrunler.Size = new System.Drawing.Size(584, 296);
            this.lsvUrunler.TabIndex = 12;
            this.lsvUrunler.UseCompatibleStateImageBehavior = false;
            this.lsvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İndirim";
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.Location = new System.Drawing.Point(642, 513);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(323, 70);
            this.btnSiparisOnayla.TabIndex = 7;
            this.btnSiparisOnayla.Text = "Siparişi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 699);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.lsvUrunler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numIndirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.cmbNakliye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbMusteri;
        private ComboBox cmbPersonel;
        private Label label2;
        private ComboBox cmbNakliye;
        private Label label3;
        private NumericUpDown numAdet;
        private Label label4;
        private Label label5;
        private NumericUpDown numIndirim;
        private DataGridView dgvUrunler;
        private Button btnEkle;
        private ListView lsvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnSiparisOnayla;
    }
}