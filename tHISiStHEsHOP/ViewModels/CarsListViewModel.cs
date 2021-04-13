using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
