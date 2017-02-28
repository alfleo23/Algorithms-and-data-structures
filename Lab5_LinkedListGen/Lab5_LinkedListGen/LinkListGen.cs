using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
	class LinkListGen<T> where T : IComparable
	{
		private LinkGen<T> list = null;

		public LinkListGen()
		{

		}

		public void AddItem(T item)
		{
			list = new LinkGen<T>(item, list);
		}

		public void DisplayList()
		{
			LinkGen<T> temp = list;

			while (temp != null) // move one link and add head to the buffer
			{
				Console.WriteLine(temp.Data);
				temp = temp.Next;
			}
		}

		public int NumberOfItems()
		{
			LinkGen<T> temp = list;
			int count = 0;
			while (temp != null) // move one link and add 1 to count
			{
				count++;
				temp = temp.Next;
			}
			return count;
		}

		public bool IsPresentItem(T item)
		{
			LinkGen<T> temp = list;
			while (temp != null)
			{
				if (item.CompareTo(temp.Data) == 0)
				{
					return true;
				}
				else
				{
					temp = temp.Next;
				}

			}
			return false;
		}

		public void RemoveItem(T item)
		{
			LinkGen<T> temp = list;

			while (temp.Next != null)
			{
				if (temp.Next.Data.CompareTo(item) == 0)
				{
					temp.Next = temp.Next.Next;
				}

				temp = temp.Next;
			}
		}

		public void AppendItem(T item)
		{
			LinkGen<T> temp = list;

			if (temp == null)
			{ list = new LinkGen<T>(item); }
			else
			{
				while (temp.Next != null)
				{
					temp = temp.Next;
				}
				temp.Next = new LinkGen<T>(item);
			}
		}


		public void Concat(LinkListGen<T> list2)
		{
			LinkGen<T> temp = list2.list;

			while (temp != null)
			{
				AppendItem(temp.Data);
				temp = temp.Next;
			}

		}


		public void Copy(LinkListGen<T> list2)
		{
			list = null;
			Concat(list2);

		}


		public void InsertInOrder(T item)
		{
			LinkGen<T> temp = list;
			LinkGen<T> prev = list;
			LinkGen<T> newLink = new LinkGen<T>(item, null);
			int count = 0;
			int count2 = 0;

			while (temp != null)
			{
				count2++;
				temp = temp.Next;
				//Console.WriteLine("count");
			}

			temp = list;
			while (temp != null)
			{
				if (item.CompareTo(temp.Data) > 0)
				{
					count++;
					prev = temp;
					temp = temp.Next;  // check the next in the listt
				    //Console.WriteLine("count22222");
					if (count2 == count)
					{
						AppendItem(item);
						temp = null;
					}
				}
				else
				{
					//put the item at the current position
					if (count != 0)
					{
						newLink.Next = temp;
						prev.Next = newLink;
						//AppendItem(item);
						temp = null;
					}
					else
					{
						AddItem(item);
						//AppendItem(item);
						temp = null;
					}
				}
			}
		}


		public void Sort()
		{
			LinkGen<T> temp = list;
			T[] numbers = new T[NumberOfItems()];
			int count = 0;

			while (temp != null)
			{
				numbers[count] = temp.Data;
				temp = temp.Next;
				count++;
			}

			Array.Sort(numbers);
			list = null;

			for (int i = 0; i < numbers.Length; i++)
			{
				T item = numbers[i];
				AppendItem(numbers[i]);

			}
			//LinkGen<T> check = list;
			//LinkGen<T> checkpre = list;
			//LinkGen<T> checkprepre = list;
			//int count = 0;


			//while (check != null)
			//{
			//	checkprepre = checkpre;
			//	checkpre = check;
			//	check = check.Next;
			//	count++;
			//	if (count > 1 && count < 7)
			//	{
			//		if (checkprepre.Data.CompareTo(checkpre.Data) > 0)
			//		{
			//			checkprepre.Next = checkpre.Next;
			//			checkpre.Next = checkprepre;
			//		}
			//	}

			//}
		}


	} // end of class

}
