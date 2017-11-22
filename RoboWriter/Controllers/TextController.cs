using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoboWriter.AutoCompleteBrain;

namespace RoboWriter.Controllers
{
    [Route("api/[controller]")]
    public class TextController : Controller
    {

        GraphBuilder _graphBuilder = new GraphBuilder(); 

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _graphBuilder.SetText(value); 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


    }
}
