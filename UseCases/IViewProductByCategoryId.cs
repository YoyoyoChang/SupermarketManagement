using CoreBusiness;

namespace UseCases
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}