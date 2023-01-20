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
    }
}
