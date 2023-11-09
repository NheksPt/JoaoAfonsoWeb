using JoaoAfonso.Domain.Entities;
using JoaoAfonso.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

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
       
    }
}
