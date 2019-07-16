using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProductbyPriority
{
    //    Product are identified by alphanumeric codes.Each code is stored as a 
    //string. We have three types of Product: high priority, medium priority, and 
    //low priority.Given an array of product codes, sort the array so that the highest 
    //priority Product come at the beginning of the array, the medium priority 
    //Product come in the middle, and the low priority Product come at the end.

    //Within a priority group, order does not matter. You are given a priority function which, given a 
    //product code, 
    //HINT ENUM returns 1 for high, 2 for medium and 3 for low.This array may contain a 
    //large number of product codes, so do your best to minimize additional storage.

    //You are given this function for usage:
    //private int GetPriority(string productCode).
    //You don’t need to implement this function.
    //Please Implement:
    //public void OrderProductByPriority(string[] productCode)



    public class SortProduct
    {
        public static void Main(string[] args)
        {
            Product product0 = new Product();
            product0.productCode = "12347";
            product0.productPriority = Priority.Low;

            Product product1 = new Product();
            product1.productCode = "12345";
            product1.productPriority = Priority.High;

            Product product2 = new Product();
            product2.productCode = "12444";
            product2.productPriority = Priority.Medum;

            Product product3 = new Product();
            product3.productCode = "12555";
            product3.productPriority = Priority.High;

            Product product4 = new Product();
            product4.productCode = "12355";
            product4.productPriority = Priority.Low;

            Product[] Product = new Product[5];
            Product[0] = product0;
            Product[1] = product1;
            Product[2] = product2;
            Product[3] = product3;
            Product[4] = product4;
           

            Product p = new Product();
            p.OrderProductByPriority(Product);

            Console.ReadLine();
            
        }


    }

    //RBD - Note I would usually move these to different classes...

    //Use and enum for readability
    public enum Priority{
        High = 1,
        Medum,
        Low
    }


    //Lot easiter to create a Product class for readablity
    public class Product
    {
        public string productCode { get; set; }
        public Priority productPriority { get; set; }


        //Create a method in the Product class to use the power of generics
        public void OrderProductByPriority(Product[] Product)
        {
            var orderProductHighToLow = from p in Product
                                         orderby p.productPriority
                                         select p;

            foreach(var product in orderProductHighToLow)
            {
                Console.WriteLine("Order Code = {0} and Priority = {1}", product.productCode, product.productPriority);
                Console.WriteLine();
            }
        }
    }





}
