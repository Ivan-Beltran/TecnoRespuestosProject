using BusinessLayer.Services.ServiceForCustomer;
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
using System.Xml.Linq;

namespace PresentationLayer.UsersControls
{
    public partial class Customers : UserControl
    {
        private CustomerService _customerService;
        public Customers(CustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomers();
        }


        public void LoadCustomers()
        {
            CustomersDgv.DataSource = _customerService.GetCustomers();
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones básicas
                if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                    string.IsNullOrWhiteSpace(DuiTextBox.Text) ||
                    string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                    string.IsNullOrWhiteSpace(TelephoneTextBox.Text))
                {
                    MessageBox.Show("Todos los campos excepto NRC son obligatorios.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Customer c = new Customer
                {
                    Name = NameTextBox.Text.Trim(),
                    LastName = LastNameTextBox.Text.Trim(),
                    Address = AddressTextBox.Text.Trim(),
                    DUI = DuiTextBox.Text.Trim(),
                    Email = EmailTextBox.Text.Trim(),
                    Telephone = TelephoneTextBox.Text.Trim(),
                    NRC = NRCTextBox.Text.Trim(), 
                    CustomerType = "Contribuidor"    
                };

                _customerService.InsertCustomer(c);


                // 4. Mensaje
                MessageBox.Show("Cliente agregado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Limpiar campos
                NameTextBox.Clear();
                LastNameTextBox.Clear();
                AddressTextBox.Clear();
                DuiTextBox.Clear();
                EmailTextBox.Clear();
                TelephoneTextBox.Clear();
                NRCTextBox.Clear();

                LoadCustomers();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
