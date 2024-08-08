using Buscandomitrago.Application.IServices;
using Buscandomitrago.Domain.IRepository;
using Buscandomitrago.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscandomitrago.Application.Services
{
    public class ApiService: IApiService
    {
        private readonly IApiRepository _apiRepository;
        public ApiService (IApiRepository apiRepository,IHttpContextAccessor httpContextAccessor)
        {
            _apiRepository = apiRepository;
        }
        public async Task CreateDrink(Drink drink)
        {
            await _apiRepository.CreateDrink(drink);
        }
        public List<DrinksView> GetMydrinks()
        {
            return _apiRepository.GetMydrinks();
        }
    }
}
