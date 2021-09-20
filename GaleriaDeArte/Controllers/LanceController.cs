using GaleriaDeArte.Models;
using GaleriaDeArte.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GaleriaDeArte.Controllers
{
    public class LanceController : Controller
    {
        ILanceService _service;
        ObraSqlService _obraSql;
        
        public LanceController(ILanceService serviceSql, ObraSqlService obraSql)
        {
            _service = serviceSql;
            _obraSql = obraSql;
        }

        public IActionResult Index(string busca, bool ordenar)
        {
            return View(_service.GetAll(User.Identity.Name));        
        }


        [HttpGet]
        public IActionResult Create(string busca, bool ordenar)
        {
            var obras = _obraSql.GetAll(busca, ordenar);
            ViewBag.listaDeObras = new SelectList(obras, "Id", "Nome"); // Nessa hora que a gente mostra o nome ao invés do ID.
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // só devemos inserir nos métodos post, para validar o token.
        public IActionResult Create(Lance lance, string busca, bool ordenar)
        {
            var obras = _obraSql.GetAll(busca, ordenar);
            ViewBag.listaDeObras = new SelectList(obras, "Id", "Nome"); // Nessa hora que a gente mostra o nome ao invés do ID.

            if (!ModelState.IsValid) return View(lance);

            if (_service.Create(lance, User.Identity.Name))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(lance);
            }
        }            

        
        public IActionResult Read(int? id)
        {
            Lance lance = _service.Get(id);
            return lance != null ?
                View(lance) :
                NotFound();
        }

        
        public IActionResult Update(int? id, string busca, bool ordenar)
        {
            var obras = _obraSql.GetAll(busca, ordenar);
            ViewBag.listaDeObras = new SelectList(obras, "Id", "Nome"); // Nessa hora que a gente mostra o nome ao invés do ID.

            Lance lance = _service.Get(id);
            return lance != null ?
                View(lance) :
                NotFound();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Lance lance, string busca, bool ordenar)
        {
            var obras = _obraSql.GetAll(busca, ordenar);
            ViewBag.listaDeObras = new SelectList(obras, "Id", "Nome"); // Nessa hora que a gente mostra o nome ao invés do ID.

            if (!ModelState.IsValid) return View(lance); //validaçao

            if (_service.Update(lance)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(lance);
            }
        }

        
        public IActionResult Delete(int? id)
        {
            if (_service.Delete(id)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }       

        
        public IActionResult Confirm(Lance lance)
        {
            ViewBag.obra = lance.Id;
            ViewBag.confirm = "Tem certeza que deseja deletar este lance?";
            return View();
        }
    }
}
