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
    public class TrainBLService : ITrainBLRepository
    {
        
        private readonly AppDbContext context;

        public TrainBLService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ReturnResultWithClass<Train>> DeleteTrain(int trainId)
        {
            try
            {
                Train train = context.Trains.Where(t=>t.Id==trainId).FirstOrDefault();
                context.Trains.Remove(train);
                context.SaveChanges();
                return new ReturnResultWithClass<Train>{
                    Success=true,
                    Message="Train data deleted successully",
                    Value = train
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Train>> EditTrain(Train train)
        {
            try
            {
                context.Trains.Update(train);
                context.SaveChanges();
                return new ReturnResultWithClass<Train>{
                    Success=true,
                    Message="Train data updated successully",
                    Value = train
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Train>> SaveTrain(Train train)
        {
            try
            {
                context.Trains.Add(train);
                context.SaveChanges();
                return new ReturnResultWithClass<Train>{
                    Success=true,
                    Message="Train data saved successully",
                    Value = train
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithClass<Train>> Train(int trainId)
        {
            try
            {
                return new ReturnResultWithClass<Train>{
                    Success=true,
                    Message="Train found successully",
                    Value = context.Trains.Where(t=>t.Id==trainId).FirstOrDefault()
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithCollection<Train>> Trains()
        {
            try
            {
                return new ReturnResultWithCollection<Train>{
                    Success=true,
                    Message="Train data found successully",
                    Values = context.Trains.ToList()
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<ReturnResultWithCollection<Train>> TrainsByCountryId(int countryId)
        {
            try
            {
                return new ReturnResultWithCollection<Train>{
                    Success=true,
                    Message="Train data found successully",
                    Values = context.Trains.Where(t=>t.CountryId==countryId).ToList()
                };
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}