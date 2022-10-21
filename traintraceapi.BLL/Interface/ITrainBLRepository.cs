using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using traintraceapi.Model;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.BLL.Interface
{
    public interface ITrainBLRepository
    {
        Task<ReturnResultWithCollection<Train>> Trains();
        Task<ReturnResultWithClass<Train>> Train(int trainId);
        Task<ReturnResultWithCollection<Train>> TrainsByCountryId(int countryId);
        Task<ReturnResultWithClass<Train>> SaveTrain(Train train);
        Task<ReturnResultWithClass<Train>> EditTrain(Train train);
        Task<ReturnResultWithClass<Train>> DeleteTrain(int trainId);
    }
}