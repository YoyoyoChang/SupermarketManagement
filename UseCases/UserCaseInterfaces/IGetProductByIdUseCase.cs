using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}