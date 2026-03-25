using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

public class AppDbContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    { 
    }
}