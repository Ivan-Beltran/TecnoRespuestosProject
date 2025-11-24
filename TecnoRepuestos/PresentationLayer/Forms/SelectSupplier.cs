using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class SelectSupplier : Form
    {
        private readonly SupplierService _supplierService;

        public int SelectedSupplierId { get; private set; }
        public string SelectedSupplierName { get; private set; }

        public SelectSupplier(SupplierService supplierService)
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
            SuppliersDgv.Columns["Id"].Visible = false;
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            if (SuppliersDgv.CurrentRow != null)
            {
                SelectedSupplierId = Convert.ToInt32(SuppliersDgv.CurrentRow.Cells["Id"].Value);
                SelectedSupplierName = SuppliersDgv.CurrentRow.Cells["nombre"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }

}
