using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Buscandomitrago.Domain.IRepository;
using Buscandomitrago.Domain.Models;
using Buscandomitrago.Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Buscandomitrago.Infraestructure.Repository
{
    public class ApiRepository : IApiRepository
    {
        private readonly AppDbContext _appDbContext;
        public ApiRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateDrink(Drink drink)
        {
            try
            {
                await _appDbContext.Drinks.AddAsync(drink);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }



        }
        public List<DrinksView> GetMydrinks()
        {
            try
            {
                List<Drink> myDrinks = _appDbContext.Drinks.ToList();
                return Mapping(myDrinks);

            }
            catch (Exception ex)
            {
            }
            return null;
        }
        private List<DrinksView> Mapping(List<Drink> myDrinks)
        {
            List<DrinksView> drinkDetails = myDrinks.Select(d => new DrinksView
            {
                strDrink = d.strDrink,
                strInstructions = d.strInstructions,
                IngredientsWithMeasures = CombineIngredientsAndMeasures(d)
            }).ToList();
            return drinkDetails;
        }

        public string CombineIngredientsAndMeasures(Drink drink)
        {
            var ingredients = new List<string>();
            for (int i = 1; i <= 15; i++)
            {
                var ingredientProperty = typeof(Drink).GetProperty($"strIngredient{i}");
                var measureProperty = typeof(Drink).GetProperty($"strMeasure{i}");

                var ingredient = ingredientProperty?.GetValue(drink) as string;
                var measure = measureProperty?.GetValue(drink) as string;

                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    if (!string.IsNullOrWhiteSpace(measure))
                    {
                        ingredients.Add($"{measure} of {ingredient}");
                    }
                    else
                    {
                        ingredients.Add(ingredient);
                    }
                }
            }

            return string.Join(", ", ingredients);
        }
    }
}
