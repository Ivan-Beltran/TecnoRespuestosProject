using BusinessLayer.Services;
using BusinessLayer.Services.ServeceForAccounts;
using BusinessLayer.Services.ServiceForCustomer;
using BusinessLayer.Services.ServiceForLogin;
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
    public partial class Login : Form
    {

        private LoginService _loginServices;
        private SupplierService _supplierServices;
        private readonly ProductService _productService;
        private CustomerService _customerService;
        private AccountService _accountService;
        public Login(LoginService loginService,
                     SupplierService supplierService,
                     ProductService productService,
                     CustomerService customer,
                     AccountService accountService
                     )
        {

            InitializeComponent();
            _loginServices = loginService;
            _supplierServices = supplierService;
            _productService = productService;
            _customerService = customer;
            _accountService = accountService;
        }


        private async void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;

            try
            {
                string username = UserNametextBox.Text.Trim();
                string password = PasswordTextBox.Text.Trim();

                // Ejecutar login (DAL + Service)
                var user = await Task.Run(() => _loginServices.Login(username, password));

                // NO encontró usuario
                if (user == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guardar la sesión del usuario
                UserSession.UserId = user.Id;
                UserSession.Username = user.UserName;
                UserSession.FullName = $"{user.Name} {user.LastName}";

                MessageBox.Show(
                    $"Bienvenido {UserSession.FullName}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Abre dashboard
                this.Hide();
                Dashboard dashboard = new Dashboard(
                    _supplierServices,
                    _productService,
                    _customerService,
                    _accountService
                );

                dashboard.FormClosed += (s, arg) =>
                {
                    this.Show();
                    UserNametextBox.Text = "";
                    PasswordTextBox.Text = "";
                    UserSession.Clear(); // limpiar sesión si se cierra dashboard
                };

                dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoginButton.Enabled = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
