using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblotek
{
    class Program
    {
        static void Main(string[] args)
        {

            Libary Logic = new Libary();

            Logic.AddBooks(); // adding our objects in this case books

            while (true)
            {
             
            Logic.ReturnBooks();  // returns our list and stack
            Logic.ReturnRentedBooks();

              
                
                Console.WriteLine("\n\n Books Avavible: "); 

                foreach (Books book in Logic.ReturnBooks()) // print our list 
                {
                    Console.WriteLine(book.BookName + " id : " + book.BookId);
                }

                Console.WriteLine("\n\n What book do u wanna rent type the id: "); 

                try
                {

            int id = int.Parse(Console.ReadLine());  
                Console.Clear();
            Logic.AddRentedBook(id); // addrented book from the id  to our stack
                    Console.WriteLine(Logic.RemoveBook(id));  // then remove its from our list

                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine("DU SKAL INDTASTE ET id nummer ingen special tegn smat tom");
                   
                }
                catch (OverflowException ed)
                {
                    Console.Clear();
                    Console.WriteLine("for stort et nummer");
                }






                Console.WriteLine("\n\n Books u rented so far");

                
            foreach (Books book in Logic.ReturnRentedBooks()) // prints our stack with book name and book id
            {
                Console.WriteLine(book.BookName + "Id : " + book.BookId );
            }


            }

        }
    }
}
