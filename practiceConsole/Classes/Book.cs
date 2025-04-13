using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }
    public bool IsRead { get; set; }
    public List<string> Genres { get; set; } = new List<string>();


    public Book(string title, string author, int yearPublished, bool isRead, List<string>? genres = null)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        IsRead = isRead;
        Genres = genres ?? new List<string>(); 
    }
}