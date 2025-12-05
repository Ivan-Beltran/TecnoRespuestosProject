using BusinessLayer.Services;
using BusinessLayer.Services.ServeceForAccounts;
using BusinessLayer.Services.ServiceForCustomer;
using BusinessLayer.Services.ServiceForProduct;
using PresentationLayer.UsersControls;
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
    public partial class Dashboard : Form
    {
        private readonly SupplierService _supplierService;
        private readonly ProductService _productService;
        private CustomerService _customerService;
        private AccountService _accountService;
        public Dashboard(SupplierService supplierService,
                        ProductService productService,
                        CustomerService customerService,
                        AccountService accountService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _productService = productService;
            _customerService = customerService;
            _accountService = accountService;
        }

        private void OpenControl(UserControl control)
        {
            ContainerPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(control);
        }



        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            OpenControl(new Suppliers(_supplierService));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenControl(new Products(_productService));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenControl(new Customers(_customerService));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenControl(new PurchaseRegister(_supplierService, _productService));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenControl(new AccountPaybles(_accountService));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenControl(new AddSales());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
