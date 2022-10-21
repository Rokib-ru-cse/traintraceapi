using traintraceapi.DAL.Table;
using traintraceapi.Model;

namespace traintraceapi.DAL.DbSeed.CountrySeed
{
    public class CountryDbInitializer
    {
        private readonly AppDbContext context;

        public CountryDbInitializer(AppDbContext context)
        {
            this.context = context;
        }

        public void SeedCountry()
        {
            if (TableCheck.CheckTableExists<Country>(context))
            {
                if (!context.Countries.Any())
                {
                    var countries = new List<Country>()
                    {
                        new Country()
                        {
                            Id = 1,
                            Name = "Bangladesh",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Country()
                        {
                            Id = 2,
                            Name = "India",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Country()
                        {
                            Id = 3,
                            Name = "Pakistan",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        }
                    };
                    context.Countries.AddRange(countries);
                    context.SaveChanges();
                }
            }
        }
    }
}
