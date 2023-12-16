namespace KursTest
{
    partial class EditProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSetFull = new KursTest.WarehouseDBDataSetFull();
            this.ProductNametextBox = new System.Windows.Forms.TextBox();
            this.ProductPricetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductAmounttextBox = new System.Windows.Forms.TextBox();
            this.categoriesTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.CategoriesTableAdapter();
            this.fKProductsCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.ProductsTableAdapter();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название товара:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена товара:";
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.DataSource = this.categoriesBindingSource;
            this.CategorycomboBox.DisplayMember = "Title";
            this.CategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(30, 66);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(355, 21);
            this.CategorycomboBox.TabIndex = 3;
            this.CategorycomboBox.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.warehouseDBDataSetFull;
            // 
            // warehouseDBDataSetFull
            // 
            this.warehouseDBDataSetFull.DataSetName = "WarehouseDBDataSetFull";
            this.warehouseDBDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductNametextBox
            // 
            this.ProductNametextBox.Location = new System.Drawing.Point(30, 143);
            this.ProductNametextBox.Name = "ProductNametextBox";
            this.ProductNametextBox.Size = new System.Drawing.Size(355, 20);
            this.ProductNametextBox.TabIndex = 4;
            // 
            // ProductPricetextBox
            // 
            this.ProductPricetextBox.Location = new System.Drawing.Point(30, 223);
            this.ProductPricetextBox.Name = "ProductPricetextBox";
            this.ProductPricetextBox.Size = new System.Drawing.Size(355, 20);
            this.ProductPricetextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество товара:";
            // 
            // ProductAmounttextBox
            // 
            this.ProductAmounttextBox.Location = new System.Drawing.Point(30, 301);
            this.ProductAmounttextBox.Name = "ProductAmounttextBox";
            this.ProductAmounttextBox.Size = new System.Drawing.Size(355, 20);
            this.ProductAmounttextBox.TabIndex = 7;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // fKProductsCategoriesBindingSource
            // 
            this.fKProductsCategoriesBindingSource.DataMember = "FK_Products_Categories";
            this.fKProductsCategoriesBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(253, 366);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(132, 23);
            this.Cancelbutton.TabIndex = 11;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(30, 366);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(131, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Сохранить";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 411);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.ProductAmounttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductPricetextBox);
            this.Controls.Add(this.ProductNametextBox);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Товар";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.TextBox ProductNametextBox;
        private System.Windows.Forms.TextBox ProductPricetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductAmounttextBox;
        private WarehouseDBDataSetFull warehouseDBDataSetFull;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WarehouseDBDataSetFullTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource fKProductsCategoriesBindingSource;
        private WarehouseDBDataSetFullTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Savebutton;
    }
}