using System;
using System.Collections.Generic;
using System.Net.Http;
using LaComida.Interfaces;
using LaComida.Model;
using Newtonsoft.Json;

namespace LaComida.Services
{
    public class RecetaService : IRecetaService
    {
        private readonly string _apiUrl = "https://www.themealdb.com/api/json/v1/1/search.php?s=";

        public List<RecetaSimplificada> ObtenerTodasLasRecetas()
        {
            // Aquí puedes implementar la lógica para obtener todas las recetas, si es necesario.
            throw new NotImplementedException();
        }

        public RecetaSimplificada ObtenerRecetaPorNombre(string nombre)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = httpClient.GetStringAsync($"{_apiUrl}{nombre}").Result;
                    Console.WriteLine("Respuesta de la API: " + response); // Depuración
                    var mealsResponse = JsonConvert.DeserializeObject<Meals>(response);

                    if (mealsResponse != null && mealsResponse.meals != null && mealsResponse.meals.Count > 0)
                    {
                        var meal = mealsResponse.meals[0];
                        var ingredientes = new List<string>
                {
                    meal.strIngredient1, meal.strIngredient2, meal.strIngredient3,
                    meal.strIngredient4, meal.strIngredient5, meal.strIngredient6,
                    meal.strIngredient7, meal.strIngredient8, meal.strIngredient9,
                    meal.strIngredient10, meal.strIngredient11, meal.strIngredient12,
                    meal.strIngredient13, meal.strIngredient14, meal.strIngredient15,
                    meal.strIngredient16, meal.strIngredient17, meal.strIngredient18,
                    meal.strIngredient19, meal.strIngredient20
                };

                        ingredientes.RemoveAll(string.IsNullOrWhiteSpace);

                        return new RecetaSimplificada
                        {
                            Nombre = meal.strMeal,
                            Ingredientes = ingredientes,
                            Instrucciones = meal.strInstructions,
                            ImagenUrl = meal.strMealThumb
                        };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al consumir la API: " + ex.Message); // Depuración
                }

                return null;
            }
        }

    }
    

}
