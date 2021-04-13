using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> GetAllCars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjCar(int carId);
    }
}
