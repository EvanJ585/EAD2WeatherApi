using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EAD2WeatherApi.Models
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options)
             : base(options)
        {
        }

        public DbSet<Weather> Weather { get; set; }
    }
}
