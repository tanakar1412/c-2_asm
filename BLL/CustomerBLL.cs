using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public List<Customer> GetAllCustomer()
        {
            var customer = customerDAL.GetAllCustomer();
            return customer;
        }

    }
}
