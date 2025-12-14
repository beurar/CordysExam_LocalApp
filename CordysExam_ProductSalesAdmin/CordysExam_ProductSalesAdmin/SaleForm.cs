using CordysExam_ProductSalesAdmin.Models;
using Microsoft.EntityFrameworkCore;
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
            this.Text = "New Sale";
        }

        public SaleForm(ProductSale sale)
        {
            InitializeComponent();
            ProductSale = sale;
            LoadCombos();
            this.Text = "Edit Sale";

            cmbProduct.SelectedValue = sale.ProductId;
            cmbStore.SelectedValue = sale.StoreId;
            dtpDate.Value = ProductSale.SaleDate.ToDateTime(TimeOnly.MinValue);
            numQuantity.Value = sale.Quantity;
        }

        private void LoadCombos()
        {
            using var db = new AppDbContext();

            cmbProduct.DataSource = db.Products.AsNoTracking().ToList();
            cmbProduct.DisplayMember = "Description";
            cmbProduct.ValueMember = "ProductId";

            cmbStore.DataSource = db.Stores.AsNoTracking().ToList();
            cmbStore.DisplayMember = "Name";
            cmbStore.ValueMember = "StoreId";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductSale.ProductId = (int)cmbProduct.SelectedValue;
            ProductSale.StoreId = (int)cmbStore.SelectedValue;
            ProductSale.SaleDate = DateOnly.FromDateTime(dtpDate.Value);
            ProductSale.Quantity = (int)numQuantity.Value;

            this.DialogResult = DialogResult.OK;
        }
    }
}
