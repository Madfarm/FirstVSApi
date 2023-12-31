﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstVSApi.Data;
using FirstVSApi.Entities;
using FirstVSApi.DTOs;

namespace FirstVSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly DataContext _context;

        public DishesController(DataContext context)
        {
            _context = context;
        }

        //New method of structuring DTOs, more comments in the dtos
        [HttpPost]
        public async Task<ActionResult<List<Dish>>> CreateDish(DishCreateDto request)
        {
            var newDish = new Dish()
            {
                Name = request.Name,
            };

            var ingredients = request.Ingredients.Select(i => new Ingredient { Name = i.Name, Dish = newDish }).ToList();

            newDish.Ingredients = ingredients;

            _context.DishesTable.Add(newDish);
            await _context.SaveChangesAsync();

            return Ok(await _context.DishesTable.Include(d => d.Ingredients).ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Dish>>> Get()
        {
            var dishes = await _context.DishesTable.Include(d => d.Ingredients).ToListAsync();

            if (dishes.Count > 0)
            {
                return dishes;
            }

            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dish>> GetById(int id)
        {
            var dish = await _context.DishesTable.Include(d => d.Ingredients).FirstOrDefaultAsync(d => d.Id == id);

            if (dish is not null)
            {
                return dish;
            }

            return NotFound();
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDish(int id)
        {
            var dish = GetById(id);

            System.Diagnostics.Debug.WriteLine(dish);
            Console.WriteLine(dish);
            return NoContent();

        }

    }
}
