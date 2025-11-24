using BusinessLayer.Services.ServiceForProduct;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class SelectProducts : Form
    {
        private readonly ProductService _productService;
        public PurchaseProduct SelectedItem;
        public SelectProducts(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            LoadProduct();
        }

        public void LoadProduct()
        {
            ProductsDgv.DataSource = _productService.GetProducts();
            ProductsDgv.Columns["Id"].Visible = false;
            ProductsDgv.Columns["costo unitario"].Visible = false;
            ProductsDgv.Columns["precio unitario"].Visible = false;
            ProductsDgv.Columns["disponibilidad"].Visible = false;
            ProductsDgv.Columns["cantidad"].Visible = false;

        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            if (ProductsDgv.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(UnitCostTextBox.Text) ||
                string.IsNullOrWhiteSpace(UnitPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                MessageBox.Show("Complete costo, precio y cantidad.");
                return;
            }

            SelectedItem = new PurchaseProduct()
            {
                Id = Convert.ToInt32(ProductsDgv.CurrentRow.Cells["Id"].Value),
                ProductName = ProductsDgv.CurrentRow.Cells["Nombre"].Value.ToString(),
                Model = ProductsDgv.CurrentRow.Cells["Modelo"].Value.ToString(),
                UnitCost = Convert.ToDecimal(UnitCostTextBox.Text),
                UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text),
                Quantity = Convert.ToInt32(QuantityTextBox.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
