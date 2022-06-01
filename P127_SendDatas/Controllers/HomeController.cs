using Microsoft.AspNetCore.Mvc;
using P127_SendDatas.Models;
using P127_SendDatas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127_SendDatas.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer
                {
                    Id = 1,
                    Brand = "ASUS",
                    Model = "TUF Gaming",
                    Memory = "512GB SSD",
                    Ram = "16GB DDR4",
                    Processor = "I7 core",
                    ReleaseDate = new DateTime(2021,04,08),
                    Count = 10
                },
                new Computer
                {
                    Id = 2,
                    Brand = "DELL",
                    Model = "Gaming G5",
                    Memory = "256 GB SSD",
                    Ram = "16GB DDR4",
                    Processor = "I5 core",
                    ReleaseDate = new DateTime(2020,04,08),
                    Count = 15
                },
                new Computer
                {
                    Id = 3,
                    Brand = "Lenovo",
                    Model = "Thinkpad",
                    Memory = "512GB SSD",
                    Ram = "16GB DDR5",
                    Processor = "I11 core",
                    ReleaseDate = new DateTime(2025,04,08),
                    Count = 20
                },
                new Computer
                {
                    Id = 4,
                    Brand = "Apple",
                    Model = "Mac pro",
                    Memory = "512GB SSD",
                    Ram = "16GB DDR4",
                    Processor = "M1 Ultra ++",
                    ReleaseDate = new DateTime(2022,04,08),
                    Count = 100
                },
                new Computer
                {
                    Id = 5,
                    Brand = "HP",
                    Model = "Omen",
                    Memory = "1TB HHD",
                    Ram = "4GB DDR2",
                    Processor = "I3 core",
                    ReleaseDate = new DateTime(2007,04,08),
                    Count = 0
                },
                new Computer
                {
                    Id = 6,
                    Brand = "Acer",
                    Model = "Predator",
                    Memory = "512GB SSD",
                    Ram = "16GB DDR4",
                    Processor = "I9 core",
                    ReleaseDate = new DateTime(2020,05,20),
                    Count = 7
                },
            };
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Id = 1,
                    Image = "https://abb-bank.az/storage/uploads/files/1626330360_mc-tam-standard-01.png",
                    Name = "Tamkart"
                },
                new Card
                {
                    Id = 2,
                    Image = "https://sonxeber.az/uploads/bolkart1.jpg",
                    Name = "Bolkart"
                },
                new Card
                {
                    Id = 3,
                    Image = "https://www.kapitalbank.az/images/cards/D/birkart-edv-debet1637578372.png",
                    Name = "Birkart"
                }
            };

            ViewData["Computers"] = computers;
            ViewBag.Computers = computers;


            ViewData["Computer"] = computers[2].Model;
            TempData["Computer"] = computers[0].Brand;

            HomeVM model = new HomeVM
            {
                Computers = computers,
                Cards = cards
            };


            //return RedirectToAction(nameof(About));
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
