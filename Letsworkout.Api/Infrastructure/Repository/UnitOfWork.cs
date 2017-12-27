using System;
using System.Transactions;
using Letsworkout.Api.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Letsworkout.Api.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly LetsWorkoutContext _db;

        public UnitOfWork(LetsWorkoutContext letsWorkoutContext)
        {
            _db = letsWorkoutContext;
        }

        public void Dispose()
        {

        }

        public void StartTransaction()
        {
            _transaction = new TransactionScope();
        }

        public void Commit()
        {
            _db.SaveChanges();
            if (_transaction != null)
                _transaction.Complete();
        }

        public DbContext Db
        {
            get { return _db; }
        }
    }
}
