using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstVSApi.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DishId { get; set; }
    }
}
