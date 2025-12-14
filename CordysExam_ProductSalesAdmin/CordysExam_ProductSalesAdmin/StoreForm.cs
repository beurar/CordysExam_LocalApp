using CordysExam_ProductSalesAdmin.Models;
using System;
using System.Text.RegularExpressions;
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

        public StoreForm(Store store) : this()
        {
            Store = store;
            txtName.Text = store.Name;
            txtAddress.Text = store.Address;
            txtTel.Text = store.Tel;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, +, -, (, ), space, and control keys (backspace, delete)
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+' &&
                e.KeyChar != '-' &&
                e.KeyChar != '(' &&
                e.KeyChar != ')' &&
                e.KeyChar != ' ')
            {
                e.Handled = true; // reject input
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all required fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Store name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhone(txtTel.Text))
            {
                MessageBox.Show("Please enter a valid telephone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Store.Name = txtName.Text.Trim();
            Store.Address = txtAddress.Text.Trim();
            Store.Tel = txtTel.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsValidPhone(string phone)
        {
            // Allows digits, +, -, (, ), spaces. Must contain at least 5 digits.
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Remove non-digit characters to check digit count
            var digitsOnly = Regex.Replace(phone, @"\D", "");
            if (digitsOnly.Length < 5)
                return false;

            // Only allowed characters
            return Regex.IsMatch(phone, @"^[0-9+\-\(\) ]+$");
        }
    }
}
