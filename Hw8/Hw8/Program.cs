using System;
using System.Collections;
using ClassWork.Interface;
using ClassWork.Models;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("1 - Kitab elave edin");
            Console.WriteLine("2 - Kitab haqqinda ");
            Console.WriteLine("3 - Kitab axtarisi");
            Console.WriteLine("4 - Filter sistemi");

            do
            {
                string choicestring = Console.ReadLine();
                int choice;
                int.TryParse(choicestring, out choice);
                while (!int.TryParse(choicestring, out choice))
                {
                    choicestring = Console.ReadLine();
                }


               

                switch (choice)
                {
                    case 1:
                        Add(library);
                        break;

                    case 2:
                        ShowInfo(library);
                        break;

                    case 3:
                        Search(library);
                        break;

                    case 4:
                        Filter(library);
                        break;
                }

            } while (true);

        }
     

        public static void Add(Library libraryManager)
        {

            Console.WriteLine("Elave olunacaq kitabin  adi");
            string namestr = Console.ReadLine();
            while (string.IsNullOrEmpty(namestr))
            {
                namestr = Console.ReadLine();
            }


            Console.WriteLine("Elave olunacaq Kitabin Muellifinin Adi");
            string authorString = Console.ReadLine();
            while (string.IsNullOrEmpty(authorString))
            {
                authorString = Console.ReadLine();
            }


            Console.WriteLine("Elave slunacaq kitabin vereq sayi");
            string pagecountstr = Console.ReadLine();
            int pageCount;
            int.TryParse(pagecountstr, out pageCount);
            while (!int.TryParse(pagecountstr, out pageCount))
            {
                pagecountstr = Console.ReadLine();
            }


            Console.WriteLine("Elave olunacaq kitabin janri");
            string generstr = Console.ReadLine();
            while (string.IsNullOrEmpty(generstr))
            {
                generstr = Console.ReadLine();
            }

            libraryManager.Add(namestr, authorString, pageCount, generstr);
        }




        public static void ShowInfo(Library library)
        {
            Console.WriteLine("Axtardiginiz Kitabin Adi");
            string namestr = Console.ReadLine();
            while (string.IsNullOrEmpty(namestr))
            {
                namestr = Console.ReadLine();
            }

            library.ShowInfo(namestr);
        }



        public static void Search(ILibraryManager libraryManager)
        {
            Console.WriteLine("Axtaris edin");
            string search = Console.ReadLine();
            while (string.IsNullOrEmpty(search))
            {
                search = Console.ReadLine();
            }

            libraryManager.Search(search);

        }


        public static void Filter(Library libraryManager)
        {
            Console.WriteLine("Muellif ve ya Janr adi daxil edin");
            string search = Console.ReadLine();
            while (string.IsNullOrEmpty(search))
            {
                search = Console.ReadLine();
            }

            libraryManager.Filter(search);
            ;
        }

    }
}
