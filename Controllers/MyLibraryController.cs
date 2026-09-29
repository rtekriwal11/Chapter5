using Microsoft.AspNetCore.Mvc;

namespace Chapter2MVC.Controllers;

public class MyLibraryController : Controller
{
    static List<string> allBooks = new List<string> { 
        "Java Basic", "Agile with C#", "Advanced Agile" };

    //IActionResult is used whenever the return type is View()
    public IActionResult Book()
    {
        ViewData["Books"]=allBooks;
        return View();
    }
    public IActionResult AddBook()
    {
        return View();
    }
    //HTTPPOST HANDLES ALL THE DATA INCOMING TO ADDBOOK
    //METHOD
    //IT RECIEVES A BOOKTITLE, AND THEN IT PROCESSES IT
    [HttpPost]
    public IActionResult AddBook(string bookTitle)
    {
        allBooks.Add(bookTitle);
        return RedirectToAction("Book", "MyLibrary");
    }
}