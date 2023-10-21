using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class BookType :Book
    {
     

        public BookType(string? title, string? author, int iSBN, int price, string? availability, string? type) : base(title, author, iSBN, price, availability)
        {
            Type = type;
        }

        public string? Type { get; set; }


        public void DiplayBookDetails()
        {
            Console.WriteLine("Book Title: {0}\n Author:{1} \n ISBN {2}\n Price:{3} Availability:{4}\n Book Type:{5}", Title,Author,ISBN, Price, Availability, Type);

            

        }
        
    }
}
