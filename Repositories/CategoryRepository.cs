using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        ResturantAppContext DbRestaurant;
        public CategoryRepository(ResturantAppContext restaurant)
        {
            DbRestaurant = restaurant;
        }

        public List<Category> GetAll()
        {
            List<Category> categoriesList = DbRestaurant.Categories.ToList();
            return categoriesList;
        }
        public Category GetById(int id)
        {
            Category category = DbRestaurant.Categories.FirstOrDefault(s => s.Id == id);
            return category;
        }
        public Category GetByName(string Name)
        {
            Category category = DbRestaurant.Categories.FirstOrDefault(s => s.Name == Name);
            return category;
        }
        public int Insert(Category category)
        {
            DbRestaurant.Categories.Add(category);
            int newCategory = DbRestaurant.SaveChanges();
            return newCategory;
        }
        public int Update(int id, Category categoryEdit)
        {
            Category oldCategory = DbRestaurant.Categories.FirstOrDefault(s => s.Id == id);
            oldCategory.Name = categoryEdit.Name;
            int UpdateCategory = DbRestaurant.SaveChanges();
            return UpdateCategory;
        }
        public int Delete(int id)
        {
            Category deleteCategory = DbRestaurant.Categories.FirstOrDefault(s => s.Id == id);
            DbRestaurant.Categories.Remove(deleteCategory);
            int deleteeCategory = DbRestaurant.SaveChanges();
            return deleteeCategory;
        }

    }
}
