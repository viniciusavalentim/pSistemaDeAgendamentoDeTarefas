using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabalhandoComEntityFramework.DataContext;
using TrabalhandoComEntityFramework.Entities;
using TrabalhandoComEntityFramework.Enums;

namespace TrabalhandoComEntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly AgendaContext _context;

        public TarefaController(AgendaContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var tarefa = _context.Tarefa?.Find(id);
            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Tarefa tarefa)
        {
            var updateTarefa = _context.Tarefa?.Find(id);
            if (updateTarefa != null)
            {
                NotFound();
            }

            updateTarefa!.Titulo = tarefa.Titulo;
            updateTarefa.Descricao = tarefa.Descricao;
            updateTarefa.Data = tarefa.Data;
            updateTarefa.Status = tarefa.Status;

            _context.Tarefa?.Update(updateTarefa);
            _context.SaveChanges();

            return Ok(updateTarefa);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = _context.Tarefa?.Find(id);
            if (tarefa == null)
            {
                NotFound();
            }

            _context.Tarefa?.Remove(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_context.Tarefa);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult GetPorTitulo(string titulo)
        {
            var tarefa = _context.Tarefa?.Where(x => x.Titulo == titulo);
            if(tarefa == null)
            {
                NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult GetPorData(DateTime data)
        {
            var tarefa = _context.Tarefa?.Where(x => x.Data == data);
            if (tarefa == null)
            {
                NotFound();
            }
            return Ok(tarefa);
        }
        [HttpGet("ObterPorStatus")]
        public IActionResult GetPorStatus(StatusEnum status)
        {
            var tarefa  = _context.Tarefa?.Where(x => x.Status == status);
            if (tarefa == null)
            {
                NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Tarefa?.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }




    }
}
