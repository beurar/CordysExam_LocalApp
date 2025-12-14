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
using System.Xml.Linq;

namespace CordysExam_ProductSalesAdmin
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }

        public ProductForm()
        {
            InitializeComponent();
            Product = new Product();
        }

        public ProductForm(Product product)
        {
            InitializeComponent();
            Product = product;

            txtName.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out var price))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            Product.Description = txtName.Text.Trim();
            Product.Price = price;
        }

    }
}
