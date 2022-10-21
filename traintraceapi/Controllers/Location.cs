using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using traintraceapi.BLL.Interface;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Location : ControllerBase
    {
        private readonly ILocationBLRepository locationBLRepository;

        public Location(ILocationBLRepository locationBLRepository)
        {
            this.locationBLRepository = locationBLRepository;
        }


        [HttpGet("")]
        public async Task<IActionResult> Locations()
        {
            try
            {
                return Ok(await locationBLRepository.Locations());
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithCollection<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Model.Location>()
                });
            }
        }

        [HttpGet("{locationId}")]
        public async Task<IActionResult> SingleLocation(int locationId)
        {
            try
            {
                return Ok(await locationBLRepository.Location(locationId));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Location()
                });
            }
        }
        [HttpGet("{trainId}")]
        public async Task<IActionResult> LocationByTrainId(int trainId)
        {
            try
            {
                return Ok(await locationBLRepository.LocationByTrainId(trainId));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Location()
                });
            }
        }



        [HttpPost("")]
        public async Task<IActionResult> SaveLocation([FromBody] Model.Location location)
        {
            try
            {
                return Ok(await locationBLRepository.SaveLocation(location));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = location
                });
            }
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateLocation([FromBody] Model.Location location)
        {
            try
            {
                return Ok(await locationBLRepository.UpdateLocation(location));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = location
                });
            }
        }

        [HttpDelete("{locationId}")]
        public async Task<IActionResult> DeleteLocation(int locationId)
        {
            try
            {
                return Ok(await locationBLRepository.DeleteLocation(locationId));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Location>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Location()
                });
            }
        }

    }
}