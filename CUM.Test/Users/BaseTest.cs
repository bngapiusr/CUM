using CUM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CUM.Test.Users
{
    public class BaseTest
    {
        protected CumContext cxt;

        public BaseTest(CumContext cxtx = null )
        {
            this.cxt = cxtx ?? GetInMemoryDBContext();
        }

        private CumContext GetInMemoryDBContext()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<CumContext>();
            var options = builder.UseInMemoryDatabase("test").UseInternalServiceProvider(serviceProvider).Options;

            CumContext dbContext = new CumContext(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}