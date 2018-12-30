namespace BTA.Core.ApplicationServices.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);
    }
}