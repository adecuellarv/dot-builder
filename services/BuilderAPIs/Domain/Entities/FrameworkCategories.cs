using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class FrameworkCategories
    {
        [Key]
        public int FrameworkCategoryId { get; set; }
        public string FrameworkCategoryName { get; set;} = string.Empty;
    }
}
