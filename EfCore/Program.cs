using EfCore;
using Microsoft.EntityFrameworkCore;

var dbContext = new ApplicationDbContext();
await dbContext.Database.MigrateAsync();