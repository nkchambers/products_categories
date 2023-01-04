using System.Collections.Generic;


namespace products_categories.Models
{
    public class ProductsView
    {
        public Product Form { get; set; }
        public List<Product> AllProducts { get; set; }
    }
}