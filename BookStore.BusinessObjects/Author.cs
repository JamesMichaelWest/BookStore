using System.Collections.Generic;

namespace BookStore.BusinessObjects
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Series> Series { get; set; } 
    }

    public class Series : BaseEntity
    {
        public string Name { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public List<Book> Books { get; set; } 
    }

    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public Rating BookRating { get; set; }
        public bool IsHardBack { get; set; }

        public Genre BookGenre { get; set; }
        public int BookGenreId { get; set; }
        
        public Series Series { get; set; }
        public int SeriesId { get; set; }
   
    }

    public class Genre : BaseEntity
    {
        public string Name { get; set; }
    }

    public enum Rating
    {
        Disliked,
        OK,
        Liked,
        LovedIt
    }
}