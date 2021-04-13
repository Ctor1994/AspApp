using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Data.Interfaces;
using tHISiStHEsHOP.Models;
using tHISiStHEsHOP.ViewModels;

namespace tHISiStHEsHOP.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _allCars;
        private readonly ICarsCategory _allCarsCategory;

        public CarsController(ICars iallCars, ICarsCategory iallCarsCategory)
        {
            _allCars = iallCars;
            _allCarsCategory = iallCarsCategory;
        }
        [Authorize(Roles = "user")]
        public IActionResult Select(int id)
        {
            var car = _allCars.GetObjCar(id);
            return View(car);
        }
        [Route("Cars/ShowCars")]
        [Route("Cars/ShowCars/{category}")]
        public IActionResult ShowCars(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.GetAllCars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.GetAllCars.Where(p => p.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.GetAllCars.Where(p => p.Category.CategoryName.Equals("Классический автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классический автомобили";
                }


            }

            var carobj = new CarsListViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currCategory
            };

            return View(carobj);
        }
    }
}
