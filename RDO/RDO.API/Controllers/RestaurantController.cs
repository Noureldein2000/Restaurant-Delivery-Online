using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using RDO.Services.DTOs;
using RDO.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        //private readonly IStringLocalizer<LanguageResource> _localizer;
        public RestaurantController(IRestaurantService restService)
        {
            _restaurantService = restService;
        }

        [HttpGet]
        [Route("{Id:int}")]
        //[ProducesResponseType(typeof(PagedResult<DenominationModel>), StatusCodes.Status200OK)]
        public IActionResult GetRestaurantById(int Id)
        {
            try
            {
                var result = _restaurantService.GetRestaurantsById(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("City/{Id:int}")]
        //[ProducesResponseType(typeof(PagedResult<DenominationModel>), StatusCodes.Status200OK)]
        public IActionResult GetRestaurantByCity(int Id)
        {
            try
            {
                var result = _restaurantService.GetRestaurantsbyCity(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("")]
        //[ProducesResponseType(typeof(PagedResult<DenominationModel>), StatusCodes.Status200OK)]
        public IActionResult AddRestaurantBy(RestaurantDTO dto)
        {
            try
            {
                var result = _restaurantService.AddRestaurant(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
