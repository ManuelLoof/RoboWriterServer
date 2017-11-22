using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoboWriter.Controllers
{
    [Route("api/[controller]")]
    public class AutoCompleteController : Controller
    {
        DBProvider _brain = new DBProvider();

        // GET api/autocomplete/das
        [HttpGet("{word}")]
        public string[] Get(string word)
        {
            return _brain.GetNextWords(word).ToArray(); 
        }
    }
}
