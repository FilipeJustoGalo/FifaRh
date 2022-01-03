using CampeonatoFIFaR.Data;
using CampeonatoFIFaR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFIFaR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Player>>> Get ([FromServices] Context context)
        {
            var Players = await context.Players.ToListAsync();
            return Players;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Player>> Post ([FromServices] Context context,
            [FromBody] Player model)
        {
            if (ModelState.IsValid)
            {
                context.Players.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
