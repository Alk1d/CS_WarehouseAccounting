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
    public partial class EditCategoryForm : Form
    {
        private bool _editMode = false;
        private int _CategoryId = 0;
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        public EditCategoryForm(bool editmode = false, int CategoryId = 0)
        {
            _editMode = editmode;
            _CategoryId = CategoryId;
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.CategoriesTableName, _CategoryId);
                CategoryTitle.Text = fieldsValues[1];
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldNames.CategoriesTable.Title, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = CategoryTitle.Text
                });
                DBHelper.UpdateEntry(Constants.TableNames.CategoriesTableName, _CategoryId, fields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldNames.CategoriesTable.Title, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = CategoryTitle.Text
                });

                DBHelper.InsertEntry(Constants.TableNames.CategoriesTableName, fields);
                DialogResult = DialogResult.OK;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
