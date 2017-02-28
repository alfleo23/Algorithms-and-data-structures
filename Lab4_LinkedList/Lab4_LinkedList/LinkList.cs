using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class LinkList
    {
        private Link list = null; //default value – empty list

        public void AddItem(int item) //add item to front of list
        {
            list = new Link(item, list);
        }

        public void DisplayItems() //write items to string and return
        {
            Link temp = list;
            
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            
        }

        public int NumberOfItems() // returns number of items in list
        {
            Link temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool IsPresentItem(int item)
        {
            Link temp = list;
            while (temp != null)
            {
                if (item == temp.Data)
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

        public void RemoveItem(int item)
        {
            Link temp = list;
            while (temp != null)
            {
                
                if (item + 1 == temp.Data)
                {
                    temp.Next = temp.Next.Next;
                }
                temp = temp.Next;
            }

        }


    } // end of class


}
