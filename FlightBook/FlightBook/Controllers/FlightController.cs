﻿using FlightBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        FlightBookContext db;
        public FlightController(FlightBookContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblFlight> GetFlights()
        {
            return db.TblFlights;
        }
        [HttpPost]
        public string Post([FromBody] TblFlight flight)
        {
            db.TblFlights.Add(flight);
            db.SaveChanges();
            return "success";
        }


    }
}
    