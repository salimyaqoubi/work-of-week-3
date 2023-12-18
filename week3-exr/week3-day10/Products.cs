using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day10
{
    class Products
    {
        public const double pi = 3.14;
        
        public static int id;
        public static int cnt;
        public string Name;
        public string description;
        public double price;
        public int CountInstock;
        public bool HasDiscount;

/*
        public Products()
        {
            //constrctor
        }

*/
        public Products(string Name, string description, double price, int CountInstock, bool HasDiscount)
        {
            int cnt = 0;
            int ProductId = cnt;
            this.Name = Name;
            this.description = description;
            this.price = price;
            this.CountInstock = CountInstock;
            this.HasDiscount = HasDiscount;
        }

        //Instances method 
        public void PriceDetails()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("| \t \t \t Welcome to admin Dashboard");
            Console.WriteLine($"Product Name is {this.Name} \n product description : {this.description} " +
                $"\n product price: {this.price} + the count of this product is {this.CountInstock} + Also this product has discount {this.HasDiscount}");
        }

    }
}
