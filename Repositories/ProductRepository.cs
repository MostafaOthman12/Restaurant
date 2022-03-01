using Microsoft.EntityFrameworkCore;
using ResturantApp.Models;

namespace ResturantApp.Repositories
{
    public class ProductRepository : IProductRepository
    {

        ResturantAppContext DbRestaurant;
        public ProductRepository(ResturantAppContext resturant)
        {
            DbRestaurant = resturant;
        }

        public List<Product> GetAll()
        {
            List<Product> ProductList = DbRestaurant.Products.ToList();
            return ProductList;
        }
        public Product GetById(int id)
        {
            Product product = DbRestaurant.Products.Include(c => c.Category).FirstOrDefault(s => s.Id == id);
            return product;
        }
        public Product GetByName(string Name)
        {
            Product Product = DbRestaurant.Products.Include(s => s.Category).
                FirstOrDefault(s => s.Name == Name);
            return Product;
        }
        public int Insert(Product product)
        {
            DbRestaurant.Products.Add(product);
            int newProduct = DbRestaurant.SaveChanges();
            return newProduct;
        }
        public int Update(int id, Product productEdit)
        {
            Product oldProduct = DbRestaurant.Products.FirstOrDefault(s => s.Id == id);
            oldProduct.Name = productEdit.Name;
            oldProduct.Description = productEdit.Description;
            oldProduct.Price = productEdit.Price;
            oldProduct.Image = productEdit.Image;
            oldProduct.Type = productEdit.Type;
            oldProduct.CategoryId = productEdit.CategoryId;
            int UpdateProduct = DbRestaurant.SaveChanges();
            return UpdateProduct;
        }
        public int Delete(int id)
        {
            Product deleteProduct = DbRestaurant.Products.FirstOrDefault(s => s.Id == id);
            DbRestaurant.Products.Remove(deleteProduct);
            int deleteeproduct = DbRestaurant.SaveChanges();
            return deleteeproduct;
        }
    }
}
