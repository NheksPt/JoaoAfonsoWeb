using JoaoAfonso.Domain.Entities;
using JoaoAfonso.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JoaoAfonsoWeb.Controllers
{
    public class AnimacaoController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AnimacaoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var animacao = _db.Animacao_Trabalhos.ToList();
            return View(animacao);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animacao_trabalhos obj)
        {
            if (obj.Nome == obj.Descricao)
            {
                ModelState.AddModelError("", "The Description cannot match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Animacao_Trabalhos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
