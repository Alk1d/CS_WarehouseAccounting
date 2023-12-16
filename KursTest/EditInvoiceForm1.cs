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
    public partial class EditSupplyForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;
        public EditSupplyForm()
        {
            InitializeComponent();
        }
        public EditSupplyForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();
        }

        private void EditInvoiceForm_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
                var SuppliesfieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.SuppliesTableName, _id);
                InvoicecomboBox.SelectedValue = SuppliesfieldsValues[0];
                SupplyNametextBox.Text = SuppliesfieldsValues[2];
                SupplyAmounttextBox.Text = SuppliesfieldsValues[3];
                SupplyPricetextBox.Text = SuppliesfieldsValues[4];
                SupplyNoSaletextBox.Text = SuppliesfieldsValues[5];
                SupplySaletextBox.Text = SuppliesfieldsValues[6];
                SupplyTotaltextBox.Text = SuppliesfieldsValues[7];


            }
            else
            {
                // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Categories' table. You can move, or remove it, as needed.
                this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            var Supplyfields = new Dictionary<string, TableField>();
            // nvarchar для плавающих значений
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.InvoiceId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = InvoicecomboBox.SelectedValue.ToString()
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.Product, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = SupplyNametextBox.Text
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.Amount, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = SupplyAmounttextBox.Text.ToString()
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.Price, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = SupplyPricetextBox.Text.ToString()
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.Without_sale, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = SupplyNoSaletextBox.Text.ToString()
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.With_sale, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = SupplySaletextBox.Text.ToString()
            });
            Supplyfields.Add(Constants.FieldNames.SuppliesTable.Total, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = SupplyTotaltextBox.Text.ToString()
            });


            if (_isEditMode)
            {
                DBHelper.UpdateEntry(Constants.TableNames.SuppliesTableName, _id, Supplyfields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                DBHelper.InsertEntry(Constants.TableNames.SuppliesTableName, Supplyfields);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
