using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace products_categories.Models
{
    public class Produgory
    {
        [Key]
        public int ProdugoryId { get; set; }

        // Foreign Key and Navigation Property for the Category
        [Required]
        public int CategoryId { get; set; }
        public Category CategoryWithProduct { get; set; }


        // Foreign Key and Navigation Property for the Category
        [Required]
        public int ProductId { get; set; }
        public Product ProductInCategory { get; set; }

        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}