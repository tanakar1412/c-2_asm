using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBLL
    {

        OrderDAL orderDAL = new OrderDAL();
        public List<Order> GetAllOrders()
        {
            var order = orderDAL.GetAllOrders();
            return order;
        }
    }
}
