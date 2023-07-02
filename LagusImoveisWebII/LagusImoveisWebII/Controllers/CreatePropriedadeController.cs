
using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using LagusImoveisWebII.UoW;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreatePropriedadeController : ControllerBase
    {
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly ITipoSituacaoRepository _tipoSituacaoRepository;
        private readonly IImagemRepository _imagemRepository;
        private readonly IPropriedadeTipoSituacaoRepository _propriedadeTipoSituacaoRepository;
        private readonly ITipoImovelRepository _tipoImovelRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CreatePropriedadeController(
            IPropriedadeRepository propriedadeRepository,
            ITipoSituacaoRepository tipoSituacaoRepository,
            IImagemRepository imagemRepository,
            IPropriedadeTipoSituacaoRepository propriedadeTipoSituacaoRepository,
            ITipoImovelRepository tipoImovelRepository,
            IUnitOfWork uow, IMapper mapper)
        {
            _propriedadeRepository = propriedadeRepository;
            _tipoSituacaoRepository = tipoSituacaoRepository;
            _imagemRepository = imagemRepository;
            _propriedadeTipoSituacaoRepository = propriedadeTipoSituacaoRepository;
            _tipoImovelRepository = tipoImovelRepository;
            _uow = uow;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("cadastrar")]






    } 
}
