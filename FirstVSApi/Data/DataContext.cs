﻿using FirstVSApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstVSApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Dish> DishesTable { get; set; }
        public DbSet<Ingredient> IngredientsTable { get; set; }
    }
}
