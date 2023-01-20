using appMiniproyecto.Data;
using appMiniproyecto.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace appMiniproyecto.Repositories.CompetenciaRepository
{
    public class CompetenciaRepository : ICompetenciaRepository
    {
        private readonly ApplicationDbContext _context;


        public CompetenciaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateCompetencia(Competencia competencia)
        {
            _context.Add(competencia);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteCompetenciaById(int? id)
        {
            Competencia competencia = _context.Competencias
                //.Include(c => c.Programa)
                .FirstOrDefault(c => c.Competencia_Id == id);

            if (competencia == null)
            {
                return false;
            }
            competencia.IsActive = false;
            _context.Update(competencia);
            return _context.SaveChanges() > 0;
        }

        public List<Competencia> GetAllCompetencias()
        {
            return _context.Competencias.ToList();
        }

        public Competencia GetCompetenciaById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            Competencia objCompetencia = _context.Competencias.Find(id);
            return objCompetencia;
        }

        public bool UdateCompetencia(Competencia competencia)
        {
            _context.Entry(competencia).State= EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
