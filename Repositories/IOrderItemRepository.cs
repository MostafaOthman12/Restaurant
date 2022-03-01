using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public interface IOrderItemRepository
    {
        int Delete(int id);
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
    }
}