using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace FirstVSApi.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DishId { get; set; }
        [JsonIgnore]
        public Dish Dish { get; set; }
    }
}
