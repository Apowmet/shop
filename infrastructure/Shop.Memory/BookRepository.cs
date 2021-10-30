using System;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book (1, "Шерлок Холмс"),
            new Book (2, "Гарри Поттер"),
            new Book (3, "Ведьмак"),
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
