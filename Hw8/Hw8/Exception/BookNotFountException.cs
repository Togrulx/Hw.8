using System;
using System.Collections.Generic;
using System.Text;
namespace ClassWork.Exception
{
    public class BookNotFountException:SystemException
    {
        public BookNotFountException(string message) : base(message)
        {
        }
        public BookNotFountException(string message2, BookNotFountException BookNotFoundException) : base(message2, BookNotFoundException)
        {
        }
    }
}
