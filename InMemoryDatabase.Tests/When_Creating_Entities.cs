using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InMemoryDatabase.Data.Models;
using Xunit;

namespace InMemoryDatabase.Tests
{
    public class When_Creating_Entities
    {
        [Fact]
        public void Can_Create_New_Entity()
        {
            using (var ctx = TestContext.CreateInstance())
            {
                ctx.Entities.Add(new Entity
                {
                    Name = "This is a test"
                });

                ctx.SaveChanges();
            }

            using (var ctx = TestContext.CreateInstance())
            {
                var entity = ctx.Entities.SingleOrDefault(x => x.Name == "This is a test");
                Assert.NotNull(entity);
                Assert.Equal("This is a test", entity.Name);
            }
        }
    }
}
