using CordysExam_ProductSalesAdmin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordysExam_ProductSalesAdmin
{
    public partial class SaleForm : Form
    {
        public ProductSale ProductSale { get; private set; }

        public SaleForm()
        {
            InitializeComponent();
            ProductSale = new ProductSale();
            LoadCombos();
        }

        public SaleForm(ProductSale sale)
        {
            InitializeComponent();
            ProductSale = sale;
            LoadCombos();

            cmbProduct.SelectedItem = sale.Product;
            cmbStore.SelectedItem = sale.Store;
            dtpDate.Value = ProductSale.SaleDate.ToDateTime(TimeOnly.MinValue);
            numQuantity.Value = sale.Quantity;
        }

        private void LoadCombos()
        {
            using var db = new AppDbContext();
            cmbProduct.DataSource = db.Products.ToList();
            cmbProduct.DisplayMember = "Description";
            cmbProduct.ValueMember = "ProductId";

            cmbStore.DataSource = db.Stores.ToList();
            cmbStore.DisplayMember = "Name";
            cmbStore.ValueMember = "StoreId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductSale.ProductId = ((Product)cmbProduct.SelectedItem).ProductId;
            ProductSale.StoreId = ((Store)cmbStore.SelectedItem).StoreId;
            ProductSale.SaleDate = DateOnly.FromDateTime(dtpDate.Value);
            ProductSale.Quantity = (int)numQuantity.Value;

            Close();
        }
    }
}
