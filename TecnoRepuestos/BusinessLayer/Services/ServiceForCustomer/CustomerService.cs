using CommonLayer.Entities;
using DataAccesLayer.Repositories.CustomersRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ServiceForCustomer
{
    public class CustomerService
    {
        private CustomersRepository _customersRepository;

        public CustomerService(CustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        public DataTable GetCustomers()
        {
           return  _customersRepository.GetCustomers();
        }

        public void InsertCustomer(Customer customer)
        {
            _customersRepository.InsertCustomer(customer);
        }
    }
}
