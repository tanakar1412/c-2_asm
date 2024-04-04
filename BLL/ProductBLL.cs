using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
 
        OrderDAL orderDAL = new OrderDAL();

        public List<Product> GetAllProduct()
        {
            var product = productDAL.GetAllProduct();
            return product;
        }

      
        public List<Order> GetAllOrder()
        {
            var order = orderDAL.GetAllOrders();
            return order;
        }
    }
}
