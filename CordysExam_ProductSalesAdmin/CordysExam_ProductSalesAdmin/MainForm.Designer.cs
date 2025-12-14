namespace CordysExam_ProductSalesAdmin
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabProducts = new TabPage();
            panel3 = new Panel();
            btnRefreshProduct = new Button();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            productsGrid = new DataGridView();
            tabSales = new TabPage();
            panel2 = new Panel();
            btnRefreshSales = new Button();
            btnDeleteSale = new Button();
            btnEditSale = new Button();
            btnAddSale = new Button();
            salesGrid = new DataGridView();
            tabStores = new TabPage();
            panel1 = new Panel();
            btnRefreshStores = new Button();
            btnDeleteStore = new Button();
            btnEditStore = new Button();
            btnAddStore = new Button();
            storesGrid = new DataGridView();
            tabControl1.SuspendLayout();
            tabProducts.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            tabSales.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesGrid).BeginInit();
            tabStores.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storesGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabSales);
            tabControl1.Controls.Add(tabStores);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(panel3);
            tabProducts.Controls.Add(productsGrid);
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(1049, 422);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnRefreshProduct);
            panel3.Controls.Add(btnDeleteProduct);
            panel3.Controls.Add(btnEditProduct);
            panel3.Controls.Add(btnAddProduct);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 29);
            panel3.TabIndex = 2;
            // 
            // btnRefreshProduct
            // 
            btnRefreshProduct.Location = new Point(246, 3);
            btnRefreshProduct.Name = "btnRefreshProduct";
            btnRefreshProduct.Size = new Size(75, 23);
            btnRefreshProduct.TabIndex = 3;
            btnRefreshProduct.Text = "Refresh";
            btnRefreshProduct.UseVisualStyleBackColor = true;
            btnRefreshProduct.Click += btnRefreshProducts_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProduct.Location = new Point(963, 3);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(84, 3);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 1;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(3, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToDeleteRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Dock = DockStyle.Fill;
            productsGrid.Location = new Point(3, 3);
            productsGrid.MultiSelect = false;
            productsGrid.Name = "productsGrid";
            productsGrid.ReadOnly = true;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.Size = new Size(1043, 416);
            productsGrid.TabIndex = 1;
            productsGrid.CellDoubleClick += productsGrid_CellDoubleClick;
            // 
            // tabSales
            // 
            tabSales.Controls.Add(panel2);
            tabSales.Controls.Add(salesGrid);
            tabSales.Location = new Point(4, 24);
            tabSales.Name = "tabSales";
            tabSales.Padding = new Padding(3);
            tabSales.Size = new Size(1049, 422);
            tabSales.TabIndex = 1;
            tabSales.Text = "Sales";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(btnRefreshSales);
            panel2.Controls.Add(btnDeleteSale);
            panel2.Controls.Add(btnEditSale);
            panel2.Controls.Add(btnAddSale);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 29);
            panel2.TabIndex = 3;
            // 
            // btnRefreshSales
            // 
            btnRefreshSales.Location = new Point(246, 3);
            btnRefreshSales.Name = "btnRefreshSales";
            btnRefreshSales.Size = new Size(75, 23);
            btnRefreshSales.TabIndex = 3;
            btnRefreshSales.Text = "Refresh";
            btnRefreshSales.UseVisualStyleBackColor = true;
            btnRefreshSales.Click += btnRefreshSales_Click;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteSale.Location = new Point(963, 3);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new Size(75, 23);
            btnDeleteSale.TabIndex = 2;
            btnDeleteSale.Text = "Delete";
            btnDeleteSale.UseVisualStyleBackColor = true;
            btnDeleteSale.Click += btnDeleteSale_Click;
            // 
            // btnEditSale
            // 
            btnEditSale.Location = new Point(84, 3);
            btnEditSale.Name = "btnEditSale";
            btnEditSale.Size = new Size(75, 23);
            btnEditSale.TabIndex = 1;
            btnEditSale.Text = "Edit";
            btnEditSale.UseVisualStyleBackColor = true;
            btnEditSale.Click += btnEditSale_Click;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(3, 3);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(75, 23);
            btnAddSale.TabIndex = 0;
            btnAddSale.Text = "Add";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // salesGrid
            // 
            salesGrid.AllowUserToAddRows = false;
            salesGrid.AllowUserToDeleteRows = false;
            salesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGrid.Dock = DockStyle.Fill;
            salesGrid.Location = new Point(3, 3);
            salesGrid.MultiSelect = false;
            salesGrid.Name = "salesGrid";
            salesGrid.ReadOnly = true;
            salesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesGrid.Size = new Size(1043, 416);
            salesGrid.TabIndex = 1;
            salesGrid.CellDoubleClick += salesGrid_CellDoubleClick;
            // 
            // tabStores
            // 
            tabStores.Controls.Add(panel1);
            tabStores.Controls.Add(storesGrid);
            tabStores.Location = new Point(4, 24);
            tabStores.Name = "tabStores";
            tabStores.Padding = new Padding(3);
            tabStores.Size = new Size(1049, 422);
            tabStores.TabIndex = 2;
            tabStores.Text = "Stores";
            tabStores.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnRefreshStores);
            panel1.Controls.Add(btnDeleteStore);
            panel1.Controls.Add(btnEditStore);
            panel1.Controls.Add(btnAddStore);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 29);
            panel1.TabIndex = 3;
            // 
            // btnRefreshStores
            // 
            btnRefreshStores.Location = new Point(246, 3);
            btnRefreshStores.Name = "btnRefreshStores";
            btnRefreshStores.Size = new Size(75, 23);
            btnRefreshStores.TabIndex = 3;
            btnRefreshStores.Text = "Refresh";
            btnRefreshStores.UseVisualStyleBackColor = true;
            btnRefreshStores.Click += btnRefreshStores_Click;
            // 
            // btnDeleteStore
            // 
            btnDeleteStore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteStore.Location = new Point(963, 3);
            btnDeleteStore.Name = "btnDeleteStore";
            btnDeleteStore.Size = new Size(75, 23);
            btnDeleteStore.TabIndex = 2;
            btnDeleteStore.Text = "Delete";
            btnDeleteStore.UseVisualStyleBackColor = true;
            btnDeleteStore.Click += btnDeleteStore_Click;
            // 
            // btnEditStore
            // 
            btnEditStore.Location = new Point(84, 3);
            btnEditStore.Name = "btnEditStore";
            btnEditStore.Size = new Size(75, 23);
            btnEditStore.TabIndex = 1;
            btnEditStore.Text = "Edit";
            btnEditStore.UseVisualStyleBackColor = true;
            btnEditStore.Click += btnEditStore_Click;
            // 
            // btnAddStore
            // 
            btnAddStore.Location = new Point(3, 3);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(75, 23);
            btnAddStore.TabIndex = 0;
            btnAddStore.Text = "Add";
            btnAddStore.UseVisualStyleBackColor = true;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // storesGrid
            // 
            storesGrid.AllowUserToAddRows = false;
            storesGrid.AllowUserToDeleteRows = false;
            storesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storesGrid.Dock = DockStyle.Fill;
            storesGrid.Location = new Point(3, 3);
            storesGrid.MultiSelect = false;
            storesGrid.Name = "storesGrid";
            storesGrid.ReadOnly = true;
            storesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storesGrid.Size = new Size(1043, 416);
            storesGrid.TabIndex = 1;
            storesGrid.CellDoubleClick += storesGrid_CellDoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Cordys Exam - Admin Suite";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabProducts.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            tabSales.ResumeLayout(false);
            tabSales.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesGrid).EndInit();
            tabStores.ResumeLayout(false);
            tabStores.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)storesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabSales;
        private TabPage tabStores;
        private DataGridView productsGrid;
        private DataGridView salesGrid;
        private DataGridView storesGrid;
        private Panel panel3;
        private Button btnRefreshProduct;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private Panel panel2;
        private Button btnRefreshSales;
        private Button btnDeleteSale;
        private Button btnEditSale;
        private Button btnAddSale;
        private Panel panel1;
        private Button btnRefreshStores;
        private Button btnDeleteStore;
        private Button btnEditStore;
        private Button btnAddStore;
    }
}
