﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Horror : Book
    {
        public Horror(string title) : base(title)
        {
            base.author = new Person("Stephen King");
        }

    }
}
