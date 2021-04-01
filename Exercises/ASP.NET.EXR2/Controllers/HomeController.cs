using ASP.NET.EXR2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.EXR2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var samer = new[]
            {
                new { Name = "Samer", Age = 30, Wife = "Christine", FavoriteIceCream = "Neapolitan", Dog = "Allie", DogBreed = "Lab" }
            };
            return View(samer.Select(p => $"Name: {p.Name}, Age: {p.Age}, Wife: {p.Wife}, FavoriteIceCream: {p.FavoriteIceCream}, " +
            $"Dog: {p.Dog}, DogBreed: {p.DogBreed}"));
        }
    }
}
