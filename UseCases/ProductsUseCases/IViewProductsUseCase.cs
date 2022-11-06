using CoreBusiness;

namespace UseCases.ProductsUseCases
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}