using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}