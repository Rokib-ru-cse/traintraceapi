using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using traintraceapi.Model;
using traintraceapi.Model.ViewModel;

namespace traintraceapi.BLL.Interface
{
    public interface ICountryBLRepository
    {
        Task<ReturnResultWithCollection<Country>> Countries();
        Task<ReturnResultWithClass<Country>> Country(int countryId);
        Task<ReturnResultWithClass<Country>> SaveCountry(Country country);
        Task<ReturnResultWithClass<Country>> EditCountry(Country country);
        Task<ReturnResultWithClass<Country>> DeleteCountry(int countryId);
    }
}