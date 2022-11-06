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

            if (_categories != null && _categories.Count > 0)
            {
                var maxId = _categories.Max(c => c.Id);
                category.Id = maxId + 1;
            }
            else
            {
                category.Id = 1;
            }

            _categories.Add(category);
        }

        public void DeleteCategory(int categoryId)
        {
            var categoryToRemove = GetCategoryById(categoryId);

            _categories?.Remove(categoryToRemove);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categories?.FirstOrDefault(c => c.Id == categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Id = category.Id;
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }
    }
}