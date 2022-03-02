using ResturantApp.ViewModels;

namespace ResturantApp.Services
{
    public interface ICategoriesService
    {
        int Delete(int id);
        List<CategoryViewModel> GetAll();
        CategoryViewModel GetById(int id);
        CategoryViewModel GetByName(string Name);
        int Insert(CategoryViewModel category);
        int Update(int id, CategoryViewModel categoryEdit);
    }
}
