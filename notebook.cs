using System;
using System.Collections.Generic;
using System.Text;

namespace notebookclass
{
    internal class notebook
    {
        public string Brand;
        public string Model;
        public double Price;

        public notebook(string brand, string model, double price = 0)
        {
            Brand = brand;
            Model = model;
            Price = price;

        }
        public  string Showinfo()
        {
            return $"Brand: {Brand},Model: {Model}, Price: {Price}";
        }
    }
}








