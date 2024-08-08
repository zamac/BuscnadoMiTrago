using Buscandomitrago.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscandomitrago.Application.IServices
{
    public interface IApiService
    {
        Task CreateDrink(Drink drink);
        List<DrinksView> GetMydrinks();
    }
}
