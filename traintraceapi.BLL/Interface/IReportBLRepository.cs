using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using traintraceapi.Model;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.BLL.Interface
{
    public interface IReportBLRepository
    {
        Task<ReturnResultWithCollection<Report>> Reports();
        Task<ReturnResultWithClass<Report>> SaveReport(Report report);
        Task<ReturnResultWithClass<Report>> UpdateReport(Report report);
        Task<ReturnResultWithClass<Report>> DeleteReport(int reportId);
    }
}