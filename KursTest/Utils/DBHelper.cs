using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KursTest.Utils
{
    public enum TableFieldTypes
    {
        integer,
        nvarchar
    }
    public class TableField
    {
        public string TableFieldValue { get; set; }
        public TableFieldTypes TableFieldType { get; set; }
    }

    public class FieldForUpdate
    {
        public string FieldName { get; set; }
        public TableField FieldValue { get; set; }
    }
    public static class DBHelper
    {
        public static List<string> SelectValuesFromTable(string tableName, int Id)
        {
            var result = new List<string>();

            var conn = new SqlConnection(Properties.Settings.Default.WarehouseDBConnectionString);
            var query = $"SELECT *  FROM {tableName} WHERE {Constants.FieldNames.Id} = {Id}";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Clear();
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    result.Add(reader[i].ToString());
                }
            }
            return result;
        }

        public static int InsertEntry(string tableName, Dictionary<string, TableField> fields)
        {
            var result = 0;

            var conn = new SqlConnection(Properties.Settings.Default.WarehouseDBConnectionString);
            var fieldsNames = string.Join(",", fields.Select(f => f.Key));
            var fieldsValues = string.Join(",", fields.Select(f =>
            {

                if (f.Value.TableFieldType == TableFieldTypes.integer)
                {
                    return f.Value.TableFieldValue;
                }
                return $"'{f.Value.TableFieldValue}'";
            }));

            var query = $"INSERT INTO {tableName} ({fieldsNames}) VALUES ({fieldsValues})";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            var selectLastItemQuery = $"SELECT TOP 1 Id FROM {tableName} ORDER BY Id DESC";
            var selectLastItemcmd = new SqlCommand(selectLastItemQuery, conn);
            conn.Open();
            var reader = selectLastItemcmd.ExecuteReader();
            while (reader.Read())
            {
                int.TryParse(reader[0].ToString(), out result);
            }
            conn.Close();

            return result;
        }
        public static void UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
        {
            var conn = new SqlConnection(Properties.Settings.Default.WarehouseDBConnectionString);
            var updatingFieldsValues = string.Join(",", fields.Select(f =>
            {
                var fieldValue = string.Empty;
                if (f.Value.TableFieldType == TableFieldTypes.integer)
                {
                    fieldValue = f.Value.TableFieldValue;
                }
                else
                {
                    fieldValue = $"'{f.Value.TableFieldValue}'";
                }
                return $"{f.Key}={fieldValue}";
            }));
            var query = $"UPDATE {tableName} SET {updatingFieldsValues} WHERE {Constants.FieldNames.Id}={id}";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public static void DeleteEntry(string tableName, FieldForUpdate fieldForUpdate)
        {
            var fieldValue = string.Empty;
            if (fieldForUpdate.FieldValue.TableFieldType == TableFieldTypes.integer)
            {
                fieldValue = fieldForUpdate.FieldValue.TableFieldValue;
            }
            else
            {
                fieldValue = $"'{fieldForUpdate.FieldValue.TableFieldValue}'";
            }

            var conn = new SqlConnection(Properties.Settings.Default.WarehouseDBConnectionString);
            var query = $"DELETE FROM {tableName} WHERE {fieldForUpdate.FieldName}={fieldValue}";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteEntry(string tableName, int id)
        {
            DeleteEntry(tableName, new FieldForUpdate{
                FieldName = Constants.FieldNames.Id,
                FieldValue = new TableField
                {
                    TableFieldType = TableFieldTypes.integer,
                    TableFieldValue = id.ToString()
                }
                });

        }

    }
}
