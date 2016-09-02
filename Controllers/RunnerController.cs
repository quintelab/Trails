using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Trails.Models;

namespace Trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();

            runners.Add(new Runner() { Id = 1, First = "Bruno", Last = "Quintella", Age = 30, FavoriteBeer = "Coke" });
            runners.Add(new Runner() { Id = 2, First = "Karina", Last = "Galli", Age = 29, FavoriteBeer = "Water" });

            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
