using Pratik4;

List<Author> authors = new List<Author>();
authors.Add(new Author { AuthorId = 1, Name = "A" });
authors.Add(new Author { AuthorId = 2, Name = "B" });
authors.Add(new Author { AuthorId = 3, Name = "C" });

List<Book> books = new List<Book>();
books.Add(new Book { BookId = 1, Title = "A", AuthorId = 1 });
books.Add(new Book { BookId = 2, Title = "B", AuthorId = 1 });
books.Add(new Book { BookId = 3, Title = "C", AuthorId = 2 });
books.Add(new Book { BookId = 4, Title = "D", AuthorId = 3 });

var mergedAuthorsAndBooks = from author in authors
                            join book in books on author.AuthorId equals book.AuthorId
                            select new
                            {
                                BookTitle = book.Title,
                                AuthorName = author.Name
                            };

foreach (var book in mergedAuthorsAndBooks)
{
    Console.WriteLine($"Book Title: {book.BookTitle} - Author Name: {book.AuthorName}");
}