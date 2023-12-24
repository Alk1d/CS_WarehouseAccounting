using KursTest.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursTest
{
    public partial class EditProductForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;
        private byte[] _photo;
        public EditProductForm()
        {
            InitializeComponent();
        }
        public EditProductForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();
        }
        
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
                var ProductfieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.ProductsTableName, _id);
                CategorycomboBox.SelectedValue = ProductfieldsValues[1];
                ProductNametextBox.Text = ProductfieldsValues[2];
                ProductPricetextBox.Text = ProductfieldsValues[3];
                ProductAmounttextBox.Text = ProductfieldsValues[4];
            }
            else
            {
                // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            var Productfields = new Dictionary<string, TableField>();

            Productfields.Add(Constants.FieldNames.ProductsTable.CategoryId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = CategorycomboBox.SelectedValue.ToString()
            });
            Productfields.Add(Constants.FieldNames.ProductsTable.Name, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = ProductNametextBox.Text
            });
            Productfields.Add(Constants.FieldNames.ProductsTable.Price, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = ProductPricetextBox.Text.ToString()
            });
            Productfields.Add(Constants.FieldNames.ProductsTable.Amount, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = ProductAmounttextBox.Text.ToString()
            });

            if (_isEditMode)
            {
                DBHelper.UpdateEntry(Constants.TableNames.ProductsTableName, _id, Productfields);

                if (_photo != null)
                {
                    DBHelper.InsertPhoto(Constants.TableNames.ProductsTableName, "Photo", _id, _photo);
                }
               

                DialogResult = DialogResult.OK;
            }
            else
            {
                DBHelper.InsertEntry(Constants.TableNames.ProductsTableName, Productfields);
                DialogResult = DialogResult.OK;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

        }

        private void ChooseImageButton_Click(object sender, EventArgs e)
        {
            if (ChooseImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = ChooseImageFileDialog.FileName;
                _photo = File.ReadAllBytes(path);
            }
        }
    }
}
