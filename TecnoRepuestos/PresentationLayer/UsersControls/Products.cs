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

namespace PresentationLayer.UsersControls
{
    public partial class Products : UserControl
    {
        private readonly ProductService _productService;
        public Products(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            LoadCategory();
            LoadProduct();

        }

        public void LoadCategory()
        {
            CategoryCbx.DataSource = _productService.GetCategory();
            CategoryCbx.DisplayMember = "CategoryName";
            CategoryCbx.ValueMember = "Id";
            CategoryCbx.SelectedIndex = -1;
        }

        public void LoadProduct()
        {
            ProductosDgv.DataSource = _productService.GetProducts();
            ProductosDgv.Columns["Id"].Visible = false;
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CodeTextBox.Text))
            {
                MessageBox.Show("El código es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(BrandTextBox.Text))
            {
                MessageBox.Show("La marca es obligatoria.");
                return;
            }

            if (CategoryCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            // 2. Crear el objeto Product
            Product p = new Product()
            {
                CategoryId = Convert.ToInt32(CategoryCbx.SelectedValue),
                Code = CodeTextBox.Text.Trim(),
                Brand = BrandTextBox.Text.Trim(),
                ProductName = NameTextBox.Text.Trim(),
                Model = ModelTextBox.Text.Trim(),

                // Estos NO se envían al SP, pero no afecta
                UnitCost = 0,
                UnitPrice = 0,
                Quantity = 0,
                IsAvailable = false,
                ImgPath = null
            };

            try
            {
                _productService.InsertProduct(p);

                MessageBox.Show("Producto agregado exitosamente.");

                CodeTextBox.Clear();
                BrandTextBox.Clear();
                NameTextBox.Clear();
                ModelTextBox.Clear();
                CategoryCbx.SelectedIndex = -1;

                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }

}
