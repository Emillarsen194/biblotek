using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblotek
{
    public class Books
    {
        private String bookName;
        private String author;
        private String genre;
        private int pages;
        private int bookId;


        #region makeallpublic

        public String BookName
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }

        public String Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public String Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }

        public int BookId
        {
            get
            {
                return bookId;
            }
            set
            {
                bookId = value;
            }
        }

        #endregion

        
 
        public Books(String bn, String au, String gen, int page, int id)
        {
            this.bookName = bn;
            this.author = au;
            this.genre = gen;
            this.pages = page;
            this.bookId = id;

        }

    }
}

       





            
           





       

            



       
        





       


  
