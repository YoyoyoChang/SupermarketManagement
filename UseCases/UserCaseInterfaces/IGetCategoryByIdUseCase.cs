using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}