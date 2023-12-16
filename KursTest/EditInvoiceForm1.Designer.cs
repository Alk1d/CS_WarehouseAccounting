namespace KursTest
{
    partial class EditSupplyForm
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
            this.Savebutton = new System.Windows.Forms.Button();
            this.SupplyNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplyAmounttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplyPricetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplySaletextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InvoicecomboBox = new System.Windows.Forms.ComboBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDBDataSetFull = new KursTest.WarehouseDBDataSetFull();
            this.label7 = new System.Windows.Forms.Label();
            this.SupplyNoSaletextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.invoiceTableAdapter = new KursTest.WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter();
            this.SupplyTotaltextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(182, 406);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(132, 23);
            this.Cancelbutton.TabIndex = 13;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(12, 406);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(131, 23);
            this.Savebutton.TabIndex = 12;
            this.Savebutton.Text = "Сохранить";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // SupplyNametextBox
            // 
            this.SupplyNametextBox.Location = new System.Drawing.Point(12, 103);
            this.SupplyNametextBox.Name = "SupplyNametextBox";
            this.SupplyNametextBox.Size = new System.Drawing.Size(302, 20);
            this.SupplyNametextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Товар:";
            // 
            // SupplyAmounttextBox
            // 
            this.SupplyAmounttextBox.Location = new System.Drawing.Point(12, 159);
            this.SupplyAmounttextBox.Name = "SupplyAmounttextBox";
            this.SupplyAmounttextBox.Size = new System.Drawing.Size(302, 20);
            this.SupplyAmounttextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Количество:";
            // 
            // SupplyPricetextBox
            // 
            this.SupplyPricetextBox.Location = new System.Drawing.Point(12, 205);
            this.SupplyPricetextBox.Name = "SupplyPricetextBox";
            this.SupplyPricetextBox.Size = new System.Drawing.Size(299, 20);
            this.SupplyPricetextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Цена:";
            // 
            // SupplySaletextBox
            // 
            this.SupplySaletextBox.Location = new System.Drawing.Point(12, 311);
            this.SupplySaletextBox.Name = "SupplySaletextBox";
            this.SupplySaletextBox.Size = new System.Drawing.Size(299, 20);
            this.SupplySaletextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Со скидкой:";
            // 
            // InvoicecomboBox
            // 
            this.InvoicecomboBox.DataSource = this.invoiceBindingSource;
            this.InvoicecomboBox.DisplayMember = "Contract";
            this.InvoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoicecomboBox.FormattingEnabled = true;
            this.InvoicecomboBox.Location = new System.Drawing.Point(15, 36);
            this.InvoicecomboBox.Name = "InvoicecomboBox";
            this.InvoicecomboBox.Size = new System.Drawing.Size(299, 21);
            this.InvoicecomboBox.TabIndex = 27;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Накладная:";
            // 
            // SupplyNoSaletextBox
            // 
            this.SupplyNoSaletextBox.Location = new System.Drawing.Point(12, 263);
            this.SupplyNoSaletextBox.Name = "SupplyNoSaletextBox";
            this.SupplyNoSaletextBox.Size = new System.Drawing.Size(299, 20);
            this.SupplyNoSaletextBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Без скидки:";
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // SupplyTotaltextBox
            // 
            this.SupplyTotaltextBox.Location = new System.Drawing.Point(12, 365);
            this.SupplyTotaltextBox.Name = "SupplyTotaltextBox";
            this.SupplyTotaltextBox.Size = new System.Drawing.Size(302, 20);
            this.SupplyTotaltextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Итого:";
            // 
            // EditSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.SupplyTotaltextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplyNoSaletextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InvoicecomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SupplySaletextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupplyPricetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupplyAmounttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplyNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(360, 480);
            this.MinimumSize = new System.Drawing.Size(360, 480);
            this.Name = "EditSupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.EditInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDBDataSetFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox SupplyNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplyAmounttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplyPricetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SupplySaletextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox InvoicecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SupplyNoSaletextBox;
        private System.Windows.Forms.Label label8;
        private WarehouseDBDataSetFull warehouseDBDataSetFull;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private WarehouseDBDataSetFullTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.TextBox SupplyTotaltextBox;
        private System.Windows.Forms.Label label1;
    }
}