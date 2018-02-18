namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCategori = new System.Windows.Forms.GroupBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.Kategori = new System.Windows.Forms.Label();
            this.labr = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cbxCategori = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPruducNAme = new System.Windows.Forms.TextBox();
            this.cbxCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbrQuantity = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxupQuanty = new System.Windows.Forms.TextBox();
            this.tbxupStock = new System.Windows.Forms.TextBox();
            this.tbxupUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxupCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxupPRoductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCategori.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 107);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpCategori
            // 
            this.grpCategori.Controls.Add(this.cbxCategori);
            this.grpCategori.Controls.Add(this.Kategori);
            this.grpCategori.Location = new System.Drawing.Point(12, 22);
            this.grpCategori.Name = "grpCategori";
            this.grpCategori.Size = new System.Drawing.Size(837, 83);
            this.grpCategori.TabIndex = 1;
            this.grpCategori.TabStop = false;
            this.grpCategori.Text = "Kategori";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.txtProduct);
            this.grpProduct.Controls.Add(this.labr);
            this.grpProduct.Location = new System.Drawing.Point(12, 111);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(837, 84);
            this.grpProduct.TabIndex = 2;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Ürün";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(7, 38);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(46, 13);
            this.Kategori.TabIndex = 0;
            this.Kategori.Text = "Kategori";
            // 
            // labr
            // 
            this.labr.AutoSize = true;
            this.labr.Location = new System.Drawing.Point(7, 34);
            this.labr.Name = "labr";
            this.labr.Size = new System.Drawing.Size(30, 13);
            this.labr.TabIndex = 0;
            this.labr.Text = "Ürün";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(101, 34);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(240, 20);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // cbxCategori
            // 
            this.cbxCategori.FormattingEnabled = true;
            this.cbxCategori.Location = new System.Drawing.Point(101, 30);
            this.cbxCategori.Name = "cbxCategori";
            this.cbxCategori.Size = new System.Drawing.Size(240, 21);
            this.cbxCategori.TabIndex = 2;
            this.cbxCategori.SelectedIndexChanged += new System.EventHandler(this.cbxCategori_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.tbrQuantity);
            this.groupBox1.Controls.Add(this.tbxStock);
            this.groupBox1.Controls.Add(this.tbxUnitPrice);
            this.groupBox1.Controls.Add(this.cbxCategoryID);
            this.groupBox1.Controls.Add(this.tbxPruducNAme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " KAtegori Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Birim Adı";
            // 
            // tbxPruducNAme
            // 
            this.tbxPruducNAme.Location = new System.Drawing.Point(101, 13);
            this.tbxPruducNAme.Name = "tbxPruducNAme";
            this.tbxPruducNAme.Size = new System.Drawing.Size(179, 20);
            this.tbxPruducNAme.TabIndex = 5;
            // 
            // cbxCategoryID
            // 
            this.cbxCategoryID.FormattingEnabled = true;
            this.cbxCategoryID.Location = new System.Drawing.Point(101, 50);
            this.cbxCategoryID.Name = "cbxCategoryID";
            this.cbxCategoryID.Size = new System.Drawing.Size(179, 21);
            this.cbxCategoryID.TabIndex = 6;
            this.cbxCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryID_SelectedIndexChanged);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(101, 78);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(179, 20);
            this.tbxUnitPrice.TabIndex = 7;
            this.tbxUnitPrice.Text = " ";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(101, 105);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(179, 20);
            this.tbxStock.TabIndex = 8;
            // 
            // tbrQuantity
            // 
            this.tbrQuantity.Location = new System.Drawing.Point(101, 126);
            this.tbrQuantity.Name = "tbrQuantity";
            this.tbrQuantity.Size = new System.Drawing.Size(179, 20);
            this.tbrQuantity.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(311, 123);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = " Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxupQuanty);
            this.groupBox2.Controls.Add(this.tbxupStock);
            this.groupBox2.Controls.Add(this.tbxupUnitPrice);
            this.groupBox2.Controls.Add(this.cbxupCategoryId);
            this.groupBox2.Controls.Add(this.tbxupPRoductName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(448, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update);
            // 
            // tbxupQuanty
            // 
            this.tbxupQuanty.Location = new System.Drawing.Point(101, 126);
            this.tbxupQuanty.Name = "tbxupQuanty";
            this.tbxupQuanty.Size = new System.Drawing.Size(179, 20);
            this.tbxupQuanty.TabIndex = 9;
            // 
            // tbxupStock
            // 
            this.tbxupStock.Location = new System.Drawing.Point(101, 105);
            this.tbxupStock.Name = "tbxupStock";
            this.tbxupStock.Size = new System.Drawing.Size(179, 20);
            this.tbxupStock.TabIndex = 8;
            // 
            // tbxupUnitPrice
            // 
            this.tbxupUnitPrice.Location = new System.Drawing.Point(101, 78);
            this.tbxupUnitPrice.Name = "tbxupUnitPrice";
            this.tbxupUnitPrice.Size = new System.Drawing.Size(179, 20);
            this.tbxupUnitPrice.TabIndex = 7;
            this.tbxupUnitPrice.Text = " ";
            // 
            // cbxupCategoryId
            // 
            this.cbxupCategoryId.FormattingEnabled = true;
            this.cbxupCategoryId.Location = new System.Drawing.Point(101, 50);
            this.cbxupCategoryId.Name = "cbxupCategoryId";
            this.cbxupCategoryId.Size = new System.Drawing.Size(179, 21);
            this.cbxupCategoryId.TabIndex = 6;
            this.cbxupCategoryId.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryID_SelectedIndexChanged);
            // 
            // tbxupPRoductName
            // 
            this.tbxupPRoductName.Location = new System.Drawing.Point(101, 13);
            this.tbxupPRoductName.Name = "tbxupPRoductName";
            this.tbxupPRoductName.Size = new System.Drawing.Size(179, 20);
            this.tbxupPRoductName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = " Birim Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = " Stok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = " Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = " KAtegori Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(774, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 524);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpCategori);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCategori.ResumeLayout(false);
            this.grpCategori.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCategori;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label labr;
        private System.Windows.Forms.ComboBox cbxCategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbrQuantity;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryID;
        private System.Windows.Forms.TextBox tbxPruducNAme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxupQuanty;
        private System.Windows.Forms.TextBox tbxupStock;
        private System.Windows.Forms.TextBox tbxupUnitPrice;
        private System.Windows.Forms.ComboBox cbxupCategoryId;
        private System.Windows.Forms.TextBox tbxupPRoductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
    }
}

