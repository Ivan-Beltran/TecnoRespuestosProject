using CommonLayer.Entities;
using DataAccesLayer.Repositories.SuppliersRepo;
using System.Collections.Generic;
using System.Data;
namespace BusinessLayer.Services
{
    public class SupplierService
    {
        private readonly  SuppliersRepository _supplierRepository;

        public SupplierService(SuppliersRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        // Insertar proveedor
        public void AddSupplier(Supplier supplier)
        {
            _supplierRepository.Insert(supplier);
        }

        public DataTable GetSuppliers()
        {
            return _supplierRepository.GetSuppliers();
        }
       
    }
}
