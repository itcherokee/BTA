namespace BTA.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using BTA.Core.ApplicationServices.Repositories;

    using Microsoft.EntityFrameworkCore;

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BtaDbContext dbContext;

        private readonly DbSet<T> dbSet;

        public Repository(BtaDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.dbSet = this.dbContext.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return this.dbSet.AsEnumerable<T>();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return this.dbSet.Where(predicate).AsEnumerable<T>();
        }

        public virtual int Add(T entity)
        {
            this.dbSet.Add(entity);
            return this.SaveChangesAsync().GetAwaiter().GetResult();
        }

        public virtual int Update(T entity)
        {
            this.dbContext.Entry(entity).State = EntityState.Modified;
            return this.dbContext.SaveChanges();
        }

        public virtual int Delete(T entity)
        {
            var entry = this.dbContext.Entry(entity);
            if(entry.Properties.Any(p => p.Metadata.Name == "IsDeleted"))
            {
                entry.Property("IsDeleted").CurrentValue = true;
            }
            //else
            //{
            //    entry.State = EntityState.Deleted;
            //}

            // dbContext.Set<T>().Remove(entity);
            return this.dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            this.dbContext.ChangeTracker.DetectChanges();

            var changedEntries = this.dbContext.ChangeTracker
                .Entries()
                .Where(e => e.Properties.Any(p => p.Metadata.Name == "UpdatedOn")
                && e.State == EntityState.Modified);

            foreach(var entry in changedEntries)
            {
                entry.Property("UpdatedOn").CurrentValue = DateTime.UtcNow;
            }

            return await this.dbContext.SaveChangesAsync();
        }

        public virtual void Dispose() => this.dbContext.Dispose();
    }
}