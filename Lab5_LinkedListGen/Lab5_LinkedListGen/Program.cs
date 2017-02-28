using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> testlist = new LinkListGen<int>();
            LinkListGen<int> list1 = new LinkListGen<int>();
			LinkListGen<int> orderedlist = new LinkListGen<int>();


            testlist.AddItem(1);
            testlist.AddItem(2);
            testlist.AddItem(3);
            testlist.AddItem(4);
            testlist.DisplayList();
            Console.WriteLine("");

			Console.WriteLine("remove 3 from the list");
			testlist.RemoveItem(3);
            testlist.DisplayList();
            Console.WriteLine("");

			Console.WriteLine("append 73 in the list");
			testlist.AppendItem(73);
            testlist.DisplayList();
            Console.WriteLine("");

			Console.WriteLine("concatenate testlist{4, 2, 1, 73} with list1{7, 8, 9}");
			list1.AppendItem(7);
            list1.AppendItem(8);
            list1.AppendItem(9);
            testlist.Concat(list1);
            testlist.DisplayList();
			Console.WriteLine("");

			Console.WriteLine("copying testlist");
			list1.Copy(testlist);
			list1.DisplayList();
			Console.WriteLine("");

			Console.WriteLine("insert in order ");
			orderedlist.AppendItem(3);
			orderedlist.AppendItem(5);
			orderedlist.AppendItem(10);
			orderedlist.InsertInOrder(1);
			orderedlist.DisplayList();
			Console.WriteLine("");

			Console.WriteLine("sort the list");
			testlist.Sort();
			testlist.DisplayList();
			Console.WriteLine("");





            Console.ReadKey();

        }
    }
}
