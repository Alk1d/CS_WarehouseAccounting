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

namespace KursTest
{
    public partial class MenuToolstripBox : Form
    {
        public string checkedItemsValue { get; set; }
        public string checkedModeValue { get; set; }
        public MenuToolstripBox()
        {

            InitializeComponent();
            
        }


        private void Acceptbutton_Click(object sender, EventArgs e)
        {
            var checkedItemsButton = ItemsgroupBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            var checkedModeButton = SelectModegroupBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            checkedItemsValue = checkedItemsButton.Text;
            checkedModeValue = checkedModeButton.Text;
        }
    }
}
