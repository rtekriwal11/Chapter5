using Microsoft.AspNetCore.Mvc;

namespace Chapter2MVC.Controllers
{
    public class MovieController : Controller
    {
        public string checkTicketPrice(string name, int at, int ct, int atp, int ctp)
        {
            double tot_price = at * atp + ct * ctp;
            return $" {name},  the total price of ticket is ${tot_price}";
        }
    }
}