using System;
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

        [HttpPost]
        public async Task<ActionResult<List<Dish>>> CreateDish(DishCreateDto request)
        {
            var newDish = new Dish()
            {
                Name = request.Name,
            };

            var ingredients = request.Ing

            _context.DishesTable.Add(newDish);
            await _context.SaveChangesAsync();

            return Ok(await _context.DishesTable.Include(d => d.Ingredients).ToListAsync();
        }
    }
}
