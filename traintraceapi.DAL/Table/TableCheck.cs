using traintraceapi.DAL;

namespace traintraceapi.DAL.Table
{
    public static class TableCheck
    {
        public static bool CheckTableExists<T>(AppDbContext db) where T : class
        {
            try
            {
                db.Set<T>().Count();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
