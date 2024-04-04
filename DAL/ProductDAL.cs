using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        MasterContext dbContext = new MasterContext();
        public List<Product> GetAllProduct()
        {
            return dbContext.Products.ToList();
        }
        
        public List<Customer> GetAllCustomer()
        {
            return dbContext.Customers.ToList();
        }

        public List<Order> GetAllOrders()
        {
            return dbContext.Orders.ToList();
        }
    }
}
