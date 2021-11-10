using Net6RecordEfCoreProxies;

var ctx = new TestDbContext();
ctx.Database.EnsureDeleted();
ctx.Database.EnsureCreated();

ctx.MyEnties.Add(new MyEntity
{
    MyRecord = new MyRecord
    {
        MyInt = 1
    }
});

ctx.SaveChanges();
ctx.Dispose();

ctx = new TestDbContext();

MyEntity entity = ctx.MyEnties.Single();

Console.ReadLine();