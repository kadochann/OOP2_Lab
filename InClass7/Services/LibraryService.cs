using System.Collections.Generic;
using System.Linq;

public class LibraryService
{
    private List<BookItem> _books;

    public LibraryService()
    {
        _books = new List<BookItem>
        {
            new BookItem { Category = "Science", SubCategory = "Physics", Title = "Quantum Theory" },
            new BookItem { Category = "Science", SubCategory = "Physics", Title = "Classical Mechanics" },
            new BookItem { Category = "Science", SubCategory = "Chemistry", Title = "Organic Chemistry" },
            new BookItem { Category = "Science", SubCategory = "Chemistry", Title = "Periodic Table" },
            new BookItem { Category = "Technology", SubCategory = "Programming", Title = "C# Programming" },
            new BookItem { Category = "Technology", SubCategory = "Programming", Title = "Object-Oriented Design" },
            new BookItem { Category = "Technology", SubCategory = "Databases", Title = "SQL Basics" },
            new BookItem { Category = "Technology", SubCategory = "Databases", Title = "File-Based Storage" },
            new BookItem { Category = "Literature", SubCategory = "Novel", Title = "Modern Novel" },
            new BookItem { Category = "Literature", SubCategory = "Novel", Title = "Short Stories" },
            new BookItem { Category = "Literature", SubCategory = "Poetry", Title = "Turkish Poetry" },
            new BookItem { Category = "Literature", SubCategory = "Poetry", Title = "World Poetry" }
        };
    }

    public List<string> GetCategories() => _books.Select(b => b.Category).Distinct().ToList();

    public List<string> GetSubCategories(string category) =>
        _books.Where(b => b.Category == category).Select(b => b.SubCategory).Distinct().ToList();

    public List<string> GetBooks(string subCategory) =>
        _books.Where(b => b.SubCategory == subCategory).Select(b => b.Title).ToList();
}