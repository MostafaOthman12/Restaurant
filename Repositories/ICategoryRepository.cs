using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public interface ICategoryRepository
    {
        int Delete(int id);
        List<Category> GetAll();
        Category GetById(int id);
        Category GetByName(string Name);
        int Insert(Category category);
        int Update(int id, Category categoryEdit);
    }
}