using JopApp.Helpers;
using JopApp.Models;
using JopApp.Services;

CategoryManager categoryManager = new CategoryManager();

string userInput = string.Empty;
do
{

    System.Console.WriteLine("1. Show Joblist");
    System.Console.WriteLine("2. Category list");
    System.Console.WriteLine("3. Get Job detail");
    System.Console.WriteLine("4. Get Jobs by Category");
    System.Console.WriteLine("5. Search Jobs");
    System.Console.WriteLine("6. Login");
    System.Console.WriteLine("7. Register");
    System.Console.WriteLine("8. Add new job. ");
    System.Console.WriteLine("9. Add new category.");
    System.Console.WriteLine("0. Logout./Exit.");
    System.Console.WriteLine(" Select option:  ");
    userInput = Console.ReadLine();

    if (Utilities.check(userInput))
    {
        switch (userInput)
        {
            case "1":
                break;
            case "2":
                var categories = categoryManager.GetAll();
                foreach (var category in categories)
                {
                    //System.Console.WriteLine($"{category.Id}. Name {category.CategoryName}, Created date {category.CreateDate.ToString("dd MM yyyy")}");
                    System.Console.WriteLine($"Id: {category.Id} | Name: {category.CategoryName} ");
                }
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            default:
                break;
        }
    }


} while (userInput != "0");