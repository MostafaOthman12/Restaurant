using ResturantApp.Repositories;
using ResturantApp.ViewModels;

namespace ResturantApp.Services
{
    public class CategoryService : ICategoriesService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public int Delete(int id)
        {
            if (id == 0) return 0;
            return categoryRepository.Delete(id);
        }

        public List<CategoryViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public int Insert(CategoryViewModel category)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, CategoryViewModel categoryEdit)
        {
            throw new NotImplementedException();
        }
    }
}
