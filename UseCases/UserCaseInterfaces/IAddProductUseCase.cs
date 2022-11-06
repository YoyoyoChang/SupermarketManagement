using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}