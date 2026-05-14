using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BorrowingService
{
    private string _filePath = "borrowings.txt"; 

    public void SaveBorrowing(BorrowingRecord record)
    {
        string line = $"{record.Date};{record.Username};{record.Category};{record.SubCategory};{record.BookTitle}";

        File.AppendAllLines(_filePath, new[] { line });
    }

    public List<string> GetHistory(string username)
    {
        List<string> history = new List<string>();

        if (!File.Exists(_filePath)) return history; 
        var lines = File.ReadAllLines(_filePath);

        foreach (var line in lines)
        {
            var parts = line.Split(';');

            if (parts.Length >= 5 && parts[1].Trim() == username)
            {
                string formattedEntry = $"{parts[0]} | {parts[2]} | {parts[4]}";
                history.Add(formattedEntry);
            }
        }

        return history;
    }
}