using KursTest.Utils;
using System;
using System.Windows.Forms;
using ExelExporter;
using KursTest.WarehouseDBDataSetTableAdapters;

namespace KursTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProductpictureBox.BackgroundImage = Properties.Resources.DefaultImage;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.warehouseDBDataSetFull.Products);
            // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
            // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
            // TODO: This line of code loads data into the 'warehouseDBDataSetFull.Supplies' table. You can move, or remove it, as needed.
            this.suppliesTableAdapter.Fill(this.warehouseDBDataSetFull.Supplies);
        }
        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CategoriesMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void CategoryCreateMenuItem_Click(object sender, EventArgs e)
        => CreateCategory();

        private void CategoryUpdateMenuItem_Click(object sender, EventArgs e)
        => EditCategory();

        private void CategoryDeleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategorycomboBox.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует категория");
                    return;
                }
                var id = 0;
                if (int.TryParse(CategorycomboBox.SelectedValue.ToString(), out id)
                    && MessageBox.Show($"Вы действительно хотите удалить категорию {CategorycomboBox.Text}?",
                    "Удалить выбранную категорию", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.CategoriesTableName, id);
                    this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CategoryListDeleteMenuItem_Click(object sender, EventArgs e)
        => DeleteCategory();

        void ToolStripMenuitem()
        {
            try
            {
                using (var form = new MenuToolstripBox())
                {
                    var result = form.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        string value = form.checkedItemsValue;
                        string mode = form.checkedModeValue;
                        switch (value)
                        {
                            case "Товар": if (mode == "Добавить") EditProduct();
                                if (mode == "Изменить") EditProduct(true);
                                if (mode == "Удалить") DeleteProduct(); break;
                            case "Категория":
                                if (mode == "Добавить") CreateCategory();
                                if (mode == "Изменить") EditCategory();
                                if (mode == "Удалить") DeleteCategory(); break;
                            case "Накладная":
                                if (mode == "Добавить") EditInvoice();
                                if (mode == "Изменить") EditInvoice(true);
                                if (mode == "Удалить") DeleteInvoice(); break;
                            case "Поставка":
                                if (mode == "Добавить") EditSupply();
                                if (mode == "Изменить") EditSupply(true);
                                if (mode == "Удалить") DeleteSupply(); break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void CreateCategory()
        {
            try
            {
                if (new EditCategoryForm().ShowDialog() == DialogResult.OK)
                {
                    this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void DeleteProduct()
        {
            try
            {
                if (ProductdataGridView.Rows.Count == 0 || ProductdataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран продукт");
                    return;
                }

                if (MessageBox.Show($"Вы действительно хотите удалить выделенный товар?", "Удаление товара",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < ProductdataGridView.SelectedRows.Count; i++)
                    {
                        var id = 0;
                        int.TryParse(ProductdataGridView.SelectedRows[i].Cells[0].Value?.ToString(), out id);
                        DBHelper.DeleteEntry(Constants.TableNames.ProductsTableName, id);
                    }
                    this.productsTableAdapter.Fill(this.warehouseDBDataSetFull.Products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void DeleteCategory()
        {
            try
            {
                if (new DeleteCategoryForm().ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void DeleteSupply()
        {
            try
            {
                if (InvoicedataGridView.Rows.Count == 0 || InvoicedataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран продукт");
                    return;
                }

                if (MessageBox.Show($"Вы действительно хотите удалить выделенные данные в накладной?", "Удаление данных в накладной",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < InvoicedataGridView.SelectedRows.Count; i++)
                    {
                        var id = 0;
                        int.TryParse(InvoicedataGridView.SelectedRows[i].Cells[0].Value?.ToString(), out id);
                        DBHelper.DeleteEntry(Constants.TableNames.SuppliesTableName, id);
                    }
                    this.suppliesTableAdapter.Fill(this.warehouseDBDataSetFull.Supplies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
       
        void EditCategory()
        {
            {
                try
                {
                    if (CategorycomboBox.Items.Count == 0)
                    {
                        MessageBox.Show("Отсутствует категория");
                        return;
                    }
                    var id = 0;
                    if (int.TryParse(CategorycomboBox.SelectedValue.ToString(), out id) &&
                        new EditCategoryForm(true, id).ShowDialog() == DialogResult.OK)
                    {
                        this.categoriesTableAdapter.Fill(this.warehouseDBDataSetFull.Categories);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        void DeleteInvoice()
        {
            try
            {
                if (new DeleteInvoiceForm().ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ProductDeleteMenuItem_Click(object sender, EventArgs e)
        => DeleteProduct();

        private void ProductdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InvoicedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InvoiceDeleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (InvoicecomboBox.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует накладная");
                    return;
                }
                var id = 0;
                if (int.TryParse(InvoicecomboBox.SelectedValue.ToString(), out id)
                    && MessageBox.Show($"Вы действительно хотите удалить накладную {InvoicecomboBox.Text}?",
                    "Удалить выбранную накладную", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.InvoiceTableName, id);
                    this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InvoiceListDeleteMenuItem_Click(object sender, EventArgs e)
        => DeleteInvoice();

        private void EditProduct(bool isEditMode = false)
        {
            try
            {
                if (isEditMode)
                {
                    if (ProductdataGridView.Rows.Count == 0 || ProductdataGridView.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Не выбран продукт");
                        return;
                    }
                    var id = 0;
                    int.TryParse(ProductdataGridView.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                    if (id != 0 && new EditProductForm(true, id).ShowDialog() == DialogResult.OK)
                    {
                       
                        this.productsTableAdapter.Fill(this.warehouseDBDataSetFull.Products);
                    }
                }
                else if (new EditProductForm().ShowDialog() == DialogResult.OK)
                {
                    this.productsTableAdapter.Fill(this.warehouseDBDataSetFull.Products);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EditSupply(bool isEditMode = false)
        {
            try
            {
                if (isEditMode)
                {
                    if (InvoicedataGridView.Rows.Count == 0 || InvoicedataGridView.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Не выбрана накладная или пустая поставка");
                        return;
                    }
                    var id = 0;
                    int.TryParse(InvoicedataGridView.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                    if (id != 0 && new EditSupplyForm(true, id).ShowDialog() == DialogResult.OK)
                    {

                        this.suppliesTableAdapter.Fill(this.warehouseDBDataSetFull.Supplies);
                    }
                }
                else if (new EditSupplyForm().ShowDialog() == DialogResult.OK)
                {
                    this.suppliesTableAdapter.Fill(this.warehouseDBDataSetFull.Supplies);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EditInvoice(bool isEditMode = false)
        {
            try
            {
                if (isEditMode)
                {
                    if (InvoicecomboBox.Items.Count == 0)
                    {
                        MessageBox.Show("Отсутствует накладная");
                        return;
                    }
                    var id = 0;
                    int.TryParse(InvoicecomboBox.SelectedValue.ToString(), out id);
                    if (id != 0 && new InvoiceFormEdit(true, id).ShowDialog() == DialogResult.OK)
                    {

                        this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
                    }
                }
                else if (new InvoiceFormEdit().ShowDialog() == DialogResult.OK)
                {
                    this.invoiceTableAdapter.Fill(this.warehouseDBDataSetFull.Invoice);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SuppliesDeleteMenuItem_Click(object sender, EventArgs e)
        => DeleteSupply();
        private void ProductCreateMenuItem_Click(object sender, EventArgs e)
        => EditProduct();
        private void ProductUpdateMenuItem_Click(object sender, EventArgs e)
        => EditProduct(true);

        private void LeftToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuitem();
        }

        private void SupplyCreateMenuItem_Click(object sender, EventArgs e)
        => EditSupply();

        private void SupplyUpdateMenuItem_Click(object sender, EventArgs e)
        => EditSupply(true);

        private void InvoiceCreateMenuItem_Click(object sender, EventArgs e)
        => EditInvoice();

        private void InvoiceUpdateMenuItem_Click(object sender, EventArgs e)
        => EditInvoice(true);

        private void ExcelExportMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExcelExportSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = ExcelExportSaveFileDialog.FileName;
                    new ExcelExportManager().ExportDataSet(warehouseDBDataSetFull, filePath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExcelPartialExportMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExcelExportSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = ExcelExportSaveFileDialog.FileName;

                    var exportProductsTableAdapter = new ExcelExportProductsTableAdapter();
                    var exportSuppliesTableAdapter = new ExcelExportSuppliesTableAdapter();

                    var Pid = 0;
                    var Sid = 0;
                    int.TryParse(CategorycomboBox.SelectedValue.ToString(), out Pid);
                    int.TryParse(InvoicecomboBox.SelectedValue.ToString(), out Sid);

                    exportProductsTableAdapter.Fill(ExcelExportDBDataSet.Products, Pid);
                    exportSuppliesTableAdapter.Fill(ExcelExportDBDataSet.Supplies, Sid);

                    new ExcelExportManager().ExportDataSet(ExcelExportDBDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
