namespace ShopManagement.Application.Contracts.ProductCategoryContract
{
    public class EditProductCategory : CreateProductCategory
    {
        public long Id { get; set; }

        public string CreationDate { get; set; }

    }
}
