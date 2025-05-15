using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_p_41
{
    class Program
    {
        static int CompareByTitle(Book book1, Book book2)
        {
            return string.Compare(book1.Title, book2.Title);
        }

        // Сортировка по автору книги
        static int CompareByAuthor(Book book1, Book book2)
        {
            return string.Compare(book1.Author, book2.Author);
        }

        // Сортировка по издательству книги
        static int CompareByPublisher(Book book1, Book book2)
        {
            return string.Compare(book1.Publisher, book2.Publisher);
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            // Добавление книг в библиотеку
            library.AddBook(new Book("Война и мир", "Лев Толстой", "Эксмо"));
            library.AddBook(new Book("Преступление и наказание", "Фёдор Достоевский", "Азбука"));
            library.AddBook(new Book("1984", "Джордж Оруэлл", "АСТ"));

            Console.WriteLine("Книги в библиотеке до сортировки:");
            library.PrintBooks();

            // Сортировка по названию
            Console.WriteLine("\nКниги после сортировки по названию:");
            library.SortBooks(CompareByTitle);
            library.PrintBooks();

            // Сортировка по автору
            Console.WriteLine("\nКниги после сортировки по автору:");
            library.SortBooks(CompareByAuthor);
            library.PrintBooks();

            // Сортировка по издательству
            Console.WriteLine("\nКниги после сортировки по издательству:");
            library.SortBooks(CompareByPublisher);
            library.PrintBooks();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
