using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class Frameworks
    {
        [Key]
        public int FrameworkId { get; set; }
        public string FrameworkName { get; set; } = string.Empty;
        public int FrameworkCategoryID { get; set; }
    }
}
