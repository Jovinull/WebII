namespace LagusImoveisWebII.UoW
{

    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
