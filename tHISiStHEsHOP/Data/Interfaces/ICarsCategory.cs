using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
