using appMiniproyecto.Data.Entities;
using appMiniproyecto.Services.AmbienteService;
using appMiniproyecto.Services.CompetenciaService;
using Microsoft.AspNetCore.Mvc;

namespace appMiniproyecto.Controllers
{
    public class AmbientesController : Controller
    {
        private readonly IAmbienteService _service;

        public AmbientesController(IAmbienteService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            List<Ambiente> ambientes = _service.GetAllAmbientes();

            return View(ambientes);
        }

        public IActionResult Create()
        {
            Ambiente ambiente = new Ambiente();
            return View(ambiente);
        }

        [HttpPost]
        public IActionResult Create(Ambiente modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_service.CreateAmbiente(modelo))
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

            Ambiente ambiente = _service.GetAmbienteById(id);
            if (ambiente == null)
            {
                return NotFound();
            }

            return View(ambiente);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Ambiente ambiente)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                ambiente.Id = (int)id;
                _service.UpdateAmbiente(ambiente);
                return RedirectToAction(nameof(Index));
            }
            return View(ambiente);
        }

        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Ambiente ambiente = _service.GetAmbienteById(id);
        //    if (ambiente == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(ambiente);
        //}
    }
}
