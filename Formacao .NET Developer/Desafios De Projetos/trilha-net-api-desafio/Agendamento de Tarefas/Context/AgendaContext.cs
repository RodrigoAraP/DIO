using Agendamento_de_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Agendamento_de_Tarefas.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
