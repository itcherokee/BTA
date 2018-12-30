namespace BTA.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseRepository<T> where T : class
    {
        private int SaveChanges();

        private int SaveChangesAsync();
    }
}