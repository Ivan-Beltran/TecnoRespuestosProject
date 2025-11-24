using BusinessLayer.Services;
using BusinessLayer.Services.ServiceForProduct;
using CommonLayer.Entities;
using PresentationLayer.Forms;
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
    public partial class PurchaseRegister : UserControl
    {
        private readonly SupplierService _supplierService;
        private readonly ProductService _productService;
        public int SupplierId;
        private List<PurchaseProduct> cart = new List<PurchaseProduct>();


        public PurchaseRegister(SupplierService supplierService,
            ProductService productService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _productService = productService;
            ConfigureCartTable();
            PaymentTypeComboBox.Items.AddRange(new string[]
             {
                  "Efectivo",
                  "Tarjeta",
                  "Credito"
             });
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            SelectSupplier frm = new SelectSupplier(_supplierService);

            // Abrir como modal sobre el Form que contiene el UserControl
            if (frm.ShowDialog(this.FindForm()) == DialogResult.OK)
            {
                SupplierId = frm.SelectedSupplierId;
                SupplierName.Text = frm.SelectedSupplierName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectProducts frm = new SelectProducts(_productService);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(frm.SelectedItem);
                RefreshCartTable();
            }

        }

        private void AddOrUpdateCartItem(PurchaseProduct item)
        {
            // Revisar si ya existe en carrito
            var existing = cart.FirstOrDefault(p => p.Id == item.Id);

            if (existing != null)
            {
                // Actualiza cantidad, costo y precio
                existing.UnitCost = item.UnitCost;
                existing.UnitPrice = item.UnitPrice;
                existing.Quantity = item.Quantity;
            }
            else
            {
                // Agregar nuevo
                cart.Add(item);
            }
        }

        private void RefreshCartTable()
        {
            PurcahseDataGridView.Rows.Clear();

            foreach (var item in cart)
            {
                PurcahseDataGridView.Rows.Add(
                    item.Id,
                    item.ProductName,
                    item.Model,
                    item.UnitCost,
                    item.UnitPrice,
                    item.Quantity
                );
            }
        }

        private void ConfigureCartTable()
        {
            PurcahseDataGridView.Columns.Clear();

            PurcahseDataGridView.Columns.Add("Id", "Id");
            PurcahseDataGridView.Columns.Add("ProductName", "Producto");
            PurcahseDataGridView.Columns.Add("Model", "Modelo");
            PurcahseDataGridView.Columns.Add("UnitCost", "Costo Unitario");
            PurcahseDataGridView.Columns.Add("UnitPrice", "Precio Unitario");
            PurcahseDataGridView.Columns.Add("Quantity", "Cantidad");
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            if (PaymentTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una forma de pago.");
                return;
            }

            string paymentForm = PaymentTypeComboBox.SelectedItem.ToString();
            DateTime? creditEndDate = null;

            // ⬇️ SI ES CRÉDITO ABRIR FORMULARIO DE FECHA
            if (paymentForm == "Credito")
            {
                using (SelectFinishDate frm = new SelectFinishDate())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Debe seleccionar una fecha para el crédito.");
                        return;
                    }

                    creditEndDate = frm.SelectedEndDate;
                }
            }

            // Validación carrito
            if (cart == null || cart.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            List<PurchaseItem> items = cart
                .Select(x => new PurchaseItem
                {
                    ProductId = x.Id,
                    Quantity = x.Quantity,
                    UnitCost = x.UnitCost,
                    UnitPrice = x.UnitPrice
                })
                .ToList();

            // ⬇️ PASAR LA FECHA AL SERVICIO SI ES CRÉDITO
            _productService.SavePurchase(
                SupplierId,
                InvoiceTextBox.Text,
                paymentForm,
                items,
                creditEndDate
            );

            MessageBox.Show("Compra registrada correctamente.");
        }




    }
}
