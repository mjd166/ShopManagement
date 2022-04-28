using _0_Framework.Infrastructure;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Linq.Expressions;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : RepositoryBase<long,ProductCategory>, IProductCategoryRepository
    {
        private readonly ShopContext _shopContext;

        public ProductCategoryRepository(ShopContext shopContext):base(shopContext)
        {
            _shopContext = shopContext;
        }

      
    }
}
