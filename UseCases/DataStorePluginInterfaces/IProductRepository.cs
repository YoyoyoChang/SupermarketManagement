using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
    }
}