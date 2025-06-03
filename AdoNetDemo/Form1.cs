using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDao _productDao = new ProductDao();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDao.GetAll();
            //dgwProducts.DataSource = _productDao.GetAll2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDao.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Product added successfully!");
            LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDao.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            MessageBox.Show("Product updated successfully!");
            LoadProducts();
        }
    }
}
