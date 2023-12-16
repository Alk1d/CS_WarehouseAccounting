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
    public partial class InvoiceFormEdit : Form
    {
        private bool _editMode = false;
        private int _InvoiceId = 0;
        public InvoiceFormEdit()
        {
            InitializeComponent();
        }

        public InvoiceFormEdit(bool editmode = false, int InvoiceId = 0)
        {
            _editMode = editmode;
            _InvoiceId = InvoiceId;
            InitializeComponent();
        }

        private void InvoiceFormEdit_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.InvoiceTableName, _InvoiceId);
                InvoiceTitle.Text = fieldsValues[1];
                DateTitle.Text = fieldsValues[2];
                OrganizationTitle.Text = fieldsValues[3];
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            var fields = new Dictionary<string, TableField>();
            fields.Add(Constants.FieldNames.InvoiceTable.Contract, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = InvoiceTitle.Text
            });
            fields.Add(Constants.FieldNames.InvoiceTable.Date, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = DateTitle.Text
            });
            fields.Add(Constants.FieldNames.InvoiceTable.Organization, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = OrganizationTitle.Text
            });
            if (_editMode)
            {

                DBHelper.UpdateEntry(Constants.TableNames.InvoiceTableName, _InvoiceId, fields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                DBHelper.InsertEntry(Constants.TableNames.InvoiceTableName, fields);
                DialogResult = DialogResult.OK;
            }
        }
    }
}