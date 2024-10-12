using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
