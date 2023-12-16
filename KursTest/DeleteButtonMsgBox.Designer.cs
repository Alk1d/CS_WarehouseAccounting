namespace KursTest
{
    partial class MenuToolstripBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryradioButton = new System.Windows.Forms.RadioButton();
            this.ProductradioButton = new System.Windows.Forms.RadioButton();
            this.InvoiceradioButton = new System.Windows.Forms.RadioButton();
            this.SuppliesradioButton = new System.Windows.Forms.RadioButton();
            this.UpdateradioButton = new System.Windows.Forms.RadioButton();
            this.CreateradioButton = new System.Windows.Forms.RadioButton();
            this.DeleteradioButton = new System.Windows.Forms.RadioButton();
            this.ItemsgroupBox = new System.Windows.Forms.GroupBox();
            this.SelectModegroupBox = new System.Windows.Forms.GroupBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Acceptbutton = new System.Windows.Forms.Button();
            this.ItemsgroupBox.SuspendLayout();
            this.SelectModegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите элементы";
            // 
            // CategoryradioButton
            // 
            this.CategoryradioButton.AutoSize = true;
            this.CategoryradioButton.Checked = true;
            this.CategoryradioButton.Location = new System.Drawing.Point(10, 19);
            this.CategoryradioButton.Name = "CategoryradioButton";
            this.CategoryradioButton.Size = new System.Drawing.Size(78, 17);
            this.CategoryradioButton.TabIndex = 1;
            this.CategoryradioButton.TabStop = true;
            this.CategoryradioButton.Text = "Категория";
            this.CategoryradioButton.UseVisualStyleBackColor = true;
            // 
            // ProductradioButton
            // 
            this.ProductradioButton.AutoSize = true;
            this.ProductradioButton.Location = new System.Drawing.Point(10, 54);
            this.ProductradioButton.Name = "ProductradioButton";
            this.ProductradioButton.Size = new System.Drawing.Size(56, 17);
            this.ProductradioButton.TabIndex = 2;
            this.ProductradioButton.TabStop = true;
            this.ProductradioButton.Text = "Товар";
            this.ProductradioButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceradioButton
            // 
            this.InvoiceradioButton.AutoSize = true;
            this.InvoiceradioButton.Location = new System.Drawing.Point(94, 19);
            this.InvoiceradioButton.Name = "InvoiceradioButton";
            this.InvoiceradioButton.Size = new System.Drawing.Size(81, 17);
            this.InvoiceradioButton.TabIndex = 3;
            this.InvoiceradioButton.TabStop = true;
            this.InvoiceradioButton.Text = "Накладная";
            this.InvoiceradioButton.UseVisualStyleBackColor = true;
            // 
            // SuppliesradioButton
            // 
            this.SuppliesradioButton.AutoSize = true;
            this.SuppliesradioButton.Location = new System.Drawing.Point(94, 54);
            this.SuppliesradioButton.Name = "SuppliesradioButton";
            this.SuppliesradioButton.Size = new System.Drawing.Size(74, 17);
            this.SuppliesradioButton.TabIndex = 4;
            this.SuppliesradioButton.TabStop = true;
            this.SuppliesradioButton.Text = "Поставка";
            this.SuppliesradioButton.UseVisualStyleBackColor = true;
            // 
            // UpdateradioButton
            // 
            this.UpdateradioButton.AutoSize = true;
            this.UpdateradioButton.Location = new System.Drawing.Point(5, 42);
            this.UpdateradioButton.Name = "UpdateradioButton";
            this.UpdateradioButton.Size = new System.Drawing.Size(76, 17);
            this.UpdateradioButton.TabIndex = 6;
            this.UpdateradioButton.TabStop = true;
            this.UpdateradioButton.Text = "Изменить";
            this.UpdateradioButton.UseVisualStyleBackColor = true;
            // 
            // CreateradioButton
            // 
            this.CreateradioButton.AutoSize = true;
            this.CreateradioButton.Checked = true;
            this.CreateradioButton.Location = new System.Drawing.Point(6, 19);
            this.CreateradioButton.Name = "CreateradioButton";
            this.CreateradioButton.Size = new System.Drawing.Size(75, 17);
            this.CreateradioButton.TabIndex = 5;
            this.CreateradioButton.TabStop = true;
            this.CreateradioButton.Text = "Добавить";
            this.CreateradioButton.UseVisualStyleBackColor = true;
            // 
            // DeleteradioButton
            // 
            this.DeleteradioButton.AutoSize = true;
            this.DeleteradioButton.Location = new System.Drawing.Point(6, 65);
            this.DeleteradioButton.Name = "DeleteradioButton";
            this.DeleteradioButton.Size = new System.Drawing.Size(68, 17);
            this.DeleteradioButton.TabIndex = 7;
            this.DeleteradioButton.TabStop = true;
            this.DeleteradioButton.Text = "Удалить";
            this.DeleteradioButton.UseVisualStyleBackColor = true;
            // 
            // ItemsgroupBox
            // 
            this.ItemsgroupBox.Controls.Add(this.CategoryradioButton);
            this.ItemsgroupBox.Controls.Add(this.InvoiceradioButton);
            this.ItemsgroupBox.Controls.Add(this.ProductradioButton);
            this.ItemsgroupBox.Controls.Add(this.SuppliesradioButton);
            this.ItemsgroupBox.Location = new System.Drawing.Point(12, 25);
            this.ItemsgroupBox.Name = "ItemsgroupBox";
            this.ItemsgroupBox.Size = new System.Drawing.Size(200, 100);
            this.ItemsgroupBox.TabIndex = 10;
            this.ItemsgroupBox.TabStop = false;
            this.ItemsgroupBox.Text = "Предмет";
            // 
            // SelectModegroupBox
            // 
            this.SelectModegroupBox.Controls.Add(this.CreateradioButton);
            this.SelectModegroupBox.Controls.Add(this.UpdateradioButton);
            this.SelectModegroupBox.Controls.Add(this.DeleteradioButton);
            this.SelectModegroupBox.Location = new System.Drawing.Point(12, 131);
            this.SelectModegroupBox.Name = "SelectModegroupBox";
            this.SelectModegroupBox.Size = new System.Drawing.Size(200, 100);
            this.SelectModegroupBox.TabIndex = 11;
            this.SelectModegroupBox.TabStop = false;
            this.SelectModegroupBox.Text = "Режим";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(137, 237);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 11;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Acceptbutton
            // 
            this.Acceptbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Acceptbutton.Location = new System.Drawing.Point(12, 237);
            this.Acceptbutton.Name = "Acceptbutton";
            this.Acceptbutton.Size = new System.Drawing.Size(74, 23);
            this.Acceptbutton.TabIndex = 10;
            this.Acceptbutton.Text = "Применить";
            this.Acceptbutton.UseVisualStyleBackColor = true;
            this.Acceptbutton.Click += new System.EventHandler(this.Acceptbutton_Click);
            // 
            // MenuToolstripBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.SelectModegroupBox);
            this.Controls.Add(this.Acceptbutton);
            this.Controls.Add(this.ItemsgroupBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(250, 320);
            this.MinimumSize = new System.Drawing.Size(250, 320);
            this.Name = "MenuToolstripBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Меню";
            this.ItemsgroupBox.ResumeLayout(false);
            this.ItemsgroupBox.PerformLayout();
            this.SelectModegroupBox.ResumeLayout(false);
            this.SelectModegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CategoryradioButton;
        private System.Windows.Forms.RadioButton ProductradioButton;
        private System.Windows.Forms.RadioButton InvoiceradioButton;
        private System.Windows.Forms.RadioButton SuppliesradioButton;
        private System.Windows.Forms.RadioButton UpdateradioButton;
        private System.Windows.Forms.RadioButton CreateradioButton;
        private System.Windows.Forms.RadioButton DeleteradioButton;
        private System.Windows.Forms.GroupBox ItemsgroupBox;
        private System.Windows.Forms.GroupBox SelectModegroupBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Acceptbutton;
    }
}