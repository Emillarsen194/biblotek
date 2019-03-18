using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblotek
{
    class Libary
    {
      
        static List<Books> avaviblebooks = new List<Books> { }; // list with books that have not been rented
        static Stack<Books> rentedbooks = new Stack<Books> { }; // stack with rented books
        public Libary()
        {

        }

        public void AddBooks() // adding books to our libary 
        {
            Books philosoper = new Books("Harry Potter and the Philosopher's Stone", "Jk. Rowling", "Fantasy", 687, 0);
            avaviblebooks.Add(philosoper);
            Books champer = new Books("Harry Potter and the Chamber of Secrets", "Jk. Rowling", "Fantasy", 689, 1);
            avaviblebooks.Add(champer);
            Books azkaban = new Books("Harry Potter and the Prisoner of Azkaban", "Jk. Rowling", "Fantasy", 1024, 2);
            avaviblebooks.Add(azkaban);
            Books gobletOfFire = new Books("Harry Potter and the Goblet of Fire", "Jk. Rowling", "Fantasy", 563, 3);
            avaviblebooks.Add(gobletOfFire);
            Books becoming = new Books("Becoming", "Michelle Obama", "Realistic", 565, 4);
            avaviblebooks.Add(becoming);
        }
        public Stack<Books> ReturnRentedBooks() //returns stack
        {
            return rentedbooks;
        }
        public List<Books> ReturnBooks() //return list
        {

            return avaviblebooks;
        }



        public String RemoveBook(int id) //remove books by index
        {
            try
            {

                avaviblebooks.RemoveAt(id); // list.remove at index 

            }
            catch (ArgumentOutOfRangeException ex)
            {

                return "Index tallet må ikke være højre end antal bøger";

            }

            return "";
        
        }

        public void AddRentedBook(int id)  // adds the book we choose from our list to our stack
        {
            try
            {

            rentedbooks.Push(avaviblebooks[id]); //push the same index as we removed from list
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("" + e.Message);
            }

        }


    }
}



    

       
       
        
       




