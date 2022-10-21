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
    public class LocationBLService : ILocationBLRepository
    {
        private readonly AppDbContext context;

        public LocationBLService(AppDbContext context)
        {
            this.context = context;
        }

        

        public async Task<ReturnResultWithCollection<Location>> Locations()
        {
            try
            {
                return new ReturnResultWithCollection<Location>()
                {
                    Success = true,
                    Message = "Locations found successfully",
                    Values = context.Locations.ToList()
                };
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ReturnResultWithClass<Location>> SaveLocation(Location location)
        {
            try
            {
                context.Locations.Add(location);
                context.SaveChanges();
                return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location saved successfully",
                    Value = location
                };
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<ReturnResultWithClass<Location>> UpdateLocation(Location location)
        {
            try
            {
                context.Locations.Update(location);
                context.SaveChanges();
                return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location update successfully",
                    Value = location
                };
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ReturnResultWithClass<Location>> DeleteLocation(int locationId)
        {
            try
            {
                Location location =  context.Locations.Where(l=>l.Id==locationId).FirstOrDefault();
                context.Locations.Remove(location);
                context.SaveChanges();
                return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location deleted successfully",
                    Value = location
                };
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ReturnResultWithClass<Location>> Location(int locationId)
        {
            try
            {
                return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location found successfully",
                    Value = context.Locations.Where(l=>l.Id==locationId).FirstOrDefault()
                };
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ReturnResultWithClass<Location>> LocationByTrainId(int trainId)
        {
            return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location found successfully",
                    Value = context.Locations.Where(l=>l.TrainId==trainId).FirstOrDefault()
                };
        }
    }
}