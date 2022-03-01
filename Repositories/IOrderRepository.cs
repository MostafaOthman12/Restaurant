using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public interface IOrderRepository
    {
        int Delete(int id);
        List<Order> GetAll();
        Order GetById(int id);
        int Insert(Order order);
        int Update(int id, Order orderEdit);
    }
}