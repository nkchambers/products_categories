using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace products_categories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name for your category.")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Category Name may only contain letters and spaces")]
        public string Name { get; set; }

        
        //Navigation Property for the Many To Many Relationship between Products and Categories (produgory - middle table)
        public List<Produgory> CatHasProd { get; set; } 


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        //This property is exclusivley for our form
        [Display(Name ="Add Product")]
        [NotMapped]
        public List<Product> AvailableProducts { get; set; } = new List<Product>();
    }
}