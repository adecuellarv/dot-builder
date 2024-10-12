﻿using System.ComponentModel.DataAnnotations;

namespace BuilderAPIs.Domain.Entities
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemContent { get; set; } = string.Empty;
        public int ComponentId { get; set; }
        public string ComponentOrder { get; set; } = string.Empty;
        public int UserId { get; set; }
    }
}