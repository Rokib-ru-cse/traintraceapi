using traintraceapi.DAL;
using traintraceapi.DAL.Table;
using traintraceapi.Model;

namespace traintraceapi.DAL.DbSeed.TrainSeed
{
    public class TrainDbInitializer
    {
        private readonly AppDbContext context;

        public TrainDbInitializer(AppDbContext context)
        {
            this.context = context;
        }

        public void SeedTrain()
        {
            if (TableCheck.CheckTableExists<Train>(context))
            {
                if (!context.Trains.Any())
                {
                    var trains = new List<Train>()
                    {
                        new Train()
                        {
                            Id = 1,
                            TrainName="EGAROSINDHUR PROVATI",
                            TrainNo="738",
                            CountryId=1,
                            IsActive=false,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Train()
                        {
                            Id = 2,
                            TrainName="EGAROSINDHUR GODHULI",
                            TrainNo="750",
                            CountryId=1,
                            IsActive=false,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Train()
                        {
                            Id = 3,
                            TrainName="KISHORGANJ EXPRESS",
                            TrainNo="782",
                            CountryId=1,
                            IsActive=false,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        
                    };
                    context.Trains.AddRange(trains);
                    context.SaveChanges();
                }
            }
        }
    }
}
