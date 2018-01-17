using System;

namespace BusinessLayer.Model.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        UnitOfWorkOperationResult Commit();
        UnitOfWorkOperationResult Rollback();
    }
}
