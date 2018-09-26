using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly EmployeeContext _context;
        private readonly EmpAdd _EmpAdd;
        public SampleDataController(EmployeeContext context,EmpAdd objEmp)
        {
            _context = context;
            _EmpAdd = objEmp;

        }

        private string[] Summaries ()
        {
            try
            {

                //_EmpAdd.Address = "test";
                //_EmpAdd.Name = "delhi";
                //_context.Add(_EmpAdd);
            
                return _context.UserDetail.Select(x => x.Fname).ToArray();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            //"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        }

        [HttpGet("[action]")]
        public IEnumerable<UserDetail> WeatherForecasts()
        {
            try
            {
                return _context.UserDetail.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //});
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }

        [HttpGet("[action]")]
        public string[] GetSummaries()
        {
            return Summaries();
        }
    }
}
