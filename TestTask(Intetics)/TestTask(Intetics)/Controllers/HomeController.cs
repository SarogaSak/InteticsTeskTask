using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask_Intetics_.Models;

namespace TestTask_Intetics_.Controllers
{
    public class HomeController : Controller
    {
        private IQueryable<Order> orders =
                    Repository.Select<Order>()
                        .Include(x => x.Car)
                        .Include(x => x.Car.Model)
                        .Include(x => x.Car.Model.Make)
                        .Include(x => x.OrderStatus)
                        .Include(x => x.Car.Client);

        public ActionResult Index()
        {
            ViewBag.Orders = orders;
            return View();
        }

        public ActionResult OrderSearch(string firstLastName)
        {
            string[] temp = firstLastName.Trim().Split(' ');
            if (temp.Length == 0)
            {
                 return PartialView(orders);
            }
            string name = temp[0];
            if (temp.Length == 1)
            {
                return PartialView(orders.Where(x => x.Car.Client.Name.Contains(name) || x.Car.Client.Surname.Contains(name)));
            }
            string surname = temp[temp.Length - 1];
            return PartialView(orders.Where(x => x.Car.Client.Name.Contains(name) && x.Car.Client.Surname.Contains(surname)));
        }

        [HttpGet]
        public ActionResult ClientCard(int Id)
        {
            return View(Id == 0 ? new Client() : orders.First(x => x.Id == Id).Car.Client);
        }

        [HttpPost]
        public ActionResult ClientCard(Client client)
        {
            if (client.Id == 0)
            {
                Repository.Insert(client);
            }
            else
            {
                Repository.Update(client, new EFDbContext());
            }

            return View(orders.First(x => x.Car.Client.Id == client.Id).Car.Client);
        }
    }
}
