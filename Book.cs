using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Title : BookAttribute
    {
        public Title(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
    public class Author : BookAttribute
    {
        public Author(string content) : base(content, ConsoleColor.Green)
        {
        }

        public Author(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
    public class Content : BookAttribute
    {
        public Content(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
    public abstract class BookAttribute
    {
        private string _content;
        private ConsoleColor _color;

        public BookAttribute(string content, ConsoleColor color)
        {
            _content = content;
            _color = color;
        }

        public virtual void Show()
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(_content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Book
    {
        Author author;
        Title title;
        Content content;

        public Book(Author author, Title title, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Author("Author", ConsoleColor.Red), new Title("Title", ConsoleColor.Blue), new Content("Content", ConsoleColor.Yellow));
            book.Show();
            Console.ReadLine();
        }
    }
}
