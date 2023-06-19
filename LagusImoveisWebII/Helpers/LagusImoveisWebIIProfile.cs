using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Helpers
{
    public class LagusImoveisWebIIProfile : Profile
    {
        public LagusImoveisWebIIProfile()
        {
            CreateMap<Usuario, UsuarioDetalhesDto>().ReverseMap();
            CreateMap<PropriedadeDetalhesDto, Propriedade>()
                .ForMember(dest => dest.PropriedadeTipoSituacao, opt => opt.Ignore());


            CreateMap<Propriedade, PropriedadeDetalhesDto>()
                .ForMember(dest => dest.PropriedadeTipoSituacao, opt => opt.MapFrom(src => src.PropriedadeTipoSituacao));


            CreateMap<UsuarioAtualizarDto, Propriedade>();
            CreateMap<UsuarioAtualizarDto, Propriedade>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UsuarioAdicionarDto, Usuario>();
            CreateMap<UsuarioAtualizarDto, Usuario>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }


    }


}
