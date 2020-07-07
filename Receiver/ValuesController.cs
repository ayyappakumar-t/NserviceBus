using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class ValuesController : Controller
{
    // GET: api/<controller>
    [HttpGet]
    public string Get()
    {
        return "Started";
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "Receiver Web Api receives the message from sender";
    }    
}
