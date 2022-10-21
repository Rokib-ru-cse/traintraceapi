using traintraceapi.DAL.DbSeed.CountrySeed;
using traintraceapi.DAL.DbSeed.TrainSeed;

namespace traintraceapi.Utils
{
    public class Seed
    {
        private readonly CountryDbInitializer countryDbInitializer;
        private readonly TrainDbInitializer trainDbInitializer;
        public Seed(
                CountryDbInitializer countryDbInitializer,
                TrainDbInitializer trainDbInitializer)
        {
            this.countryDbInitializer = countryDbInitializer;
            this.trainDbInitializer = trainDbInitializer;
        }
        public void SeedData()
        {
            countryDbInitializer.SeedCountry();
            trainDbInitializer.SeedTrain();
        }
    }
}
