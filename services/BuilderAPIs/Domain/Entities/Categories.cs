using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryNameEsp { get; set; } = string.Empty;
        public string CategoryNameEn { get; set; } = string.Empty;
    }
}
