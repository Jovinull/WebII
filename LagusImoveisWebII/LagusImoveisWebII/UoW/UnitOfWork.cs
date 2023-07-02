using LagusImoveisWebII.Context;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LagusImoveisWebIIContext _context;

        public UnitOfWork(LagusImoveisWebIIContext context)
        {
            _context = context;
        }
        public async Task<bool> Commit()
        {
            var success = (await _context.SaveChangesAsync()) > 0;
            return success;
        }

        public void Dispose() =>
            _context.Dispose();

        public Task Rollback()
        {
           
            return Task.CompletedTask;
        }
    }
}