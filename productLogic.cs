using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_store_1
{
    public class ProductLogic
    {

        // List<Product>? ----- this means the var can be empty/null or it can have a value
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;

        /* a constructor is like a car ignition. When we turn on a car a set of things starts to happen
            just like when we reference a class, the constructor has a set of instructions that will be excecuted.
            So if this class is referenced, a new list of objects ( in this case Products) will be made.
         */
        public ProductLogic() 
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product) 
        {
            var dogLeash = new DogLeash();
            var catFood = new CatFood();

            if (product.Name == "DogLeash")
            {
                _dogLeash.Add("DogLeash", dogLeash);
            } 
            else if (product.Name == "CatFood")
            {
                _catFood.Add("CatFood", catFood);
            }

            _products.Add(product);
        }

        public List<Product> GetAllProducts() 
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name) 
        {
            return _dogLeash[name];
        }

        //private string _products;
        //public ProductLogic
        //product _products = new List<Product>()

    }
}

    


            







        //constructor = special method in a class
        //same as the class name, can be used to assign
        //arguments to fields when creating an object 
        //add underscore b4 the name bcause=private var 












