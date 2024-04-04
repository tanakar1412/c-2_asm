using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        MasterContext dbContext = new MasterContext();
        public List<Customer> GetAllCustomer()
        {
            return dbContext.Customers.ToList();
        }
    }
}
