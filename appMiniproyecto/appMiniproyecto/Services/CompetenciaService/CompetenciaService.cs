using appMiniproyecto.Data.Entities;
using appMiniproyecto.Repositories.CompetenciaRepository;

namespace appMiniproyecto.Services.CompetenciaService
{
    public class CompetenciaService : ICompetenciaService
    {
        private readonly ICompetenciaRepository _repository;

        public CompetenciaService(ICompetenciaRepository repository) {
            _repository = repository;
        }
        public bool CreateCompetencia(Competencia competencia)
        {
            return _repository.CreateCompetencia(competencia);
        }

        public bool DeleteCompetenciaById(int? id)
        {
            if (id==null)
            {
                return false;
            }
            return _repository.DeleteCompetenciaById(id);
        }

        public List<Competencia> GetAllCompetencias()
        {
            return _repository.GetAllCompetencias();
        }

        public Competencia GetCompetenciaById(int? id)
        {
            if (id==null)
            {
                return null;
            }
            return _repository.GetCompetenciaById(id);
        }

        public bool UdateCompetencia(Competencia competencia)
        {
            return _repository.UdateCompetencia(competencia);
        }
    }
}
