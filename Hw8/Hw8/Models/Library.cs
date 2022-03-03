using System;
using System.Collections.Generic;
using System.Text;
using ClassWork.Exception;
using ClassWork.Models;
using ClassWork.Interface;


namespace ClassWork.Models
{
    public class Library : ILibraryManager
    {
        List<Book> Books = new List<Book>();

        public void Add(string name, string author, int pagecount, string gener)
        {
            if (Books.FindAll(book => book.Name.Contains(name)).ToString() != name)
            {
                Books.Add(new Book(name, author, pagecount, gener)
                {
                    Name = name,
                    Author=author,
                    PageCount=pagecount,
                    Gener =gener
                }) ;
            }
            else
            {
                throw new SameBookAlreadyAddedExpection("Eyni ad altinda yalniz 1 kitab ola biler");

            }
        }
        //Bu hisseni usaqlardan sorusdum.
        public List<Book> Filter(string search)
        {
            return Books.FindAll(delegate (Book book) { return book.Gener.ToLower().Contains(search.Trim().ToLower()) || book.Author.ToLower().Contains(search.Trim().ToLower()); });

        }

        public void Search(string name)
        {
            throw new NotImplementedException();
        }

        public string ShowInfo(string name)
        {
            if (Books.FindAll(book => book.Name.ToLower().Contains(name.Trim().ToLower())) == null)
            {
                throw new BookNotFountException("Bu Kitab Movcut Deyil");
            }
            return Books.ToString();
        }
    }
}
