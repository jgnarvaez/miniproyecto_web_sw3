using appMiniproyecto.Data.Entities;
using appMiniproyecto.Services.CompetenciaService;
using Microsoft.AspNetCore.Mvc;

namespace appMiniproyecto.Controllers
{
    public class CompetenciasController : Controller
    {
        private readonly ICompetenciaService _service;

        public CompetenciasController(ICompetenciaService service) {
            _service = service;
        }
        public IActionResult Index()
        {
            List<Competencia> competencias = _service.GetAllCompetencias();
            //var listaCompetencias = competencias.Where(c => c.IsActive);

            return View(competencias);
        }

        public IActionResult Create()
        {   
            Competencia competencia = new Competencia();
            return View(competencia);
        }

        [HttpPost]
        public IActionResult Create(Competencia modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_service.CreateCompetencia(modelo))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception)
                {

                    return NotFound();
                }
            }
            return View(modelo);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Competencia competencia = _service.GetCompetenciaById(id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Competencia competencia)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                competencia.Competencia_Id = (int)id;
                _service.UdateCompetencia(competencia);
                return RedirectToAction(nameof(Index));
            }
            return View(competencia);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Competencia competencia = _service.GetCompetenciaById(id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.DeleteCompetenciaById(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
