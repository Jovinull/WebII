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


            CreateMap<UsuarioAdicionarDto, Usuario>();
            CreateMap<UsuarioAtualizarDto, Usuario>()
            
               .ForAllMembers(x => x.Condition((src, dest, prop) =>
            {
                if (prop == null) return false;
                if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;
                return true;
            }));

            //.ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            /*.ForMember(dest => dest.Nome, opts => opts.MapFrom(src => src.Nome))
           .ForMember(dest => dest.Sobrenome, opts => opts.MapFrom(src => src.Sobrenome))
           .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
           .ForMember(dest => dest.Telefone, opts => opts.MapFrom(src => src.Telefone))
           .ForMember(dest => dest.Senha, opts => opts.MapFrom(src => src.Senha));*/




            CreateMap<UsuarioAdicionarDto, Usuario>();
            CreateMap<UsuarioAdicionarDto, Usuario>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

           
            CreateMap<PropriedadeTipoSituacao, PropriedadeTipoSituacaoDto>();
            CreateMap<TipoSituacao, TipoSituacaoDto>();







        }


    }


}
