using CommonLayer.Entities;
using DataAccesLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.ProductsRepo
{
    public class ProductsRepository
    {
        private SqlConnect _dbConnection;

        public ProductsRepository(SqlConnect _connection)
        {
            _dbConnection = _connection;
        }

        public DataTable GetCategory()
        {
            DataTable dt = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("GetCategoryProducts", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetProducts()
        {
            DataTable dt = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetProducts", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void InsertProduct(Product p)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertProduct", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CategoryId", p.CategoryId);
                    cmd.Parameters.AddWithValue("@Code", p.Code);
                    cmd.Parameters.AddWithValue("@Brand", p.Brand);
                    cmd.Parameters.AddWithValue("@ProductName", p.ProductName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Model", p.Model ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RegisterPurchase(
            int supplierId,
            string invoiceNumber,
            string purchaseType,
            string paymentType,
            List<PurchaseItem> items,
            DateTime? creditEndDate   
        )
        {
            using (var connection = _dbConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_RegisterPurchase", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                //-----------------------------------------------------
                // Parámetros normales
                //-----------------------------------------------------
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
                cmd.Parameters.AddWithValue("@PurchaseType", purchaseType);
                cmd.Parameters.AddWithValue("@PaymentType", paymentType);

                //-----------------------------------------------------
                // Parámetro nuevo: CreditEndDate
                //-----------------------------------------------------
                if (paymentType == "Credito")
                    cmd.Parameters.AddWithValue("@CreditEndDate", creditEndDate);
                else
                    cmd.Parameters.AddWithValue("@CreditEndDate", DBNull.Value);

                //-----------------------------------------------------
                // Crear DataTable para el TVP
                //-----------------------------------------------------
                DataTable itemsTable = new DataTable();
                itemsTable.Columns.Add("ProductId", typeof(int));
                itemsTable.Columns.Add("Quantity", typeof(int));
                itemsTable.Columns.Add("UnitCost", typeof(decimal));
                itemsTable.Columns.Add("UnitPrice", typeof(decimal));

                foreach (var item in items)
                {
                    itemsTable.Rows.Add(item.ProductId, item.Quantity, item.UnitCost, item.UnitPrice);
                }

                //-----------------------------------------------------
                // Parámetro tipo tabla
                //-----------------------------------------------------
                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@Items", itemsTable);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "PurchaseItemType";

                //-----------------------------------------------------
                // Ejecutar SP
                //-----------------------------------------------------
                
                cmd.ExecuteNonQuery();
            }
        }

    }
}
