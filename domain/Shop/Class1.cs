using System;

namespace Shop
{
    public class Book
    {
        public int Id
        { 
            get;
        }
        public string Title 
        { 
            get; 
        }
        public Book (int id, string title) 
        {
            Id = id;
            Title = title;
        }
    }
}
