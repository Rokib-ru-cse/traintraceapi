using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using traintraceapi.Model;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.BLL.Interface
{
    public interface ILocationBLRepository
    {
        Task<ReturnResultWithCollection<Location>> Locations();
        Task<ReturnResultWithClass<Location>> Location(int locationId);
        Task<ReturnResultWithClass<Location>> LocationByTrainId(int trainId);
        Task<ReturnResultWithClass<Location>> SaveLocation(Location location);
        Task<ReturnResultWithClass<Location>> UpdateLocation(Location location);
        Task<ReturnResultWithClass<Location>> DeleteLocation(int locationId);
        
        
    }
}