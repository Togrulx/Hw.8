using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount  { get; set; }
        public string Gener { get; set; }


        public Book(string name, string author, int pagecount, string gener)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            Gener = gener;
        }

        public override string ToString()
        {
            return $"Adi:{Name}\n" +
                $"Muellifi:{Author}\n" +
                $"Sehife sayi:{PageCount}\n" +
                $"Janri:{Gener}";
        }
    }
}
