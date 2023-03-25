namespace BillyGameCenter.DataAccess
{
    public abstract class RepositoryBase
    {
        protected readonly string DBName;

        protected RepositoryBase(string dbName)
        {
            DBName = dbName;
        }
    }
}