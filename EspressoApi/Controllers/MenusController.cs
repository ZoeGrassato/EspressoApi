using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspressoApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EspressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        EspressoDbContext _espressoDbContext;

        public MenuController(EspressoDbContext espressoDbContext)
        {
            _espressoDbContext = espressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _espressoDbContext.Menus.Include("SubMenus").ToList();
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _espressoDbContext.Menus.Include("SubMenus").FirstOrDefault(x => x.Id == id);
            if(menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }
    }
}