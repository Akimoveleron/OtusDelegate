// See https://aka.ms/new-console-template for more information
using Delegates;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable items = new List<string> { "12", "220", "53", "756" };
        Console.WriteLine("Коллекция items: ");
        foreach (string item in items) { Console.Write($"{item} "); }
      
        string max = items.GetMax<string>(CollectionsExtensions.GetParametr);
        Console.WriteLine($"Максимальное значение: {max}" );

        Console.WriteLine("Для завершения поиска нажми escape");

        DirectoryService.FileFound += DisplayMessage;
        DirectoryService.AllFileSearch(Directory.GetCurrentDirectory());
        DirectoryService.FileFound -= DisplayMessage;
  
    }



    public static void DisplayMessage(FileArgs e)
    {
        Console.WriteLine($"Найден файл {e.FileName}");

        if (Console.ReadKey().Key == ConsoleKey.Escape) 
            DirectoryService.FileFound -= DisplayMessage;
        
    }


}