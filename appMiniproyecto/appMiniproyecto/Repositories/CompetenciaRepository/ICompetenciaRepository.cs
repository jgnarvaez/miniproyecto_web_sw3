using appMiniproyecto.Data.Entities;

namespace appMiniproyecto.Repositories.CompetenciaRepository
{
    public interface ICompetenciaRepository
    {
        List<Competencia> GetAllCompetencias();
        Competencia GetCompetenciaById(int? id);
        bool CreateCompetencia(Competencia competencia);
        bool UdateCompetencia(Competencia competencia);
        bool DeleteCompetenciaById(int? id);
    }
}
