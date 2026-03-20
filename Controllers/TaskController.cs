using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using System.Linq;

[ApiController] //Diz que esta classe é uma API
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Tarefa>> Get()
    {
        return Ok(tarefas);
    }

    private static List<Tarefa> tarefas = new List<Tarefa>();

    [HttpPost]
    public ActionResult<Tarefa> Post([FromBody] Tarefa tarefa)
    {
        tarefas.Add(tarefa);
        return Ok(tarefa);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Tarefa tarefaAtualizada)
    {

        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

        if (tarefa == null)
        {
            return NotFound();
        }

        tarefa.Titulo = tarefaAtualizada.Titulo;
        tarefa.EstaCompleta = tarefaAtualizada.EstaCompleta;

        return Ok(tarefa);
        
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    { 
        var tarefa = tarefas.FirstOrDefault(t =>t.Id == id);

        if(tarefa == null)
        {
            return NotFound();
        }

        tarefas.Remove(tarefa);

        return NoContent();
    }
}
