using System;
using System.Collections.Generic;
using burgerC.Models;
using burgerC.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgerC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BurgersController : ControllerBase
    {

        private readonly BurgersService _burgerService;

        public BurgersController(BurgersService burgersService)
        {
            _burgerService = burgersService;
        }

        [HttpGet]

        public ActionResult<List<Burger>> GetBurgers()
        {
            try
            {
                List<Burger> burgers = _burgerService.GetBurgers();
                return Ok(burgers);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }

}