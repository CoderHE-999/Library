using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book:Product
    {

        public Book(string genre, int no, string name, double price , int count) : base(no, name, price , count)
        {
            this.Genre = genre;
        }

        public string Genre;

        public string getInfo()
        {
            return $"==============================================================================\nKitabin nomresi: {No}\nKitabin adi: {Name}\nKitabin janri: {Genre}\nKitabin sayi: {Count}\nKitabin qiymeti: {Price}\n==============================================================================";
        }
    }
}
