using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Model.Context
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public CustomDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public CustomDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public CustomDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public int SaveChangesCount { get; set; }

        public override int SaveChanges()
        {
            ++SaveChangesCount;
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return base.SaveChangesAsync(cancellationToken);
        }
    }

    
}