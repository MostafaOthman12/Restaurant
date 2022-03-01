using Microsoft.EntityFrameworkCore;
using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {

        ResturantAppContext DbRestaurant;
        public OrderItemRepository(ResturantAppContext resturant)
        {
            DbRestaurant = resturant;
        }
        public List<OrderItem> GetAll()
        {
            List<OrderItem> orderItemsList = DbRestaurant.OrderItems.ToList();
            return orderItemsList;
        }
        public OrderItem GetById(int id)
        {
            OrderItem orderItems = DbRestaurant.OrderItems.Include(c => c.Prouduct).Include(o => o.Order).FirstOrDefault(s => s.Id == id);
            return orderItems;
        }
        //public OrderItems GetByName(string Name)
        //{
        //    OrderItems orderItems = DbRestaurant.OrderItems.Include(p => p.product).Include(o=>o.order).
        //        FirstOrDefault(s => s.Name == Name);
        //    return Product;
        //}
        //public int Insert(Product product)
        //{
        //    DbRestaurant.Products.Add(product);
        //    int newProduct = DbRestaurant.SaveChanges();
        //    return newProduct;
        //}
        //public int Update(int id, Product productEdit)
        //{
        //    Product oldProduct = DbRestaurant.Products.FirstOrDefault(s => s.Id == id);
        //    oldProduct.Name = productEdit.Name;
        //    oldProduct.Description = productEdit.Description;
        //    oldProduct.Price = productEdit.Price;
        //    oldProduct.Image = productEdit.Image;
        //    oldProduct.Type = productEdit.Type;
        //    oldProduct.Category_Id = productEdit.Category_Id;
        //    int UpdateProduct = DbRestaurant.SaveChanges();
        //    return UpdateProduct;
        //}
        public int Delete(int id)
        {
            OrderItem deleteOrderItem = DbRestaurant.OrderItems.FirstOrDefault(s => s.Id == id);
            DbRestaurant.OrderItems.Remove(deleteOrderItem);
            int deleteeOrderItem = DbRestaurant.SaveChanges();
            return deleteeOrderItem;
        }
    }
}
