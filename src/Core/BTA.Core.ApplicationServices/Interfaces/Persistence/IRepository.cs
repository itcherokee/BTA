namespace BTA.Core.ApplicationServices.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<T> : IDisposable where T : class
    {
        T GetById(int id);

        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        int Add(T entity);

        int Delete(T entity);

        int Update(T entity);

        Task<int> SaveChangesAsync();
    }
}