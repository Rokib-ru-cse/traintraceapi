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
    public class CountryBLService : ICountryBLRepository
    {
        private readonly AppDbContext context;

        public CountryBLService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ReturnResultWithCollection<Country>> Countries()
        {
            try
            {
                return new ReturnResultWithCollection<Country>()
                {
                    Success = true,
                    Message = "country list found successfully",
                    Values = context.Countries.ToList()
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Country>> Country(int countryId)
        {
            try
            {
                return new ReturnResultWithClass<Country>()
                {
                    Success = true,
                    Message = "country found successfully",
                    Value = context.Countries.Where(c=>c.Id==countryId).FirstOrDefault()
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Country>> DeleteCountry(int countryId)
        {
            try
            {
                Country country = context.Countries.Where(c=>c.Id==countryId).FirstOrDefault();
                context.Countries.Remove(country);
                context.SaveChanges();
                return new ReturnResultWithClass<Country>()
                {
                    Success = true,
                    Message = "country deleted successfully",
                    Value = country
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Country>> EditCountry(Country country)
        {
            try
            {
                context.Countries.Update(country);
                context.SaveChanges();
                return new ReturnResultWithClass<Country>()
                {
                    Success = true,
                    Message = "country edited successfully",
                    Value = country
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Country>> SaveCountry(Country country)
        {
            try
            {
                context.Countries.Add(country);
                context.SaveChanges();
                return new ReturnResultWithClass<Country>()
                {
                    Success = true,
                    Message = "country saved successfully",
                    Value = country
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}