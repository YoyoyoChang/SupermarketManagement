using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public CategoryInMemoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){ Id = 1, Name = "Beverage", Description = "A good beverage"} ,
                new Category(){ Id = 2, Name = "Bakery", Description = "A good bakery"},
                new Category(){ Id = 3, Name = "Meat", Description = "A good meat"}
            };
        }

        public void AddCategory(Category category)
        {
            if (_categories.Any(c => c.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
                return;

            var maxId = _categories.Max(c => c.Id);
            category.Id = maxId + 1;

            _categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
    }
}