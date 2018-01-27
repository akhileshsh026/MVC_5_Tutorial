using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HttpHelperMethods.Models
{
    public class Books
    {
        public List<Book> GetBooks()
        {
            // 1st way of adding the books
            var books = new List<Book>()
            {
                new Book { BookId=1 , Title = "Wings of Fire" , CopiesS=12334,Price=120, YearP=2011 },
                new Book { BookId=2 , Title="Discovery of India" , CopiesS = 23467 , Price = 54 , YearP = 1998}
            };
            // 2nd way of adding the books.
            books.Add(new Book { BookId = 3, Title = "Secrets of Meluha", CopiesS = 12324435, Price = 23424, YearP = 2004 });
            books.Add(new Book { BookId = 4, Title = "Dreams Come True", CopiesS= 7834234 , Price= 567 , YearP= 2020 });

            return books;
        }

    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int YearP { get; set; }
        public int CopiesS { get; set; }
        public float Price { get; set; }
        public string Cate { get; set; }

        [Required]
        public Genre? Genre { get; set; }
        public Availability Availability { get; set; }


    }

    public enum Genre
    {
        SciFi,
        Western,
        Techincal,
        BioGraphy
    }

    public enum Availability
    {
        Pickup,
        Delivery,
        Reseller
    }


}