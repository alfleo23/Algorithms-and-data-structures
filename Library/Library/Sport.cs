using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Sport : Book
    {
        public Sport(string title) : base(title)
        {
            base.author = new Person("Chris Johnson");
        }
    }
}
