using System;
using System.Collections.Generic;
using System.Text;

namespace Authors
{
    class Author
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public List<Book> Books { get; internal set; }
        public int Wins { get; internal set; }
        public int Nominations { get; internal set; }
    }
}
