using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IDeleteCategoryUseCase
    {
        void Execute(int categoryId);
    }
}