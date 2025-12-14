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
            btn_AddProduct = new Button();
            productsGrid = new DataGridView();
            tabSales = new TabPage();
            panel2 = new Panel();
            salesGrid = new DataGridView();
            tabStores = new TabPage();
            panel1 = new Panel();
            storesGrid = new DataGridView();
            tabControl1.SuspendLayout();
            tabProducts.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesGrid).BeginInit();
            tabStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storesGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabSales);
            tabControl1.Controls.Add(tabStores);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 337);
            tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(panel3);
            tabProducts.Controls.Add(productsGrid);
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(768, 309);
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
            panel3.Controls.Add(btn_AddProduct);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(762, 29);
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
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(165, 3);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(84, 3);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 1;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Location = new Point(3, 3);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(75, 23);
            btn_AddProduct.TabIndex = 0;
            btn_AddProduct.Text = "Add";
            btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Dock = DockStyle.Fill;
            productsGrid.Location = new Point(3, 3);
            productsGrid.MultiSelect = false;
            productsGrid.Name = "productsGrid";
            productsGrid.ReadOnly = true;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.Size = new Size(762, 303);
            productsGrid.TabIndex = 1;
            // 
            // tabSales
            // 
            tabSales.Controls.Add(panel2);
            tabSales.Controls.Add(salesGrid);
            tabSales.Location = new Point(4, 24);
            tabSales.Name = "tabSales";
            tabSales.Padding = new Padding(3);
            tabSales.Size = new Size(768, 309);
            tabSales.TabIndex = 1;
            tabSales.Text = "Sales";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 45);
            panel2.TabIndex = 2;
            // 
            // salesGrid
            // 
            salesGrid.AllowUserToAddRows = false;
            salesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGrid.Dock = DockStyle.Fill;
            salesGrid.Location = new Point(3, 3);
            salesGrid.MultiSelect = false;
            salesGrid.Name = "salesGrid";
            salesGrid.ReadOnly = true;
            salesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesGrid.Size = new Size(762, 303);
            salesGrid.TabIndex = 1;
            // 
            // tabStores
            // 
            tabStores.Controls.Add(panel1);
            tabStores.Controls.Add(storesGrid);
            tabStores.Location = new Point(4, 24);
            tabStores.Name = "tabStores";
            tabStores.Size = new Size(768, 309);
            tabStores.TabIndex = 2;
            tabStores.Text = "Stores";
            tabStores.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 45);
            panel1.TabIndex = 1;
            // 
            // storesGrid
            // 
            storesGrid.AllowUserToAddRows = false;
            storesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storesGrid.Dock = DockStyle.Fill;
            storesGrid.Location = new Point(0, 0);
            storesGrid.MultiSelect = false;
            storesGrid.Name = "storesGrid";
            storesGrid.ReadOnly = true;
            storesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storesGrid.Size = new Size(768, 309);
            storesGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Cordys Exam - Local Suite";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabProducts.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesGrid).EndInit();
            tabStores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)storesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabSales;
        private TabPage tabStores;
        private Panel panel1;
        private DataGridView productsGrid;
        private Panel panel2;
        private DataGridView salesGrid;
        private DataGridView storesGrid;
        private Panel panel3;
        private Button btnRefreshProduct;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btn_AddProduct;
    }
}
