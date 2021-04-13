using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Data.Interfaces;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly ApplicationContext dbContext;

        public CarRepository(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Car> GetAllCars => dbContext.Cars.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => dbContext.Cars.Where(x => x.IsFavorite).Include(c => c.Category);

        public Car GetObjCar(int carId) => dbContext.Cars.FirstOrDefault(i => i.Id == carId);
    }
}
