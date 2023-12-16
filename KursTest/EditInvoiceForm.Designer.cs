namespace KursTest
{
    partial class InvoiceFormEdit
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
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.InvoiceTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrganizationTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTitle = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(227, 176);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(132, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Savebutton.Location = new System.Drawing.Point(25, 176);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(131, 23);
            this.Savebutton.TabIndex = 6;
            this.Savebutton.Text = "Сохранить";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // InvoiceTitle
            // 
            this.InvoiceTitle.Location = new System.Drawing.Point(25, 37);
            this.InvoiceTitle.Name = "InvoiceTitle";
            this.InvoiceTitle.Size = new System.Drawing.Size(334, 20);
            this.InvoiceTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название накладной:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата:*";
            // 
            // OrganizationTitle
            // 
            this.OrganizationTitle.Location = new System.Drawing.Point(25, 139);
            this.OrganizationTitle.Name = "OrganizationTitle";
            this.OrganizationTitle.Size = new System.Drawing.Size(334, 20);
            this.OrganizationTitle.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поставщик:*";
            // 
            // DateTitle
            // 
            this.DateTitle.Location = new System.Drawing.Point(27, 88);
            this.DateTitle.Mask = "00/00/0000";
            this.DateTitle.Name = "DateTitle";
            this.DateTitle.Size = new System.Drawing.Size(332, 20);
            this.DateTitle.TabIndex = 12;
            this.DateTitle.ValidatingType = typeof(System.DateTime);
            // 
            // InvoiceFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 211);
            this.Controls.Add(this.DateTitle);
            this.Controls.Add(this.OrganizationTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.InvoiceTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(405, 250);
            this.MinimumSize = new System.Drawing.Size(405, 250);
            this.Name = "InvoiceFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Накладная";
            this.Load += new System.EventHandler(this.InvoiceFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox InvoiceTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrganizationTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DateTitle;
    }
}