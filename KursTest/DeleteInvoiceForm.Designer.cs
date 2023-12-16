namespace KursTest
{
    partial class DeleteInvoiceForm
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
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.InvoicecomboBox = new System.Windows.Forms.ComboBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSetFull = new KursTest.WarehouseDBDataSetFull();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(234, 71);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(129, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Deletebutton.Location = new System.Drawing.Point(14, 71);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(133, 23);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // InvoicecomboBox
            // 
            this.InvoicecomboBox.DataSource = this.invoiceBindingSource;
            this.InvoicecomboBox.DisplayMember = "Contract";
            this.InvoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoicecomboBox.FormattingEnabled = true;
            this.InvoicecomboBox.Location = new System.Drawing.Point(14, 29);
            this.InvoicecomboBox.Name = "InvoicecomboBox";
            this.InvoicecomboBox.Size = new System.Drawing.Size(349, 21);
            this.InvoicecomboBox.TabIndex = 5;
            this.InvoicecomboBox.ValueMember = "Id";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.warehouseDBDataSetFull;
            // 
            // warehouseDBDataSetFull
            // 
            this.warehouseDBDataSetFull.DataSetName = "WarehouseDBDataSetFull";
            this.warehouseDBDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Накладная:";
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 106);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.InvoicecomboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(390, 145);
            this.MinimumSize = new System.Drawing.Size(390, 145);
            this.Name = "DeleteInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить накладную";
            this.Load += new System.EventHandler(this.DeleteInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ComboBox InvoicecomboBox;
        private System.Windows.Forms.Label label1;
        private WarehouseDBDataSetFull warehouseDBDataSetFull;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
    }
}