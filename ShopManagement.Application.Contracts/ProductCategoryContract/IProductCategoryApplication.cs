using _0_Framework.Operation;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Linq.Expressions;

namespace ShopManagement.Application.Contracts.ProductCategoryContract
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
        bool Exists(ProductCategorySearchViewModel searchModel);

      ///  List<EditProductCategory> GetDetails();
        

    }
}
