using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            string bookCountStr;
            int bookCountInt;

            Console.WriteLine("Kitablarin sayini daxil edin: ");
            bookCountStr = Console.ReadLine();
            bookCountInt = Convert.ToInt32(bookCountStr);

            Library library = new Library();
            if (bookCountInt > 0)
            {
                library.Books = new Book[0];


                for (int i = 0; i < bookCountInt; i++)
                {
                    Console.WriteLine("==============================================");
                    Console.WriteLine($"{i + 1}-ci kitabin melumatlari.");
                    Console.WriteLine("==============================================");

                    int no = getInputNo(library.Books, 0);
                    int count = getInputCount("Kitabin sayini daxil edin: ", 0);
                    string name = getInputStr("Kitabin adini daxil edin: ", 1, 50);
                    string genre = getInputStr("Kitabin janrini daxil edin: ", 3, 20);
                    double price = getInputDbl("Kitabin qiymetini daxil edin: ", 0);

                    Book book = new Book(genre, no, name, price , count);

                    library.AddBooks(book);


                }

                string answer;
                Console.WriteLine("Neticveleri filterlemek isteyirsiz? y/n");
                answer = Console.ReadLine();

                if (answer == "n")
                {
                    Console.WriteLine("Kitablarin siyahisi:");
                    foreach (var item in library.Books)
                    {
                        Console.WriteLine(item.getInfo());
                    }
                }

                else if(answer == "y"){
                    string answer2;

                    Console.WriteLine("Neye gore filterlemek isteyirsiniz?\n1. Janr\n2. Qiymet");
                    answer2 = Console.ReadLine();

                    if (answer2 == "1")
                    {
                        string getGenre;
                        Console.Write("Janr: ");
                        getGenre = Console.ReadLine();
                        Book[] filterAnswer = library.getFilteredGenre(library.Books, getGenre);

                        foreach (var genre in filterAnswer)
                        {
                            Console.WriteLine($"Kitab nomresi: {genre.No}\nKitabin adi: {genre.Name}\nKitabin jansi: {genre.Genre}\nKitabin sayi: {genre.Count}\nKitabin qiymeti: {genre.Price}\n=======================================================\n");
                        }
                    }

                    else if (answer2 == "2")
                    {
                        string getMinPrice;
                        string getMaxPrice;
                        int getMinPriceInt;
                        int getMaxPriceInt;

                        do
                        {
                            Console.Write("Minimum qiymet daxil edin: ");
                            getMinPrice = Console.ReadLine();
                            getMinPriceInt = Convert.ToInt32(getMinPrice);
                            Console.Write("Maksimum qiymeti daxil edin: ");
                            getMaxPrice = Console.ReadLine();
                            getMaxPriceInt = Convert.ToInt32(getMaxPrice);
                        } while (getMinPriceInt <= 0);

                        Book[] filteredPrice = library.getFilteredPrice(library.Books, getMinPriceInt, getMaxPriceInt);

                        foreach (var price in filteredPrice)
                        {
                            Console.WriteLine($"Kitab nomresi: {price.No}\nKitabin adi: {price.Name}\nKitabin jansi: {price.Genre}\nKitabin sayi: {price.Count}\nKitabin qiymeti: {price.Price}\n=======================================================\n");
                        }

                    }
                }

                
            }
            
        }

        static string getInputStr(string input , int minValue , int maxValue)
        {
            string inputStr;

            Console.Write(input);
            inputStr = Console.ReadLine();

            if (inputStr.Length < minValue || inputStr.Length > maxValue)
            {
                do
                {
                    Console.Write("Yeniden cehd edin: ");
                    inputStr = Console.ReadLine();
                } while (inputStr.Length < minValue || inputStr.Length > maxValue);

                
            }

            return inputStr;

            
        }

        static int getInputCount(string input , int minValue)
        {
            string inputStr;
            int inputInt;

            Console.Write(input);
            inputStr = Console.ReadLine();
            inputInt = Convert.ToInt32(inputStr);

            if (inputInt <= minValue)
            {
                do
                {
                    Console.Write($"Yeniden cehd edin: ");
                    inputStr = Console.ReadLine();
                    inputInt = Convert.ToInt32(inputStr);
                } while (inputInt <= minValue);
            }

            return inputInt;
        }

        static int getInputNo(Book[] array, int minvalue)
        {
            string inputStr;
            int inputInt;
            bool boolNo = true;

            do
            {
                Console.Write("Kitabin No- nu daxil edin: ");
                inputStr = Console.ReadLine();
                inputInt = Convert.ToInt32(inputStr);

                foreach (var item in array)
                {
                    if (item.No == inputInt)
                    {
                        Console.WriteLine("Daxil etdiyiniz nomreli kitab artiq movcuddur!");
                        boolNo = false;
                        
                    }
                    else
                        boolNo = true;
                }
            } while (boolNo == false || inputInt <= minvalue);

            return inputInt;

            

        }

        static double getInputDbl(string input , int minValue)
        {
            string inputStr;
            int inputInt;

            Console.Write(input);
            inputStr = Console.ReadLine();
            inputInt = Convert.ToInt32(inputStr);

            if (inputInt < minValue)
            {
                do
                {
                    Console.Write("Yeniden cehd edin: ");
                    inputStr = Console.ReadLine();
                    inputInt = Convert.ToInt32(inputStr);
                } while (inputInt <= minValue);
            }

            return inputInt;
        }

    }
}
