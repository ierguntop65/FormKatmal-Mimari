using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Concreate;
namespace UI
{
    using BLL.Abstract;
    using BLL.DependencyResolvers.Ninject;

    using DAL.Concreate.Entityfreamwork;
    using DAL.Concreate.NHibernate;

    using Entities.Concreate;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productManager = InstanceFactory.GetInstance<IProductManager>();
            _categoryManager = InstanceFactory.GetInstance<ICategoryManager>();
        }

        private IProductManager _productManager;

        private ICategoryManager _categoryManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadProduct();
            LoadCategories();
        }

        private void LoadCategories()
        {
            this.cbxCategori.DataSource = this._categoryManager.GetAll();
            this.cbxCategori.DisplayMember = "CategoryName";
            this.cbxCategori.ValueMember = "CategoryId";

            this.cbxCategoryID.DataSource = this._categoryManager.GetAll();
            this.cbxCategoryID.DisplayMember = "CategoryName";
            this.cbxCategoryID.ValueMember = "CategoryId";

            this.cbxupCategoryId.DataSource = this._categoryManager.GetAll();
            this.cbxupCategoryId.DisplayMember = "CategoryName";
            this.cbxupCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            this.dataGridView1.DataSource = this._productManager.GetAll();
        }

        private void cbxCategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = this._productManager.GetProductsByCategory(Convert.ToInt32(cbxCategori.SelectedValue));
            }
            catch  
            {
                 
            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtProduct.Text))
            {
                this.dataGridView1.DataSource = this._productManager.GetProductsByProductName(this.txtProduct.Text);
            }
            else
            {
                LoadProduct();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this._productManager.Add(new Product
                                             {
                                                 ProductName = this.tbxPruducNAme.Text,
                                                 CategoryID = (int)this.cbxCategoryID.SelectedValue,
                                                 QuantityPerUnit = this.tbrQuantity.Text,
                                                 UnitPrice = Convert.ToDecimal(this.tbxUnitPrice.Text),
                                                 UnitsInStock = Convert.ToInt16(this.tbxStock.Text)
                                             });
                LoadProduct();
                MessageBox.Show("Ürün Eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void Update(object sender, EventArgs e)
        {
            try
            {

                this._productManager.Update(new Product
                                                {
                                                    ProductID = (int)this.dataGridView1.CurrentRow.Cells[0].Value,
                                                    ProductName = this.tbxupPRoductName.Text,
                                                    CategoryID = (int)this.cbxupCategoryId.SelectedValue,
                                                    QuantityPerUnit = this.tbxupQuanty.Text,
                                                    UnitPrice = Convert.ToDecimal(this.tbxupUnitPrice.Text),
                                                    UnitsInStock = Convert.ToInt16(this.tbxupStock.Text)
                                                });
                LoadProduct();
                MessageBox.Show("Ürün Güncellendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
        private void cbxCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbxupPRoductName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.cbxCategoryID.SelectedValue = this.dataGridView1.CurrentRow.Cells[2].Value;
            this.tbxupUnitPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.tbxupQuanty.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.tbxupStock.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dataGridViewRow = this.dataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                try
                {
                    _productManager.Delete(
                        new Product
                            {
                            ProductID = Convert.ToInt32(dataGridViewRow.Cells[0].Value)
                        });
                    LoadProduct();
                    MessageBox.Show("Ürün silindi");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    
                }
            }
          
        }
    }
}
