using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.Repository
{
    public class ImagemRepository : BaseRepository, IImagemRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public ImagemRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public Task<Imagem> GetImagemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
