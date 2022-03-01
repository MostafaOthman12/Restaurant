using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public interface IProductRepository
    {
        int Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
        Product GetByName(string Name);
        int Insert(Product product);
        int Update(int id, Product productEdit);
    }
}