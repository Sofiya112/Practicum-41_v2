using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_p_41
{
    class Book
    {
        public string Title { get; set; } //Названи
        public string Author { get; set; } //Автор
        public string Publisher { get; set; } //Издательство

        public Book(string title, string author, string publicsher) //Конструктор
        {
            Title = title;
            Author = author;
            Publisher = publicsher;
        }
        public override string ToString()
        {
            return $"Название: {Title}, Автор: {Author}, Издательство: {Publisher}";
        }
    }
}
