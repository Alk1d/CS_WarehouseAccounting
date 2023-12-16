using KursTest.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursTest
{
    public partial class DeleteInvoiceForm : Form
    {
        public DeleteInvoiceForm()
        {
            InitializeComponent();
        }

        private void DeleteInvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Invoice' table. You can move, or remove it, as needed.
            RefreshData();

        }
        private void RefreshData()
        {
            this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
        }


        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить запись",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(InvoicecomboBox.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry(Constants.TableNames.InvoiceTableName, id);
                RefreshData();
            }
        }
    }
}
