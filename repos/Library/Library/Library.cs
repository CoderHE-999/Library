using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
    {
        public Book[] Books;

        public void AddBooks(Book book)
        {
            var temp = this.Books;

            Book[] newBooks = new Book[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                newBooks[i] = temp[i];
            }

            newBooks[newBooks.Length - 1] = book;

            this.Books = newBooks;
        }

        public Book[] getFilteredGenre(Book[] array , string inputGenre)
        {

            int counter = 0;
            foreach (var item in array)
            {
                if (item.Genre == inputGenre)
                    counter++;
            }

            Book[] newGenreArray = new Book[counter];

            int k = 0;

            foreach (var genre in array)
            {
                if (genre.Genre == inputGenre)
                    newGenreArray[k++] = genre;
            }

            return newGenreArray;
        }

        public Book[] getFilteredPrice(Book[] array , int minPrice , int maxPrice)
        {
            int counter = 0;

            foreach (var item in array)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                    counter++;
            }

            Book[] newPriceArray = new Book[counter];

            int k = 0;

            foreach (var price in array)
            {
                if (price.Price > minPrice && price.Price < maxPrice)
                    newPriceArray[k++] = price;
            }

            return newPriceArray;
        }
      
    }
}
