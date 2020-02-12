using InMemoryDatabase.Data;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDatabase.Tests
{
    internal class TestContext
    {
        internal static Context CreateInstance()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            return new Context(options);
        }
    }
}
