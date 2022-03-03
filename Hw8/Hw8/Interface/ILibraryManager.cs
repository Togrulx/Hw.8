using System;
using System.Collections.Generic;
using ClassWork.Models;

namespace ClassWork.Interface
{
    public interface ILibraryManager
    {
        public void Add(string name, string author, int pagecount, string gener);
        public void Search(string name);
        public string ShowInfo(string name);

        public List<Book> Filter(string search);
    }
}
