namespace ResturantApp.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<ProductViewModel> Products { get; set; }

        public CategoryViewModel()
        {
            Products = new List<ProductViewModel>();
        }
    }
}
