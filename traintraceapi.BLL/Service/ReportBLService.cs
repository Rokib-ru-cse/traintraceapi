using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using traintraceapi.BLL.Interface;
using traintraceapi.DAL;
using traintraceapi.Model;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.BLL.Service
{
    public class ReportBLService : IReportBLRepository
    {
        private readonly AppDbContext context;

        public ReportBLService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ReturnResultWithCollection<Report>> Reports()
        {
            try
            {
                return new ReturnResultWithCollection<Report>{
                    Success = true,
                    Message = "reports found successfully",
                    Values = context.Reports.ToList()
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public  async Task<ReturnResultWithClass<Report>> SaveReport(Report report)
        {
            try
            {
                context.Reports.Add(report);
                context.SaveChanges();
                return new ReturnResultWithClass<Report>{
                    Success = true,
                    Message = "report saved successfully",
                    Value = report
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Report>> UpdateReport(Report report)
        {
            try
            {
                context.Reports.Update(report);
                context.SaveChanges();
                return new ReturnResultWithClass<Report>{
                    Success = true,
                    Message = "report updated successfully",
                    Value = report
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Report>> DeleteReport(int reportId)
        {
            try
            {
                Report report = context.Reports.Where(r=>r.Id==reportId).FirstOrDefault();
                context.Reports.Remove(report);
                context.SaveChanges();
                return new ReturnResultWithClass<Report>{
                    Success = true,
                    Message = "report deleted successfully",
                    Value = report
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}