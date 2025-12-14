using CordysExam_ProductSalesAdmin.Models;
using Microsoft.EntityFrameworkCore;


namespace CordysExam_ProductSalesAdmin
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialisation
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using var db = new AppDbContext();
            productsGrid.DataSource = db.Products.ToList();
        }
        #endregion

        #region Product Buttons
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();
                db.Products.Add(form.Product);
                db.SaveChanges();
                LoadProducts();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            var product = (Product)productsGrid.CurrentRow.DataBoundItem;
            var form = new ProductForm(product);

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();
                db.Products.Update(form.Product);
                db.SaveChanges();
                LoadProducts();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            var product = (Product)productsGrid.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                db.Products.Remove(product);
                db.SaveChanges();
                LoadProducts();
            }
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        #endregion

    }
}
