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
    public class Country : ControllerBase
    {
        
        private readonly ICountryBLRepository countryBLRepository;

        public Country(ICountryBLRepository countryBLRepository)
        {
            this.countryBLRepository = countryBLRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> Countries()
        {
            try
            {
                return Ok(await countryBLRepository.Countries());
            }
            catch (System.Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.Country>(){
                    Success =false,
                    Message=ex.Message,
                    Value = new Model.Country()
                });
            }
        }

        [HttpGet("{countryId}")]
        public async Task<IActionResult> SingleCountry(int countryId)
        {
            try
            {
                return Ok(await countryBLRepository.Country(countryId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.Country>(){
                    Success =false,
                    Message=ex.Message,
                    Value = new Model.Country()
                });
            }
        }
        [HttpPost("")]
        public async Task<IActionResult> SavedCountry([FromBody] Model.Country country)
        {
            try
            {
                return Ok(await countryBLRepository.SaveCountry(country));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.Country>(){
                    Success =false,
                    Message=ex.Message,
                    Value = new Model.Country()
                });
            }
        }
        [HttpPut("")]
        public async Task<IActionResult> EditCountry([FromBody] Model.Country country) 
        {
            try
            {
                return Ok(await countryBLRepository.EditCountry(country));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.Country>(){
                    Success =false,
                    Message=ex.Message,
                    Value = new Model.Country()
                });
            }
        }
        [HttpDelete("{countryId}")]
        public async Task<IActionResult> DeleteCountry(int countryId)
        {
            try
            {
                return Ok(await countryBLRepository.DeleteCountry(countryId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new ReturnResultWithClass<Model.Country>(){
                    Success =false,
                    Message=ex.Message,
                    Value = new Model.Country()
                });
            }
        }
    }
}