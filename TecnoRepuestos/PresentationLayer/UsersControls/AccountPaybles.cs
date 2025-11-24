using BusinessLayer.Services.ServeceForAccounts;
using BusinessLayer.Services.ServiceForProduct;
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
    public partial class AccountPaybles : UserControl
    {
        private AccountService _accountService;
        private int SelectedAccountId = 0;
        public AccountPaybles(AccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
            LoadAccountsPaybles();
            LoadAccountsPaid();
        }

        public void LoadAccountsPaybles()
        {
            AccountsPayblesDataGridView.DataSource = _accountService.GetAccountsPaybles();
            AccountsPayblesDataGridView.Columns["AccountId"].Visible = false;
            AccountsPayblesDataGridView.Columns["PurchaseId"].Visible = false;

        }

        public void LoadAccountsPaid()
        {
            AccountsPaydataGridView.DataSource = _accountService.GetPaidAccounts();
            AccountsPaydataGridView.Columns["AccountId"].Visible = false;
            AccountsPaydataGridView.Columns["PurchaseId"].Visible = false;
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            if (AccountsPayblesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una cuenta primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el textbox no esté vacío
            if (string.IsNullOrWhiteSpace(MountTextBox.Text))
            {
                MessageBox.Show("Ingresa un monto para abonar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar que el monto sea decimal
            if (!decimal.TryParse(MountTextBox.Text, out decimal montoAbonar))
            {
                MessageBox.Show("El monto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Validar monto positivo
            if (montoAbonar <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener datos desde la fila seleccionada
            int accountId = Convert.ToInt32(AccountsPayblesDataGridView.CurrentRow.Cells["AccountId"].Value);
            decimal totalAmount = Convert.ToDecimal(AccountsPayblesDataGridView.CurrentRow.Cells["TotalAmount"].Value);
            decimal paidAmount = Convert.ToDecimal(AccountsPayblesDataGridView.CurrentRow.Cells["PaidAmount"].Value);

            decimal saldoPendiente = totalAmount - paidAmount;

            // 5. Validar que el monto no exceda la deuda
            if (montoAbonar > saldoPendiente)
            {
                MessageBox.Show($"El monto excede el saldo pendiente.\nSaldo disponible: {saldoPendiente:C2}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. Ejecutar el pago (Service → Repository → SP)
            try
            {
                _accountService.PayAccount(accountId, montoAbonar);

                MessageBox.Show("Abono realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 7. Refrescar la tabla (si tienes un método para cargar)
                LoadAccountsPaybles(); // quítalo si no lo usas
                LoadAccountsPaid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el abono: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
