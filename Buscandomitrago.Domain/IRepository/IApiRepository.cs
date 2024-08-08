using Buscandomitrago.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscandomitrago.Domain.IRepository
{
    public interface IApiRepository
    {
        Task CreateDrink(Drink drink);
        List<DrinksView> GetMydrinks();
    }
}
