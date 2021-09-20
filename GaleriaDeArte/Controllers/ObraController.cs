using GaleriaDeArte.Models;
using GaleriaDeArte.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GaleriaDeArte.Controllers
{
    public class ObraController : Controller
    {
        IObraService _service, _serviceSql, _serviceStatic, _serviceTudo;
        
        public ObraController(ObraSqlService serviceSql, ObraStaticService serviceStatic, ObraFullService serviceTudo)
        {
            _serviceSql = serviceSql;
            _serviceStatic = serviceStatic;
            _serviceTudo = serviceTudo;
            _service = serviceSql;
        }

        public void SelectService(string service = "sql")
        {
            switch (service)
            {
                case "static":
                    this._service = this._serviceStatic;
                    break;
                case "both":
                    this._service = this._serviceTudo;
                    break;
                default:
                    this._service = this._serviceSql;
                    break;
            }
        }

        public IActionResult Index(string busca, bool ordenar = false, string service = "sql")
        {
            SelectService(service);

            ViewBag.ordenar = ordenar;
            ViewBag.total = _service.GetAll(busca, ordenar).Count;
            ViewBag.valortotal = _service.GetAll(busca, ordenar).Count == 0 ? default : _service.GetAll(busca, ordenar).Sum(p => p.Preco);
            ViewBag.maisAntiga = _service.GetAll(busca, ordenar).Count == 0 ? default : _service.GetAll(busca, ordenar).Find(o => o.Data == _service.GetAll(busca, ordenar).Max(p => p.Data)).Nome;
            ViewBag.maisCara = _service.GetAll(busca, ordenar).Count == 0 ? default : _service.GetAll(busca, ordenar).Find(o => o.Preco == _service.GetAll(busca, ordenar).Max(p => p.Preco)).Nome;
            ViewBag.service = service;
            ViewBag.busca = busca;
            return View(_service.GetAll(busca, ordenar));
                       

            //List<Obra> lista = getObras();
            //List<Obra> lista = _context.Obra.ToList(); // No meu contexto, pegue a tabela do meu Modelo e traga para uma lista.
            //if (ordenar) // Vousempre comparar os meus elementos, sempre de dois em dois, sabendo qual fica antes e qual depois.
            //{                
            //    // o método CompareTo() vai ver ser se a string que estou pasando dentro está antes, igual ou depois.
            //    lista = lista.OrderBy(o => o.Nome).ToList(); // ordenar a lista por um campo específico (nome). Dentro dele são dois parâmetros. Comparando nome da ObraA com a ObraB e já vai ordenando.
                
            //    return View(lista);
            //    //lista = lista.OrderBy(o => o.Nome).ToList();
            //    //return View(lista); Essa é outra forma de se fazer. Esseé mais fácil de entender
            //}

            //List<Obra> obras = busca != null ? lista.FindAll(o => o.Nome.ToUpper().Contains(busca.ToUpper())) : lista;
            //ViewBag.total = obras.Count();
            //ViewBag.valortotal = obras.Sum(o => o.Preco);
            //return View(obras); // tenho que passar os dados aqui para ter o que mostrar na index através do Model.           
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken] // só devemos inserir nos métodos post, para validar o token.
        public IActionResult Create(Obra obra)
        {
            if (!ModelState.IsValid) return View(obra);

            if (_service.Create(obra))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(obra);
            }
        }            

        public IActionResult Read(int? id)
        {
            Obra obra = _service.Get(id);
            return obra != null ?
                View(obra) :
                NotFound();
        }

        [Authorize]
        public IActionResult Update(int? id)
        {
            Obra obra = _service.Get(id);
            return obra != null ?
                View(obra) :
                NotFound();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Obra obra)
        {
            if (!ModelState.IsValid) return View(obra); //validaçao

            if (_service.Update(obra)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(obra);
            }
        }

        [Authorize]
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

        [Authorize]
        public IActionResult Confirm(Obra obra)
        {
            ViewBag.obra = obra.Id;
            ViewBag.confirm = "Tem certeza que deseja deletar esta obra?";
            return View();
        }
    }
}
