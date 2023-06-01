 using LagusImoveisWebII.Context;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public class BaseRepository: IBaseRepository
    {
        private readonly LagusImoveisWebIIContext _context;
       public BaseRepository(LagusImoveisWebIIContext context) {
            _context = context;
            
        }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();

        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();

        }

    }
}
