using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();

            testList.AddItem(1);
            testList.AddItem(2);
            testList.AddItem(3);
            testList.AddItem(4);
            testList.AddItem(5);
            testList.AddItem(6);

            testList.DisplayItems();
            Console.WriteLine("  ");

            Console.WriteLine( "number of items = {0}", testList.NumberOfItems() );

            Console.WriteLine("28 presented ------- {0}", testList.IsPresentItem(28));
            Console.WriteLine("2 presented ------- {0}", testList.IsPresentItem(2));

            Console.WriteLine("  ");

            testList.RemoveItem(4);

            testList.DisplayItems();

            Console.ReadKey();

        }
    }
}
