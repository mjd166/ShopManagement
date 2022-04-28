using _0_Framework.Domain;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public class ProductCategory : DomainBase<long>
    {
        public string Name { get;private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Description { get; private set; }
        public string MetaDescription { get; private set; }
        public string Keywords { get; private set; }

        public ProductCategory(string name, string picture, string pictureAlt, string pictureTitle, string slug, string description, string metaDescription, string keywords)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Description = description;
            MetaDescription = metaDescription;
            Keywords = keywords;
        }

        public void Edit(string name, string picture, string pictureAlt, string pictureTitle, string slug, string description, string metaDescription, string keywords)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Description = description;
            MetaDescription = metaDescription;
            Keywords = keywords;
        }
    }
}
