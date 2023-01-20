using appMiniproyecto.Data.Entities;

namespace appMiniproyecto.Services.CompetenciaService
{
    public interface ICompetenciaService
    {
        List<Competencia> GetAllCompetencias();
        Competencia GetCompetenciaById(int? id);
        bool CreateCompetencia(Competencia competencia);
        bool UdateCompetencia(Competencia competencia);
        bool DeleteCompetenciaById(int? id);
    }
}
