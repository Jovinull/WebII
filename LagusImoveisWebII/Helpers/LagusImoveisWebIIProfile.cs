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
            CreateMap<PropriedadeDto, Propriedade>();
            CreateMap<Propriedade, PropriedadeDto>();
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

            CreateMap<UsuarioAdicionarDto, Usuario>();
            CreateMap<UsuarioAdicionarDto, Usuario>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

           
            CreateMap<PropriedadeTipoSituacao, PropriedadeTipoSituacaoDto>();
            CreateMap<PropriedadeTipoSituacaoDto, PropriedadeTipoSituacao>();

            CreateMap<TipoSituacao, TipoSituacaoDto>();
            CreateMap<TipoSituacaoDto, TipoSituacao>();

            CreateMap<Endereco, EnderecoDto>();
            CreateMap<EnderecoDto, Endereco>();

            CreateMap<Imagem, ImagemDto>();
            CreateMap<ImagemDto, Imagem>();

            CreateMap< TipoImovel, TipoImovelDto>();
            CreateMap<TipoImovelDto, TipoImovel>();

            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Propriedade, PropriedadeAdicionarDto>();
            CreateMap<PropriedadeAdicionarDto, Propriedade>()
             .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            CreateMap<PropriedadeAtualizarDto, Propriedade>()

             .ForAllMembers(x => x.Condition((src, dest, prop) =>
             {
                 if (prop == null) return false;
                 if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;
                 return true;
             }));


        }


    }


}
