using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProductsbyPriority
{
    //    Products are identified by alphanumeric codes.Each code is stored as a 
    //string. We have three types of products: high priority, medium priority, and 
    //low priority.Given an array of product codes, sort the array so that the highest 
    //priority products come at the beginning of the array, the medium priority 
    //products come in the middle, and the low priority products come at the end.

    //Within a priority group, order does not matter. You are given a priority function which, given a 
    //product code, 
    //HINT ENUM returns 1 for high, 2 for medium and 3 for low.This array may contain a 
    //large number of product codes, so do your best to minimize additional storage.

    //You are given this function for usage:
    //private int GetPriority(string productCode).
    //You don’t need to implement this function.
    //Please Implement:
    //public void OrderProductsByPriority(string[] productCodes)



    public class SortProduct
    {
        public static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.productCodes = "12345";
            product1.productPriority = Priority.High;

            Products product2 = new Products();
            product1.productCodes = "12444";
            product1.productPriority = Priority.Medum;

            Products product3 = new Products();
            product1.productCodes = "12555";
            product1.productPriority = Priority.High;

            Products product4 = new Products();
            product1.productCodes = "12355";
            product1.productPriority = Priority.Low;

            Products product5 = new Products();
            product1.productCodes = "12347";
            product1.productPriority = Priority.Low;



            Products[] products = new Products[4];
            products[2] = products[2];
            products[4] = products[3];
            products[5] = products[4];
            products[5] = products[4];



            products = OrderProductsByPriority(Products products);


        }

        public List<Products> OrderProductsByPriority(Products products)
        {
            products



            return products;

        }
    }

    public enum Priority{
        High = 1,
        Medum,
        Low
    }

    public class Products
    {
        public string productCodes { get; set; }
        public Priority productPriority { get; set; }

    }





}
