using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void EditProduct(Product product);
        Product GetProductById(int productId);
    }
}