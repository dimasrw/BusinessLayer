using System;
using BusinessLayer.Model.Repository;

namespace BusinessLayer.Model.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        UnitOfWorkOperationResult Commit();
        UnitOfWorkOperationResult Rollback();

        T GetRepository<T>() where T : IRepository;
    }
}
