using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Product
    {

        public Product(int no, string name, double price , int count)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public int No;
        public int Count;
        public string Name;
        public double Price;
    }
}
