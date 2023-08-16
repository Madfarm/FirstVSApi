namespace FirstVSApi.DTOs
{
    public record struct DishCreateDto(string Name, List<IngredientCreateDto> Ingredients);
    

    
}
