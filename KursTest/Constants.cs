using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursTest
{
    /// <summary>
    /// Класс констант 
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// имена таблиц
        /// </summary>
        public static class TableNames
        {
            public const string CategoriesTableName = "Categories";
            public const string ProductsTableName = "Products";
            public const string InvoiceTableName = "Invoice";
            public const string SuppliesTableName = "Supplies";
        }
        /// <summary>
        /// имена столбцов таблиц
        /// </summary>
        public static class FieldNames
        {
            public const string Id = "Id";
            public static class CategoriesTable
            {
                public const string Title = "Title";
            }
            public static class ProductsTable
            {
                public const string CategoryId = "CategoryId";
                public const string Name = "Name";
                public const string Price = "Price";
                public const string Amount = "Amount";
            }
            public static class InvoiceTable
            {
                public const string Contract = "Contract";
                public const string Date = "Date";
                public const string Organization = "Organization";
            }
            public static class SuppliesTable
            {
                public const string InvoiceId = "InvoiceId";
                public const string Product = "Product";
                public const string Amount = "Amount";
                public const string Price = "Price";
                public const string Without_sale = "Without_sale";
                public const string With_sale = "With_sale";
                public const string Total = "Total";
            }
        }
    }
}
