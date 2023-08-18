namespace FirstVSApi.DTOs
{
    //Empty record except for what we need
    public record struct DishCreateDto(string Name, List<IngredientCreateDto> Ingredients);
    

    
}
