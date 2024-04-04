using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        MasterContext dbContext = new MasterContext();

        
        public List<Order> GetAllOrders()
        {
            return dbContext.Orders.ToList();
        }
    }
}
