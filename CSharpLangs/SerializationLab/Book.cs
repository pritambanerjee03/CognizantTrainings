using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLab
{
    [Serializable]
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }

    }
}
