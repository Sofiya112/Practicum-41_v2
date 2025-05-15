using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_p_41
{
    delegate int BookComparer(Book book1, Book book2);

    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        // добавления книг в библиотеку
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // сортировка книг
        public void SortBooks(BookComparer comparer)
        {
            books.Sort((book1, book2) => comparer(book1, book2));
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
