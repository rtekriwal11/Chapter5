using Microsoft.AspNetCore.Mvc;

namespace Chapter2MVC.Controllers;

public class EmployeeController: Controller
{
    public string PayAmount(string name, double rate, double hours)
    {
        double total_Amount = rate * hours;
        return $"The Employee Name-{name}, has worked on ${rate} for {hours}hours. Total=${total_Amount}";
    }
}