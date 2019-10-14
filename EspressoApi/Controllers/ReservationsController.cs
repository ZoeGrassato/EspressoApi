using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EspressoApi.Data;
using EspressoApi.Models;

namespace EspressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly EspressoDbContext _espressoDbContext;

        public ReservationsController(EspressoDbContext espressoDbContext)
        {
            _espressoDbContext = espressoDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _espressoDbContext.Reservations.Add(reservation);
            _espressoDbContext.SaveChanges();
            return StatusCode(201);
        }
    }
}