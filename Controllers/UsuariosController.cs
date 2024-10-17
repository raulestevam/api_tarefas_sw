using api_tarefas.DBContext;
using api_tarefas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_tarefas.Controllers
{
    [Route("api/[controller]")] //rota pra acessar o bd -- localhost/api/usuarios/nome-do-metodo
    [ApiController]
    public class UsuariosController : ControllerBase
    {
       private readonly AppDBContext _dbContext;

        public UsuariosController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]//localhost/api/usuarios/buscarTodos
        public async Task<ActionResult<IEnumerable<Usuario>>> ListarUsuarios()
        {
            return await _dbContext.usuarios.ToListAsync();
        }

        [HttpGet("{id}")] //localhost/api/usuarios/buscarporid/2
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            return await _dbContext.usuarios.FindAsync(id);
        }

        [HttpPost]//localhost/api/usuarios/cadastrarusuario
        public async Task <ActionResult<Usuario>> cadastrarUsuario(Usuario usuario)
        {
            _dbContext.usuarios.Add(usuario);
            await _dbContext.SaveChangesAsync();
            return Ok(usuario   );
        }
    }
}
