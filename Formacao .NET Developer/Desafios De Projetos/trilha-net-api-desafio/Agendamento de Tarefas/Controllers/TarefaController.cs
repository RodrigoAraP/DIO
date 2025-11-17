using Agendamento_de_Tarefas.Context;
using Microsoft.AspNetCore.Mvc;
using Agendamento_de_Tarefas.Models;

namespace Agendamento_de_Tarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly AgendaContext _context;

        public TarefaController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index(string filtro, string valor)
        {
            var tarefas = _context.Tarefas.AsQueryable();

            if (string.IsNullOrEmpty(filtro) || string.IsNullOrEmpty(valor))
                return View(tarefas.ToList());

            if (filtro == "Titulo")
                tarefas = tarefas.Where(t => t.Titulo.Contains(valor));

            if (filtro == "Data" && DateTime.TryParse(valor, out DateTime data))
                tarefas = tarefas.Where(t => t.Data.Date == data.Date);

            if (filtro == "Status" && Enum.TryParse<StatusTarefa>(valor, out var status))
                tarefas = tarefas.Where(t => t.Status == status);

            return View(tarefas.ToList());
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }

        public IActionResult Editar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null) return RedirectToAction("Index");

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(tarefa.Id);

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null) return RedirectToAction(nameof(Index));

            return View(tarefa);
        }

        public IActionResult Deletar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null) return RedirectToAction(nameof(Index));

            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
