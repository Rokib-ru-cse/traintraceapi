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
    public class Train : ControllerBase
    {
        private readonly ITrainBLRepository trainBLRepository;

        public Train(ITrainBLRepository trainBLRepository)
        {
            this.trainBLRepository = trainBLRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> Trains()
        {
            try
            {
                return Ok(await trainBLRepository.Trains());
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }

        [HttpGet("{trainId}")]
        public async Task<IActionResult> SingleTrain(int trainId)
        {
            try
            {
                return Ok(await trainBLRepository.Train(trainId));
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }
        [HttpGet("{countryId}")]
        public async Task<IActionResult> TrainsByCountryId(int countryId)
        {
            try
            {
                return Ok(await trainBLRepository.TrainsByCountryId(countryId));
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }
        [HttpPost("")]
        public async Task<IActionResult> SaveTrain([FromBody] Model.Train train)
        {
            try
            {
                return Ok(await trainBLRepository.SaveTrain(train));
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }
        [HttpPut("")]
        public async Task<IActionResult> EditTrain([FromBody] Model.Train train)
        {
            try
            {
                return Ok(await trainBLRepository.EditTrain(train));
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }
        [HttpDelete("{trainId}")]
        public async Task<IActionResult> DeleteTrain(int trainId)
        {
            try
            {
                return Ok(await trainBLRepository.DeleteTrain(trainId));
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(new ReturnResultWithClass<Model.Train>(){
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Train()
                });
            }
        }
    }
}