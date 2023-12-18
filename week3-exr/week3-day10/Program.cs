using System;

namespace week3_day10
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Products products = new Products();
            
          /*
            products.id = 1;
            products.Name = "Test";
            products.description = "tv";
            products.price = 80.0;

            Console.WriteLine(products.Name);
            */
            Products products1 = new Products("BBQ grill", "very good BBQ grill", 145, 1, true);
            products1.PriceDetails();

            Products products2 = new Products("Iphone 12", "the iphone has good feature", 222, 4, true);
            products2.PriceDetails();

            Products products3 = new Products("Television", "smart tv with 62 inch", 130, 2, true);
            products3.PriceDetails();

            Products[] productItems = {products1, products2 , products3 };
            foreach (Products item in productItems)
            {
                item.PriceDetails();
            }

            //Console.WriteLine(roducts.id);


            //double pi = 3.14;
            //int x;
            //x = 10;
            //pi = 5.3; will dont alloow any change 
        }
    }
}
