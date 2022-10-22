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

                Location isLocationExist = context.Locations.Where(l => l.TrainId == location.TrainId).FirstOrDefault();
                if (isLocationExist != null)
                {
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = false,
                        Message = "This Train Location Already Exist",
                        Value = location
                    };
                }

                location.CreatedAt = DateTime.Now;
                location.UpdatedAt = DateTime.Now;
                location.MacAddress = "48:e2:44:5d:b7:d3";
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
                Location isLocationExist = context.Locations.Where(l => l.Id == location.Id).FirstOrDefault();
                if (isLocationExist == null)
                {
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = false,
                        Message = "Train Location Not Found",
                        Value = location
                    };
                }
                else
                {
                    isLocationExist.Id = location.Id;
                    isLocationExist.TrainId = location.TrainId;
                    isLocationExist.CountryId = location.CountryId;
                    isLocationExist.Latitude = location.Latitude;
                    isLocationExist.Longitude = location.Longitude;
                    isLocationExist.Accuracy = location.Accuracy;
                    isLocationExist.MacAddress = location.MacAddress;
                    isLocationExist.CreatedAt = location.CreatedAt;
                    isLocationExist.UpdatedAt = DateTime.Now;
                    context.Locations.Update(isLocationExist);
                    context.SaveChanges();
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = true,
                        Message = "Location update successfully",
                        Value = isLocationExist
                    };
                }
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
                Location location = context.Locations.Where(l => l.Id == locationId).FirstOrDefault();
                if (location == null)
                {
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = false,
                        Message = "Train Location Not Found",
                        Value = location
                    };
                }
                else
                {

                    context.Locations.Remove(location);
                    context.SaveChanges();
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = true,
                        Message = "Location deleted successfully",
                        Value = location
                    };
                }
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
                Location location = context.Locations.Where(l => l.Id == locationId).FirstOrDefault();
                if (location == null)
                {
                    return new ReturnResultWithClass<Location>()
                    {
                        Success = false,
                        Message = "Train Location Not Found",
                        Value = location
                    };
                }
                else
                {

                    return new ReturnResultWithClass<Location>()
                    {
                        Success = true,
                        Message = "Location found successfully",
                        Value = location
                    };
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ReturnResultWithClass<Location>> LocationByTrainId(int trainId)
        {
            Location location = context.Locations.Where(l => l.TrainId == trainId).FirstOrDefault();
            if (location == null)
            {
                return new ReturnResultWithClass<Location>()
                {
                    Success = false,
                    Message = "Train Location Not Found",
                    Value = location
                };
            }
            else
            {
                return new ReturnResultWithClass<Location>()
                {
                    Success = true,
                    Message = "Location found successfully",
                    Value = location
                };
            }
        }
    }
}