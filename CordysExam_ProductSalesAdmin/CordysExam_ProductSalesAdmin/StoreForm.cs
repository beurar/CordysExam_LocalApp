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
    public partial class StoreForm : Form
    {
        public Store Store { get; private set; }

        public StoreForm()
        {
            InitializeComponent();
            Store = new Store();
        }

        public StoreForm(Store store)
        {
            InitializeComponent();
            Store = store;
            txtName.Text = store.Name;
            txtAddress.Text = store.Address;
            txtTel.Text = store.Tel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Store name is required.");
                return;
            }

            Store.Name = txtName.Text.Trim();
            Store.Address = txtAddress.Text.Trim();
            Store.Tel = txtTel.Text.Trim();

            Close();
        }

    }
}
