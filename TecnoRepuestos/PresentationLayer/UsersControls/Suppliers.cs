using BusinessLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.UsersControls
{
    public partial class Suppliers : UserControl

    {
        private readonly SupplierService _supplierService;
        public Suppliers( SupplierService supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var data = _supplierService.GetSuppliers();
            SuppliersDgv.DataSource = data;

           
            SuppliersDgv.Columns["IsTaxPayer"].Visible = false;
            SuppliersDgv.Columns["Id"].Visible=false;
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier()
                {
                    SupplierName =NameTextBox.Text,
                    ContacName = ContacTextBox.Text,
                    NIT = NITTextBox.Text,
                    NRC = NRCTextBox.Text, 
                    Telephone = PhoneTextBox.Text,
                    Email = MailTextBox.Text,
                    Address = AddressTextBox.Text
                };

                _supplierService.AddSupplier(supplier);
                LoadSuppliers();

                MessageBox.Show("Proveedor agregado con éxito.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            NameTextBox.Clear();
            ContacTextBox.Clear();
            NITTextBox.Clear();
            NRCTextBox.Clear();
            PhoneTextBox.Clear();
            MailTextBox.Clear();
            AddressTextBox.Clear();
        }
    }
    
}
