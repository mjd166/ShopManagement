using _0_Framework.Operation;
using ShopManagement.Application.Contracts.ProductCategoryContract;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Linq.Expressions;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _repository;

        public ProductCategoryApplication(IProductCategoryRepository repository)
        {
            this._repository = repository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_repository.Exists(x => x.Name.Contains(command.Name)))
                return operation.Failed("امکان وارد کردن رکورد تکراری وجود ندارد لطفا مجدد سعی نمایید");

            var productcategory = new ProductCategory(command.Name, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Description, command.MetaDescription, command.Keywords);
            _repository.Add(productcategory);
            return operation.Successed();


        }

        public OperationResult Edit(Contracts.ProductCategoryContract.EditProductCategory command)
        {
            var operation = new OperationResult();
            var productcategory = _repository.Get(command.Id);
            if (productcategory == null)
                return operation.Failed("رکوردی با مشخصات موردنظر یافت نشد");

            if (_repository.Exists(x => x.Name.Contains(command.Name) && x.Id != command.Id))
                return operation.Failed("امکان وارد کردن رکورد تکراری وجود ندارد لطفا مجدد سعی نمایید");

            productcategory.Edit(command.Name, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Description, command.MetaDescription, command.Keywords);
            _repository.Update(productcategory);
            return operation.Successed();
        }

        public bool Exists(ProductCategorySearchViewModel searchModel)
        {
            return _repository.Exists(x => x.Name.Contains(searchModel.Name));
        }

       
    }
}
