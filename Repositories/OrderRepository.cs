using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        ResturantAppContext DbRestaurant;
        public OrderRepository(ResturantAppContext resturant)
        {
            DbRestaurant = resturant;
        }
        public List<Order> GetAll()
        {
            List<Order> ordersList = DbRestaurant.Orders.ToList();
            return ordersList;
        }
        public Order GetById(int id)
        {
            Order order = DbRestaurant.Orders.FirstOrDefault(o => o.Id == id);
            return order;
        }
        //public Product GetByName(string Name)
        //{
        //    Product Product = DbRestaurant.Products.Include(s => s.category).
        //        FirstOrDefault(s => s.Name == Name);
        //    return Product;
        //}
        public int Insert(Order order)
        {
            DbRestaurant.Orders.Add(order);
            int newOrder = DbRestaurant.SaveChanges();
            return newOrder;
        }
        public int Update(int id, Order orderEdit)
        {
            Order oldOrder = DbRestaurant.Orders.FirstOrDefault(s => s.Id == id);
            oldOrder.Date = orderEdit.Date;
            oldOrder.FinalPrice = orderEdit.FinalPrice;
            oldOrder.UserId = orderEdit.UserId;
            int UpdateOrder = DbRestaurant.SaveChanges();
            return UpdateOrder;
        }
        public int Delete(int id)
        {
            Order deleteOrder = DbRestaurant.Orders.FirstOrDefault(s => s.Id == id);
            DbRestaurant.Orders.Remove(deleteOrder);
            int deleteeOrder = DbRestaurant.SaveChanges();
            return deleteeOrder;
        }
    }
}
