using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class Components
    {
        [Key]
        public int ComponentID { get; set; }
        public string ComponentName { get; set; } = string.Empty;
        public string ComponentImage { get; set; } = string.Empty;
        public int FrameworkID {  get; set; }
        public int CategoryID { get; set; }
    }
}
