using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductInMemoryRepository()
        {
            _products = new List<Product>()
            {
                new Product{ Id = 1, CategoryId = 1, Name = "Coke", Price = 1.50, Quantity = 20 },
                new Product{ Id = 2, CategoryId = 1, Name = "Doctor Pepper", Price = 1.99, Quantity = 20 },
                new Product{ Id = 3, CategoryId = 2, Name = "Whole Wheat Bread", Price = 1.50, Quantity = 50 },
                new Product{ Id = 4, CategoryId = 2, Name = "White Bread", Price = 1.50, Quantity = 50 },
                new Product{ Id = 5, CategoryId = 4, Name = "白菜", Price = 999999999, Quantity = 1 },
            };    
        }

        public void AddProduct(Product product)
        {
            if (_products.Any(p => p.Id == product.Id))
                return;

            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(c => c.Id);
                product.Id = maxId + 1;
            }
            else
            {
                product.Id = 1;
            }

            _products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}