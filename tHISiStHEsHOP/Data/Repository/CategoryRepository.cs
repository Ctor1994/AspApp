using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Data.Interfaces;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly ApplicationContext dbContext;

        public CategoryRepository(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IEnumerable<Category> AllCategories => dbContext.Categories;
    }
}
