using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : IComparable
    {
        private string title;
        public Person author;

        //constructors
        public Book(string anyTitle)
        {
            title = anyTitle;
        }

        public Book(string Title, Person Author)
        {
            this.title = Title;
            this.author = Author;
        }

        //property for title
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //property for author
        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public int CompareTo(Object obj)
        {
            Book other = (Book)obj;
            return Title.CompareTo(other.Title);
        }
    }
}
