using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepository _productRepository;

        public ViewProductByCategoryId(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(int categoryId)
        {
            return _productRepository.GerProductsByCategory(categoryId);
        }
    }
}
