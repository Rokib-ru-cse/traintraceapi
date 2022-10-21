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
    public class Report : ControllerBase
    {
        private readonly IReportBLRepository reportBLRepository;

        public Report(IReportBLRepository reportBLRepository)
        {
            this.reportBLRepository = reportBLRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> Reports()
        {
            try
            {
                return Ok(await reportBLRepository.Reports());
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithCollection<Model.Report>
                {
                    Success = false,
                    Message = ex.Message,
                    Values = new List<Model.Report>()
                });
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> SaveReport([FromBody] Model.Report report)
        {
            try
            {
                return Ok(await reportBLRepository.SaveReport(report));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Report>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = report
                });
            }
        }
        [HttpPut("")]
        public async Task<IActionResult> UpdateReport([FromBody] Model.Report report)
        {
            try
            {
                return Ok(await reportBLRepository.UpdateReport(report));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Report>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = report
                });
            }
        }
        [HttpDelete("{reportId}")]
        public async Task<IActionResult> DeleteReport(int reportId)
        {
            try
            {
                return Ok(await reportBLRepository.DeleteReport(reportId));
            }
            catch (System.Exception ex)
            {

                return BadRequest(new ReturnResultWithClass<Model.Report>
                {
                    Success = false,
                    Message = ex.Message,
                    Value = new Model.Report()
                });
            }
        }
    }
}