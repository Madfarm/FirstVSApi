using System.Security.Principal;

namespace FirstVSApi.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
