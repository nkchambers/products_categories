using System.Collections.Generic;


namespace products_categories.Models
{
    public class CategoriesView
    {
        public Category Form { get; set; }
        public List<Category> AllCategories { get; set; }
    }
}