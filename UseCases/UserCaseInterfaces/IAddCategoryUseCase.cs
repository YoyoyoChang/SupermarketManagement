using CoreBusiness;

namespace UseCases.UserCaseInterfaces
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}