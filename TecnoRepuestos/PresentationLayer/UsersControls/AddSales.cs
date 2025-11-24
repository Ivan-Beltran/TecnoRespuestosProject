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
    public partial class AddSales : UserControl
    {
        public AddSales()
        {
            InitializeComponent();
            CustomerLabel.Text = "aqui va el cliente";
            
        }
        
    }
}
