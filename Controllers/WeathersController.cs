using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EAD2WeatherApi.Models;

namespace EAD2WeatherApi.Controllers
{
    [Route("api/Weathers")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        private readonly WeatherContext _context;

        public WeathersController(WeatherContext context)
        {
            _context = context;
        }

        // Get all cities and their weather information
        // GET: api/Weathers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weather>>> GetWeather()
        {
            return await _context.Weather.ToListAsync();
        }

        // get city and weather info by id
        // GET: api/Weathers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weather>> GetWeather(long id)
        {
            var weather = await _context.Weather.FindAsync(id);

            if (weather == null)
            {
                return NotFound();
            }

            return weather;
        }

        // get city and weather info by city name
        // GET: api/Weathers/city/Dublin
        [HttpGet("city/{city:alpha}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Weather> GetCityWeather(string city)
        {

            var weather = from c in _context.Weather
                          select c;

            if (!String.IsNullOrEmpty(city))
            {
                weather = weather.Where(s => s.City.Contains(city));
            }

            return Ok(weather);
        }

        // PUT: api/Weathers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeather(long id, Weather weather)
        {
            if (id != weather.Id)
            {
                return BadRequest();
            }

            _context.Entry(weather).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Weathers
        [HttpPost]
        public async Task<ActionResult<Weather>> PostWeather(Weather weather)
        {
            _context.Weather.Add(weather);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWeather), new { id = weather.Id }, weather);
        }

        // DELETE: api/Weathers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Weather>> DeleteWeather(long id)
        {
            var weather = await _context.Weather.FindAsync(id);
            if (weather == null)
            {
                return NotFound();
            }

            _context.Weather.Remove(weather);
            await _context.SaveChangesAsync();

            return weather;
        }

        private bool WeatherExists(long id)
        {
            return _context.Weather.Any(e => e.Id == id);
        }
    }
}
