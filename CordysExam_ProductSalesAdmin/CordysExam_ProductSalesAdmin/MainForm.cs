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
            LoadStores();
            LoadSales();
        }

        private void LoadProducts()
        {
            using var db = new AppDbContext();

            productsGrid.AutoGenerateColumns = false;
            productsGrid.Columns.Clear();

            productsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "ID",
                ReadOnly = true
            });

            productsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Product"
            });

            productsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Currency
            });

            productsGrid.DataSource = db.Products.ToList();
        }



        private void LoadStores()
        {
            using var db = new AppDbContext();

            storesGrid.AutoGenerateColumns = false;
            storesGrid.Columns.Clear();

            storesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StoreID",
                HeaderText = "ID",
                ReadOnly = true
            });

            storesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Store Name"
            });

            storesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Address"
            });

            storesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tel",
                HeaderText = "Telephone"
            });

            storesGrid.DataSource = db.Stores.ToList();
        }



        private void LoadSales()
        {
            using var db = new AppDbContext();

            salesGrid.AutoGenerateColumns = false;
            salesGrid.Columns.Clear();

            var salesList = db.ProductSales
                .Include(s => s.Product)
                .Include(s => s.Store)
                .ToList();

            salesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleID",
                HeaderText = "ID",
                ReadOnly = true
            });

            // Display product name
            var productCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Product",
                ReadOnly = true
            };
            salesGrid.Columns.Add(productCol);

            // Display store name
            var storeCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Store",
                ReadOnly = true
            };
            salesGrid.Columns.Add(storeCol);

            salesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleDate",
                HeaderText = "Date"
            });

            salesGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity"
            });

            salesGrid.DataSource = salesList;

            // Fill Product & Store columns
            salesGrid.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return; // skip header

                var row = salesGrid.Rows[e.RowIndex].DataBoundItem as ProductSale;
                if (row == null) return;

                if (salesGrid.Columns[e.ColumnIndex].HeaderText == "Product")
                    e.Value = row.Product.Description;

                if (salesGrid.Columns[e.ColumnIndex].HeaderText == "Store")
                    e.Value = row.Store.Name;
            };

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

            using var db = new AppDbContext();
            bool hasSales = db.ProductSales.Any(s => s.ProductId == product.ProductId);

            if (hasSales)
            {
                MessageBox.Show
                (
                    "Cannot delete this product because it has sales records.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
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

        #region Stores Buttons
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var form = new StoreForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();
                db.Stores.Add(form.Store);
                db.SaveChanges();
                LoadStores();
            }
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if (storesGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a store first.");
                return;
            }

            var store = (Store)storesGrid.CurrentRow.DataBoundItem;
            var form = new StoreForm(store);

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();

                // Attach the edited entity and mark as modified
                db.Stores.Attach(form.Store);
                db.Entry(form.Store).State = EntityState.Modified;

                db.SaveChanges();
                LoadStores();
            }
        }



        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            if (storesGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a store first.");
                return;
            }

            var store = (Store)storesGrid.CurrentRow.DataBoundItem;

            using var db = new AppDbContext();
            bool hasSales = db.ProductSales.Any(s => s.StoreId == store.StoreId);

            if (hasSales)
            {
                MessageBox.Show(
                    "Cannot delete this store because it has sales records.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this store?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                db.Stores.Remove(store);
                db.SaveChanges();
                LoadStores();
            }
        }


        private void btnRefreshStores_Click(object sender, EventArgs e)
        {
            LoadStores();
        }


        #endregion

        #region Sales Buttons
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            var form = new SaleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();
                db.ProductSales.Add(form.ProductSale);
                db.SaveChanges();
                LoadSales();
            }
        }

        private void btnEditSale_Click(object sender, EventArgs e)
        {
            if (salesGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }

            // Get the selected sale's ID
            var selectedSale = (ProductSale)salesGrid.CurrentRow.DataBoundItem;
            int saleId = selectedSale.SaleId;

            // Open the edit form
            using var db = new AppDbContext();
            var sale = db.ProductSales
                         .Include(s => s.Product)
                         .Include(s => s.Store)
                         .FirstOrDefault(s => s.SaleId == saleId);

            if (sale == null)
            {
                MessageBox.Show("Sale not found in the database.");
                return;
            }

            var form = new SaleForm(sale);

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Update the sale entity with new values
                sale.ProductId = form.ProductSale.ProductId;
                sale.StoreId = form.ProductSale.StoreId;
                sale.SaleDate = form.ProductSale.SaleDate;
                sale.Quantity = form.ProductSale.Quantity;

                db.SaveChanges();

                LoadSales();
            }
        }



        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            if (salesGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }

            var sale = (ProductSale)salesGrid.CurrentRow.DataBoundItem;
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this sale?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                db.ProductSales.Remove(sale);
                db.SaveChanges();
                LoadSales();
            }
        }

        private void btnRefreshSales_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        #endregion

        #region Double-Clicks

        private void productsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // clicked header
            btnEditProduct_Click(sender, EventArgs.Empty); // always edit the clicked row
        }

        private void storesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnEditStore_Click(sender, EventArgs.Empty);
        }

        private void salesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnEditSale_Click(sender, EventArgs.Empty);
        }

        #endregion

    }
}
