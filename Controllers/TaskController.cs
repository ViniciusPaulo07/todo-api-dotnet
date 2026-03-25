using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using System.Linq;

[ApiController] //Diz que esta classe é uma API
[Route("api/[controller]")]
public class TasksController : ControllerBase
{

    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_context.Tarefas.ToList());
    }


    [HttpPost]
    public ActionResult Post(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();

        return Created("", tarefa);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Tarefa tarefa)
    {

        var tarefaExistente = _context.Tarefas.Find(id);

        if (tarefaExistente == null)
            return NotFound();

        tarefaExistente.Titulo = tarefa.Titulo;
        tarefaExistente.estaCompleta = tarefa.estaCompleta;

        _context.SaveChanges();

        return NoContent();
        
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    { 
        var tarefa = _context.Tarefas.Find(id);

        if(tarefa == null)
            return NotFound();

        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();

        return NoContent();
    }
}
