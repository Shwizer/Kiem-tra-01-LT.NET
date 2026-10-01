using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WinForms1_10_2026
{

    public partial class Form1 : Form
    {
        private BindingList<Product> _originalList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = false;

            // Kết nối danh sách với bảng
            _bindingSource.DataSource = _originalList;
            dgvProducts.DataSource = _bindingSource;

            // Nạp dữ liệu cho ComboBox
            var categories = new[] {
                new { Id = "CAT_DT", Name = "Điện thoại" },
                new { Id = "CAT_LT", Name = "Laptop" },
                new { Id = "CAT_PK", Name = "Phụ kiện" }
            };
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblStatusCount.Text = $"Tổng số sản phẩm: {_originalList.Count}";
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Vui lòng nhập tên SP!");
                isValid = false;
            }
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá phải > 0!");
                isValid = false;
            }
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải >= 0!");
                isValid = false;
            }
            return isValid;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product p)
            {
                txtProductId.Text = p.ProductId;
                txtProductId.ReadOnly = true; 
                txtProductName.Text = p.ProductName;
                cboCategory.SelectedValue = p.CategoryId;
                txtUnitPrice.Text = p.UnitPrice.ToString("G0");
                txtQuantity.Text = p.Quantity.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                _bindingSource.DataSource = _originalList;
            }
            else
            {
                var filtered = _originalList.Where(p =>
                    p.ProductName.ToLower().Contains(keyword) ||
                    p.ProductId.ToLower().Contains(keyword)).ToList();
                _bindingSource.DataSource = new BindingList<Product>(filtered);
            }
        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", FileName = "Data.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine("Mã SP,Tên Sản Phẩm,Danh Mục,Đơn Giá,Số Lượng");
                        foreach (Product p in _bindingSource.List)
                        {
                            sw.WriteLine($"{p.ProductId},\"{p.ProductName}\",{p.CategoryName},{p.UnitPrice},{p.Quantity}");
                        }
                    }
                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (_originalList.Any(p => p.ProductId == txtProductId.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProd = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                CategoryId = cboCategory.SelectedValue.ToString(),
                CategoryName = cboCategory.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };

            _originalList.Add(newProd);
            UpdateStatus();
        }
    }

    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }


}
