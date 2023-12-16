namespace KursTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelPartialExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CategoryDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryListDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupplyCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupplyUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.InvoiceCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.InvoiceDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceListDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliesDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobaltableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSetFull = new KursTest.WarehouseDBDataSetFull();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKProductsCategoriesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LeftToolStripMenuButton = new System.Windows.Forms.ToolStripButton();
            this.SuppliesInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.RightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InvoiceNameGroupBox = new System.Windows.Forms.GroupBox();
            this.InvoicecomboBox = new System.Windows.Forms.ComboBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFull = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceSupplyGroupBox = new System.Windows.Forms.GroupBox();
            this.InvoicedataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withoutSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSuppliesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceDateGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InvoiceOrgGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.SuppliesTableAdapter();
            this.invoiceTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter();
            this.categoriesTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.CategoriesTableAdapter();
            this.warehouseDBDataSetFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.ProductsTableAdapter();
            this.ExcelExportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExcelExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExcelExportDBDataSet = new KursTest.WarehouseDBDataSet();
            this.menuStrip.SuspendLayout();
            this.GlobaltableLayoutPanel.SuspendLayout();
            this.LeftTableLayoutPanel.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).BeginInit();
            this.ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoriesBindingSource4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuppliesInfoGroupBox.SuspendLayout();
            this.RightTableLayoutPanel.SuspendLayout();
            this.InvoiceNameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFull)).BeginInit();
            this.InvoiceSupplyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSuppliesInvoiceBindingSource)).BeginInit();
            this.InvoiceDateGroupBox.SuspendLayout();
            this.InvoiceOrgGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExportDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.CategoriesMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelExportMenuItem,
            this.ExcelPartialExportMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // ExcelExportMenuItem
            // 
            this.ExcelExportMenuItem.Name = "ExcelExportMenuItem";
            this.ExcelExportMenuItem.Size = new System.Drawing.Size(252, 22);
            this.ExcelExportMenuItem.Text = "Экспорт полных данных в Excel";
            this.ExcelExportMenuItem.Click += new System.EventHandler(this.ExcelExportMenuItem_Click);
            // 
            // ExcelPartialExportMenuItem
            // 
            this.ExcelPartialExportMenuItem.Name = "ExcelPartialExportMenuItem";
            this.ExcelPartialExportMenuItem.Size = new System.Drawing.Size(252, 22);
            this.ExcelPartialExportMenuItem.Text = "Экспорт текущих данных в Excel";
            this.ExcelPartialExportMenuItem.Click += new System.EventHandler(this.ExcelPartialExportMenuItem_Click);
            // 
            // CategoriesMenuItem
            // 
            this.CategoriesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryMenuItem,
            this.ProductMenuItem,
            this.InvoiceMenuItem});
            this.CategoriesMenuItem.Name = "CategoriesMenuItem";
            this.CategoriesMenuItem.Size = new System.Drawing.Size(139, 20);
            this.CategoriesMenuItem.Text = "Управление данными";
            this.CategoriesMenuItem.Click += new System.EventHandler(this.CategoriesMenuItem_Click);
            // 
            // CategoryMenuItem
            // 
            this.CategoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryCreateMenuItem,
            this.CategoryUpdateMenuItem,
            this.toolStripMenuItem1,
            this.CategoryDeleteMenuItem,
            this.CategoryListDeleteMenuItem});
            this.CategoryMenuItem.Name = "CategoryMenuItem";
            this.CategoryMenuItem.Size = new System.Drawing.Size(131, 22);
            this.CategoryMenuItem.Text = "Категории";
            // 
            // CategoryCreateMenuItem
            // 
            this.CategoryCreateMenuItem.Name = "CategoryCreateMenuItem";
            this.CategoryCreateMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CategoryCreateMenuItem.Text = "Добавить";
            this.CategoryCreateMenuItem.Click += new System.EventHandler(this.CategoryCreateMenuItem_Click);
            // 
            // CategoryUpdateMenuItem
            // 
            this.CategoryUpdateMenuItem.Name = "CategoryUpdateMenuItem";
            this.CategoryUpdateMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CategoryUpdateMenuItem.Text = "Изменить";
            this.CategoryUpdateMenuItem.Click += new System.EventHandler(this.CategoryUpdateMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // CategoryDeleteMenuItem
            // 
            this.CategoryDeleteMenuItem.Name = "CategoryDeleteMenuItem";
            this.CategoryDeleteMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CategoryDeleteMenuItem.Text = "Удалить";
            this.CategoryDeleteMenuItem.Click += new System.EventHandler(this.CategoryDeleteMenuItem_Click);
            // 
            // CategoryListDeleteMenuItem
            // 
            this.CategoryListDeleteMenuItem.Name = "CategoryListDeleteMenuItem";
            this.CategoryListDeleteMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CategoryListDeleteMenuItem.Text = "Удалить в списке";
            this.CategoryListDeleteMenuItem.Click += new System.EventHandler(this.CategoryListDeleteMenuItem_Click);
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductCreateMenuItem,
            this.ProductUpdateMenuItem,
            this.ProductDeleteMenuItem});
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ProductMenuItem.Text = "Товар";
            // 
            // ProductCreateMenuItem
            // 
            this.ProductCreateMenuItem.Name = "ProductCreateMenuItem";
            this.ProductCreateMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ProductCreateMenuItem.Text = "Добавить";
            this.ProductCreateMenuItem.Click += new System.EventHandler(this.ProductCreateMenuItem_Click);
            // 
            // ProductUpdateMenuItem
            // 
            this.ProductUpdateMenuItem.Name = "ProductUpdateMenuItem";
            this.ProductUpdateMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ProductUpdateMenuItem.Text = "Изменить";
            this.ProductUpdateMenuItem.Click += new System.EventHandler(this.ProductUpdateMenuItem_Click);
            // 
            // ProductDeleteMenuItem
            // 
            this.ProductDeleteMenuItem.Name = "ProductDeleteMenuItem";
            this.ProductDeleteMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ProductDeleteMenuItem.Text = "Удалить";
            this.ProductDeleteMenuItem.Click += new System.EventHandler(this.ProductDeleteMenuItem_Click);
            // 
            // InvoiceMenuItem
            // 
            this.InvoiceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SupplyCreateMenuItem,
            this.SupplyUpdateMenuItem,
            this.toolStripMenuItem2,
            this.InvoiceCreateMenuItem,
            this.InvoiceUpdateMenuItem,
            this.toolStripMenuItem3,
            this.InvoiceDeleteMenuItem,
            this.InvoiceListDeleteMenuItem,
            this.SuppliesDeleteMenuItem});
            this.InvoiceMenuItem.Name = "InvoiceMenuItem";
            this.InvoiceMenuItem.Size = new System.Drawing.Size(131, 22);
            this.InvoiceMenuItem.Text = "Поставки";
            // 
            // SupplyCreateMenuItem
            // 
            this.SupplyCreateMenuItem.Name = "SupplyCreateMenuItem";
            this.SupplyCreateMenuItem.Size = new System.Drawing.Size(192, 22);
            this.SupplyCreateMenuItem.Text = "Добавить";
            this.SupplyCreateMenuItem.Click += new System.EventHandler(this.SupplyCreateMenuItem_Click);
            // 
            // SupplyUpdateMenuItem
            // 
            this.SupplyUpdateMenuItem.Name = "SupplyUpdateMenuItem";
            this.SupplyUpdateMenuItem.Size = new System.Drawing.Size(192, 22);
            this.SupplyUpdateMenuItem.Text = "Изменить";
            this.SupplyUpdateMenuItem.Click += new System.EventHandler(this.SupplyUpdateMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // InvoiceCreateMenuItem
            // 
            this.InvoiceCreateMenuItem.Name = "InvoiceCreateMenuItem";
            this.InvoiceCreateMenuItem.Size = new System.Drawing.Size(192, 22);
            this.InvoiceCreateMenuItem.Text = "Добавить накладную";
            this.InvoiceCreateMenuItem.Click += new System.EventHandler(this.InvoiceCreateMenuItem_Click);
            // 
            // InvoiceUpdateMenuItem
            // 
            this.InvoiceUpdateMenuItem.Name = "InvoiceUpdateMenuItem";
            this.InvoiceUpdateMenuItem.Size = new System.Drawing.Size(192, 22);
            this.InvoiceUpdateMenuItem.Text = "Изменить накладную";
            this.InvoiceUpdateMenuItem.Click += new System.EventHandler(this.InvoiceUpdateMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // InvoiceDeleteMenuItem
            // 
            this.InvoiceDeleteMenuItem.Name = "InvoiceDeleteMenuItem";
            this.InvoiceDeleteMenuItem.Size = new System.Drawing.Size(192, 22);
            this.InvoiceDeleteMenuItem.Text = "Удалить накладную";
            this.InvoiceDeleteMenuItem.Click += new System.EventHandler(this.InvoiceDeleteMenuItem_Click);
            // 
            // InvoiceListDeleteMenuItem
            // 
            this.InvoiceListDeleteMenuItem.Name = "InvoiceListDeleteMenuItem";
            this.InvoiceListDeleteMenuItem.Size = new System.Drawing.Size(192, 22);
            this.InvoiceListDeleteMenuItem.Text = "Удалить в списке";
            this.InvoiceListDeleteMenuItem.Click += new System.EventHandler(this.InvoiceListDeleteMenuItem_Click);
            // 
            // SuppliesDeleteMenuItem
            // 
            this.SuppliesDeleteMenuItem.Name = "SuppliesDeleteMenuItem";
            this.SuppliesDeleteMenuItem.Size = new System.Drawing.Size(192, 22);
            this.SuppliesDeleteMenuItem.Text = "Удалить поставку";
            this.SuppliesDeleteMenuItem.Click += new System.EventHandler(this.SuppliesDeleteMenuItem_Click);
            // 
            // GlobaltableLayoutPanel
            // 
            this.GlobaltableLayoutPanel.ColumnCount = 2;
            this.GlobaltableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GlobaltableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GlobaltableLayoutPanel.Controls.Add(this.LeftTableLayoutPanel, 0, 0);
            this.GlobaltableLayoutPanel.Controls.Add(this.SuppliesInfoGroupBox, 1, 0);
            this.GlobaltableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobaltableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.GlobaltableLayoutPanel.Name = "GlobaltableLayoutPanel";
            this.GlobaltableLayoutPanel.RowCount = 1;
            this.GlobaltableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobaltableLayoutPanel.Size = new System.Drawing.Size(1084, 702);
            this.GlobaltableLayoutPanel.TabIndex = 1;
            // 
            // LeftTableLayoutPanel
            // 
            this.LeftTableLayoutPanel.ColumnCount = 1;
            this.LeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftTableLayoutPanel.Controls.Add(this.CategoryGroupBox, 0, 0);
            this.LeftTableLayoutPanel.Controls.Add(this.ProductGroupBox, 0, 1);
            this.LeftTableLayoutPanel.Controls.Add(this.toolStrip1, 0, 2);
            this.LeftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftTableLayoutPanel.Name = "LeftTableLayoutPanel";
            this.LeftTableLayoutPanel.RowCount = 3;
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LeftTableLayoutPanel.Size = new System.Drawing.Size(536, 696);
            this.LeftTableLayoutPanel.TabIndex = 0;
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategorycomboBox);
            this.CategoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(530, 44);
            this.CategoryGroupBox.TabIndex = 0;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Категории:";
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.DataSource = this.categoriesBindingSource2;
            this.CategorycomboBox.DisplayMember = "Title";
            this.CategorycomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(3, 16);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(524, 21);
            this.CategorycomboBox.TabIndex = 0;
            this.CategorycomboBox.ValueMember = "Id";
            this.CategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.CategorycomboBox_SelectedIndexChanged);
            // 
            // categoriesBindingSource2
            // 
            this.categoriesBindingSource2.DataMember = "Categories";
            this.categoriesBindingSource2.DataSource = this.warehouseDBDataSetFull;
            // 
            // warehouseDBDataSetFull
            // 
            this.warehouseDBDataSetFull.DataSetName = "WarehouseDBDataSetFull";
            this.warehouseDBDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.ProductdataGridView);
            this.ProductGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGroupBox.Location = new System.Drawing.Point(3, 53);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(530, 590);
            this.ProductGroupBox.TabIndex = 1;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Товар:";
            // 
            // ProductdataGridView
            // 
            this.ProductdataGridView.AllowUserToAddRows = false;
            this.ProductdataGridView.AllowUserToDeleteRows = false;
            this.ProductdataGridView.AutoGenerateColumns = false;
            this.ProductdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.ProductdataGridView.DataSource = this.fKProductsCategoriesBindingSource4;
            this.ProductdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductdataGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductdataGridView.Name = "ProductdataGridView";
            this.ProductdataGridView.ReadOnly = true;
            this.ProductdataGridView.RowHeadersVisible = false;
            this.ProductdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductdataGridView.Size = new System.Drawing.Size(524, 571);
            this.ProductdataGridView.TabIndex = 0;
            this.ProductdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductdataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKProductsCategoriesBindingSource4
            // 
            this.fKProductsCategoriesBindingSource4.DataMember = "FK_Products_Categories";
            this.fKProductsCategoriesBindingSource4.DataSource = this.categoriesBindingSource2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeftToolStripMenuButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 646);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "LeftToolStrip";
            // 
            // LeftToolStripMenuButton
            // 
            this.LeftToolStripMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LeftToolStripMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftToolStripMenuButton.Image")));
            this.LeftToolStripMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftToolStripMenuButton.Name = "LeftToolStripMenuButton";
            this.LeftToolStripMenuButton.Size = new System.Drawing.Size(93, 22);
            this.LeftToolStripMenuButton.Text = "Быстрое меню";
            this.LeftToolStripMenuButton.Click += new System.EventHandler(this.LeftToolStripDeleteButton_Click);
            // 
            // SuppliesInfoGroupBox
            // 
            this.SuppliesInfoGroupBox.Controls.Add(this.RightTableLayoutPanel);
            this.SuppliesInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuppliesInfoGroupBox.Location = new System.Drawing.Point(545, 3);
            this.SuppliesInfoGroupBox.Name = "SuppliesInfoGroupBox";
            this.SuppliesInfoGroupBox.Size = new System.Drawing.Size(536, 696);
            this.SuppliesInfoGroupBox.TabIndex = 1;
            this.SuppliesInfoGroupBox.TabStop = false;
            this.SuppliesInfoGroupBox.Text = "Накладная:";
            // 
            // RightTableLayoutPanel
            // 
            this.RightTableLayoutPanel.ColumnCount = 1;
            this.RightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTableLayoutPanel.Controls.Add(this.InvoiceNameGroupBox, 0, 0);
            this.RightTableLayoutPanel.Controls.Add(this.InvoiceSupplyGroupBox, 0, 3);
            this.RightTableLayoutPanel.Controls.Add(this.InvoiceDateGroupBox, 0, 1);
            this.RightTableLayoutPanel.Controls.Add(this.InvoiceOrgGroupBox, 0, 2);
            this.RightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.RightTableLayoutPanel.Name = "RightTableLayoutPanel";
            this.RightTableLayoutPanel.RowCount = 4;
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTableLayoutPanel.Size = new System.Drawing.Size(530, 677);
            this.RightTableLayoutPanel.TabIndex = 0;
            // 
            // InvoiceNameGroupBox
            // 
            this.InvoiceNameGroupBox.Controls.Add(this.InvoicecomboBox);
            this.InvoiceNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceNameGroupBox.Location = new System.Drawing.Point(3, 3);
            this.InvoiceNameGroupBox.Name = "InvoiceNameGroupBox";
            this.InvoiceNameGroupBox.Size = new System.Drawing.Size(524, 44);
            this.InvoiceNameGroupBox.TabIndex = 0;
            this.InvoiceNameGroupBox.TabStop = false;
            this.InvoiceNameGroupBox.Text = "Название:";
            // 
            // InvoicecomboBox
            // 
            this.InvoicecomboBox.DataSource = this.invoiceBindingSource;
            this.InvoicecomboBox.DisplayMember = "Contract";
            this.InvoicecomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoicecomboBox.FormattingEnabled = true;
            this.InvoicecomboBox.Location = new System.Drawing.Point(3, 16);
            this.InvoicecomboBox.Name = "InvoicecomboBox";
            this.InvoicecomboBox.Size = new System.Drawing.Size(518, 21);
            this.InvoicecomboBox.TabIndex = 0;
            this.InvoicecomboBox.ValueMember = "Id";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.bindingSourceFull;
            // 
            // bindingSourceFull
            // 
            this.bindingSourceFull.DataSource = this.warehouseDBDataSetFull;
            this.bindingSourceFull.Position = 0;
            // 
            // InvoiceSupplyGroupBox
            // 
            this.InvoiceSupplyGroupBox.Controls.Add(this.InvoicedataGridView);
            this.InvoiceSupplyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceSupplyGroupBox.Location = new System.Drawing.Point(3, 153);
            this.InvoiceSupplyGroupBox.Name = "InvoiceSupplyGroupBox";
            this.InvoiceSupplyGroupBox.Size = new System.Drawing.Size(524, 521);
            this.InvoiceSupplyGroupBox.TabIndex = 1;
            this.InvoiceSupplyGroupBox.TabStop = false;
            this.InvoiceSupplyGroupBox.Text = "Поставка:";
            // 
            // InvoicedataGridView
            // 
            this.InvoicedataGridView.AllowUserToAddRows = false;
            this.InvoicedataGridView.AllowUserToDeleteRows = false;
            this.InvoicedataGridView.AutoGenerateColumns = false;
            this.InvoicedataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.InvoicedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.invoiceIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.withoutSaleDataGridViewTextBoxColumn,
            this.withSaleDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.InvoicedataGridView.DataSource = this.fKSuppliesInvoiceBindingSource;
            this.InvoicedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoicedataGridView.Location = new System.Drawing.Point(3, 16);
            this.InvoicedataGridView.Name = "InvoicedataGridView";
            this.InvoicedataGridView.ReadOnly = true;
            this.InvoicedataGridView.RowHeadersVisible = false;
            this.InvoicedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoicedataGridView.Size = new System.Drawing.Size(518, 502);
            this.InvoicedataGridView.TabIndex = 0;
            this.InvoicedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoicedataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // withoutSaleDataGridViewTextBoxColumn
            // 
            this.withoutSaleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.withoutSaleDataGridViewTextBoxColumn.DataPropertyName = "Without_sale";
            this.withoutSaleDataGridViewTextBoxColumn.HeaderText = "Без скидки";
            this.withoutSaleDataGridViewTextBoxColumn.Name = "withoutSaleDataGridViewTextBoxColumn";
            this.withoutSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // withSaleDataGridViewTextBoxColumn
            // 
            this.withSaleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.withSaleDataGridViewTextBoxColumn.DataPropertyName = "With_sale";
            this.withSaleDataGridViewTextBoxColumn.HeaderText = "Со скидкой";
            this.withSaleDataGridViewTextBoxColumn.Name = "withSaleDataGridViewTextBoxColumn";
            this.withSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSuppliesInvoiceBindingSource
            // 
            this.fKSuppliesInvoiceBindingSource.DataMember = "FK_Supplies_Invoice";
            this.fKSuppliesInvoiceBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // InvoiceDateGroupBox
            // 
            this.InvoiceDateGroupBox.Controls.Add(this.textBox1);
            this.InvoiceDateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceDateGroupBox.Location = new System.Drawing.Point(3, 53);
            this.InvoiceDateGroupBox.Name = "InvoiceDateGroupBox";
            this.InvoiceDateGroupBox.Size = new System.Drawing.Size(524, 44);
            this.InvoiceDateGroupBox.TabIndex = 2;
            this.InvoiceDateGroupBox.TabStop = false;
            this.InvoiceDateGroupBox.Text = "Дата:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Date", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(518, 20);
            this.textBox1.TabIndex = 0;
            // 
            // InvoiceOrgGroupBox
            // 
            this.InvoiceOrgGroupBox.Controls.Add(this.textBox2);
            this.InvoiceOrgGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceOrgGroupBox.Location = new System.Drawing.Point(3, 103);
            this.InvoiceOrgGroupBox.Name = "InvoiceOrgGroupBox";
            this.InvoiceOrgGroupBox.Size = new System.Drawing.Size(524, 44);
            this.InvoiceOrgGroupBox.TabIndex = 3;
            this.InvoiceOrgGroupBox.TabStop = false;
            this.InvoiceOrgGroupBox.Text = "Поставщик:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Organization", true));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(518, 20);
            this.textBox2.TabIndex = 0;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.bindingSourceFull;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseDBDataSetFullBindingSource
            // 
            this.warehouseDBDataSetFullBindingSource.DataSource = this.warehouseDBDataSetFull;
            this.warehouseDBDataSetFullBindingSource.Position = 0;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ExcelExportSaveFileDialog
            // 
            this.ExcelExportSaveFileDialog.Filter = "Excel files | *.xlsx";
            // 
            // ExcelExportBindingSource
            // 
            this.ExcelExportBindingSource.DataSource = this.ExcelExportDBDataSet;
            this.ExcelExportBindingSource.Position = 0;
            // 
            // ExcelExportDBDataSet
            // 
            this.ExcelExportDBDataSet.DataSetName = "WarehouseDBDataSet";
            this.ExcelExportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 726);
            this.Controls.Add(this.GlobaltableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 765);
            this.Name = "MainForm";
            this.Text = "Учет товара \"ИП Умарова\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.GlobaltableLayoutPanel.ResumeLayout(false);
            this.LeftTableLayoutPanel.ResumeLayout(false);
            this.LeftTableLayoutPanel.PerformLayout();
            this.CategoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).EndInit();
            this.ProductGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoriesBindingSource4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SuppliesInfoGroupBox.ResumeLayout(false);
            this.RightTableLayoutPanel.ResumeLayout(false);
            this.InvoiceNameGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFull)).EndInit();
            this.InvoiceSupplyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSuppliesInvoiceBindingSource)).EndInit();
            this.InvoiceDateGroupBox.ResumeLayout(false);
            this.InvoiceDateGroupBox.PerformLayout();
            this.InvoiceOrgGroupBox.ResumeLayout(false);
            this.InvoiceOrgGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExportDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductCreateMenuItem;
        private System.Windows.Forms.TableLayoutPanel GlobaltableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LeftTableLayoutPanel;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.DataGridView ProductdataGridView;
        private System.Windows.Forms.GroupBox SuppliesInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel RightTableLayoutPanel;
        private System.Windows.Forms.GroupBox InvoiceNameGroupBox;
        private System.Windows.Forms.GroupBox InvoiceSupplyGroupBox;
        private System.Windows.Forms.BindingSource bindingSourceFull;
        private WarehouseDBDataSetFull warehouseDBDataSetFull;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private WarehouseDBDataSetFullTableAdapters.SuppliesTableAdapter suppliesTableAdapter;
        private System.Windows.Forms.ComboBox InvoicecomboBox;
        private System.Windows.Forms.GroupBox InvoiceDateGroupBox;
        private System.Windows.Forms.GroupBox InvoiceOrgGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridView InvoicedataGridView;
        private System.Windows.Forms.BindingSource fKSuppliesInvoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn withoutSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn withSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem CategoryCreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryUpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductUpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupplyCreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupplyUpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceDeleteMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LeftToolStripMenuButton;
        private System.Windows.Forms.BindingSource categoriesBindingSource2;
        private WarehouseDBDataSetFullTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource warehouseDBDataSetFullBindingSource;
        private System.Windows.Forms.BindingSource fKProductsCategoriesBindingSource4;
        private WarehouseDBDataSetFullTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CategoryListDeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem InvoiceListDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuppliesDeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceCreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceUpdateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ExcelExportMenuItem;
        private System.Windows.Forms.SaveFileDialog ExcelExportSaveFileDialog;
        private System.Windows.Forms.BindingSource ExcelExportBindingSource;
        private WarehouseDBDataSet ExcelExportDBDataSet;
        private System.Windows.Forms.ToolStripMenuItem ExcelPartialExportMenuItem;
    }
}

