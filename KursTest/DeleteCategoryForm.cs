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
    public partial class DeleteCategoryForm : Form
    {
        public DeleteCategoryForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
        }
        
        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить запись",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(CategorycomboBox.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry(Constants.TableNames.CategoriesTableName, id);
                RefreshData(); 
            }
        }
    }
}
