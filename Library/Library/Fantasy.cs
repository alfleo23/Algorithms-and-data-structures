using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Fantasy : Book
    {
        public Fantasy(string title) : base(title)
        {
            base.author = new Person("Liam Button");
        }
    }
}
