using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LagusImoveisWebII.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase

    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;



        public UsuarioController(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //cadastrar usuario
        [HttpPost]
        public async Task<IActionResult> Post(UsuarioAdicionarDto usuario)
        {
            if (usuario == null) return BadRequest("Dados Inválidos");
            var usuarioAdicionar = _mapper.Map<Usuario>(usuario);
            _repository.Add(usuarioAdicionar);
            return await _repository.SaveChangesAsync()
                ? Ok("Usuario cadastrado com sucesso")
                : BadRequest("Erro ao registrar o usuario");
        }


        //Lista os dados do Usuário
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _repository.GetUsuarioByIdAsync(id);

            var usuarioRetorno = _mapper.Map<UsuarioDetalhesDto>(usuario);

            return usuarioRetorno != null
                    ? Ok(usuarioRetorno)
                    : BadRequest("Dados  não encontrado.");
        }

        //deleta usuario
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Usuario inválido");

            var usuarioExcluir = await _repository.GetUsuarioByIdAsync(id);

            if (usuarioExcluir == null) return NotFound("Usuario não encontrado");

            _repository.Delete(usuarioExcluir);

            return await _repository.SaveChangesAsync()
                 ? Ok("Usuario deletado com sucesso")
                 : BadRequest("Erro ao deletar o usuario");
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UsuarioAtualizarDto usuario)
        {
            if (id <= 0) return BadRequest("Usuário não informado");

            var usuarioBanco = await _repository.GetUsuarioByIdAsync(id);

            var UsuarioAtualizar = _mapper.Map(usuario, usuarioBanco);

            _repository.Update(UsuarioAtualizar);

            return await _repository.SaveChangesAsync()
                ? Ok("Usuário atualizado com sucesso")
                : BadRequest("Erro ao atualizar o usuário");
        }
    }

}

