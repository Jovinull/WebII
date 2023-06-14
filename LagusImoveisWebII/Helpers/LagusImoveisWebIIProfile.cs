using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Helpers
{
    public class LagusImoveisWebIIProfile : Profile
    {
        LagusImoveisWebIIProfile() {

            CreateMap<Propriedade, PropriedadeDto>();
           // CreateMap<Endereco, EnderecoDto>()
               /// .ForMember(dest => dest.Propriedade, opt => opt.MapFrom(src => src.Propriedade.Descricao));
            


        }
        
    }
}
