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
        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
    }
}