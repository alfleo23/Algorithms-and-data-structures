using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].author = new Person("Herman Melville");
            books[1]= new Book("The Revenge");
            books[1].author = new Person("Ben Smith");
            books[2] = new Horror("The Creeping");
            books[3] = new Book("Me and You");
            books[3].author = new Person("Mia Turner");
            books[4] = new Sport("90 Minutes");
            books[5] = new Fantasy("Magic Dreams");
            books[6] = new Book("putrida", books[1].author);
            for (int i = 0; i < 7; i++)
                Console.WriteLine("{0}  {1}", books[i].Author.Name, books[i].Title);
            Console.ReadKey();

        }
    }
}
