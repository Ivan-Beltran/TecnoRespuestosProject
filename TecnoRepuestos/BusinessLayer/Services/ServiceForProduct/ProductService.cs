using CommonLayer.Entities;
using DataAccesLayer.Repositories.ProductsRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ServiceForProduct
{
    public class ProductService
    {
        private readonly ProductsRepository _productsRepository;

        public ProductService(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public DataTable GetCategory()
        {
            return _productsRepository.GetCategory();
        }

        public DataTable GetProducts()
        {
            return _productsRepository.GetProducts();
        }

        public void InsertProduct(Product p)
        {
            _productsRepository.InsertProduct(p);
        }

        public void SavePurchase(
            int supplierId,
            string invoiceNumber,
            string paymentType,
            List<PurchaseItem> items,
            DateTime? creditEndDate = null   // ← opcional, solo si es crédito
            )
        {
            // PurchaseType siempre será "Contribuyente"
            string purchaseType = "Contribuyente";

            // Llamada al repositorio con TODOS los parámetros
            _productsRepository.RegisterPurchase(
                supplierId,
                invoiceNumber,
                purchaseType,
                paymentType,
                items,
                creditEndDate
            );
        }
    }
}
