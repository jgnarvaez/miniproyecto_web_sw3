using appMiniproyecto.Data.Entities;

namespace appMiniproyecto.Repositories.AmbienteRepository
{
    public interface IAmbienteRepository
    {
        List<Ambiente> GetAllAmbientes();
        Ambiente GetAmbienteById(int? id);
        bool CreateAmbiente(Ambiente ambiente);
        bool UpdateAmbiente(Ambiente ambiente);

    }
}
