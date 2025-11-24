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
    public partial class SelectFinishDate : Form
    {
        public DateTime SelectedEndDate { get; private set; }

        public SelectFinishDate()
        {
            InitializeComponent();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            SelectedEndDate = PaydateTimePicker.Value.Date;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
