using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace products_categories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name for your prodcut.")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "First Name may only contain letters and spaces")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage ="Please provide a description for your new product.")]
        [MinLength(3, ErrorMessage = "Product description must be at least 3 characters long.")]
        public string Description { get; set; }


        [Display(Name = "Price")]
        [Required(ErrorMessage ="Please provide the price of your new product.")]
        public double Price { get; set; }


        //Foreign Key for the Category the product belongs to
        public int CategoryId { get; set; }


        //Navigation Property for that category
        public Category ProductIn { get; set; }


        //Navigation Property for the Many To Many Relationship between Products and Categories (produgory - middle table)
        public List<Produgory> ProdInCat { get; set; } 


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        //This property is exclusivley for our form
        [Display(Name ="Add Category")]
        [NotMapped]
        public List<Category> AvailableCategories { get; set; } = new List<Category>();

    }
}