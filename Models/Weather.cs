using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EAD2WeatherApi.Models
{
    // weather information i.e. city, current conditions, max temperature, min temperature, wind direction, windspeed, outlook for the next day
    public class Weather
    {
        //ID for City
        public long Id { get; set; }

        // the city to which this weather information applies
        [Required(ErrorMessage = "Invalid City")]
        public String City
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Invalid Condition")]
        public String CurrentCondition
        {
            get;
            set;
        }

        // Maximum temperature for the day in Celsius
        [Range(-40, 40, ErrorMessage = "Invalid Temperature")]
        public double MaxTemperature
        {
            get;
            set;
        }

        // Minimum temperature for the day in Celsius
        [Range(-40, 40, ErrorMessage = "Invalid Temperature")]
        public double MinTemperature
        {
            get;
            set;
        }

        // The current direction of the wind
        [Required(ErrorMessage = "Invalid Direction")]
        public String WindDirection
        {
            get;
            set;
        }

        // current wind speed km/h
        [Range(0, 200, ErrorMessage = "Invalid Wind Speed")]
        public int WindSpeed
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Invalid Outlook")]
        public String Outlook
        {
            get;
            set;
        }



    }
}
