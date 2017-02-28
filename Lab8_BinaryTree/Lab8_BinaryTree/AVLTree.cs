using System;
namespace Lab8_BinaryTree
{
	
	class AVLTree<T> : BSTree<T> where T : IComparable
	{
		public new void InsertItem(T item)
		{
			insertItem(item, ref root);
		}

		private void insertItem(T item, ref Node<T> tree)
		{
			if (tree == null)
				tree = new Node<T>(item);
			else if (item.CompareTo(tree.Data) < 0)
				insertItem(item, ref tree.Left);
			else if (item.CompareTo(tree.Data) > 0)
				insertItem(item, ref tree.Right);

			tree.BalanceFactor = maxDepth(tree.Left) - maxDepth(tree.Right);

			if (tree.BalanceFactor <= -2)
				rotateLeft(ref tree);
			if (tree.BalanceFactor >= 2)
				rotateRight(ref tree);
			
		}


		private void rotateLeft(ref Node<T> tree)
		{
			if (tree.Right.BalanceFactor > 0)  // double rotate
				rotateRight(ref tree.Right);

			else {
				Node<T> oldRoot = tree;
				Node<T> newRoot = tree.Right;

				oldRoot.Right = newRoot.Left;
				newRoot.Left = oldRoot;

				tree = newRoot;
			}
		}

		private void rotateRight(ref Node<T> tree)
		{
			if (tree.Left.BalanceFactor < 0)
				rotateLeft(ref tree.Left);
			
			else {
				Node<T> oldRoot = tree;
				Node<T> newRoot = tree.Left;

				oldRoot.Left = newRoot.Right;
				newRoot.Right = oldRoot;

				tree = newRoot;
			}
		}

		// TODO implement delete method


	} // end of class



}
