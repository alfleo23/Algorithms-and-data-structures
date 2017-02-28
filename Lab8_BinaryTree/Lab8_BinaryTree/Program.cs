using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> n1 = new Node<string>("a");
            n1.Left = new Node<string>("b");
            n1.Right = new Node<string>("c");
            n1.Left.Left = new Node<string>("d");
            n1.Left.Right = new Node<string>("e");
            n1.Right.Left = new Node<string>("f");
            n1.Right.Right = new Node<string>("g");
            n1.Left.Right.Right = new Node<string>("h");

            //BinTree<string> tree1 = new BinTree<string>(n1);

            string s = "";

			//tree1.InOrder(ref s);
			//Console.WriteLine("in order: " + s);
			//s = "";

			//tree1.postOrder(ref s);
			//Console.WriteLine("post order: " + s);
			//s = "";

			//tree1.preOrder(ref s);
			//Console.WriteLine("pre order: " + s);
			//s = "";


			// week 9 lab


	         //BSTree<int> searchTree = new BSTree<int>();
	         //searchTree.InsertItem(21);
	         //searchTree.InsertItem(7);
	         //searchTree.InsertItem(3);
			//searchTree.InsertItem(9);
			//searchTree.InsertItem(12);
			//searchTree.InsertItem(30);
			//searchTree.InsertItem(24);
			//searchTree.InsertItem(39);

			//         searchTree.InOrder(ref s);
			//         Console.WriteLine(s);

			//int treeHeight = searchTree.Height();
			//Console.WriteLine("Height is: " + treeHeight);

			//int treeCount = searchTree.Count();
			//Console.WriteLine("number of nodes in the tree: " + treeCount);

			//int item = 40;
			//if (searchTree.Contains(item))
			//	Console.WriteLine("item " + item + " in the list");
			//else { Console.WriteLine("item " + item + " NOT FOUND in the list"); }

			//week10 lab

			//BSTree<int> newSearchTree = new BSTree<int>();
			//newSearchTree.InsertItem(3);
			//newSearchTree.InsertItem(4);
			//newSearchTree.InsertItem(5);
			//newSearchTree.InsertItem(6);
			//newSearchTree.InsertItem(7);
			//newSearchTree.InsertItem(8);
			//newSearchTree.InsertItem(9);

			//newSearchTree.InOrder(ref s);
			//Console.WriteLine(s);
			//s = "";


			//newSearchTree.RemoveItem(6);


			//newSearchTree.InOrder(ref s);
			//Console.WriteLine(s);



			// AVL Tree Lab

			AVLTree<int> myTree = new AVLTree<int>();
			myTree.InsertItem(25);
			myTree.InsertItem(15);
			myTree.InsertItem(10);
			myTree.InsertItem(20);
			myTree.InsertItem(23);
			myTree.InsertItem(17);

			myTree.InOrder(ref s);
			Console.WriteLine(s);

			Console.ReadKey();
        }
    }
}
