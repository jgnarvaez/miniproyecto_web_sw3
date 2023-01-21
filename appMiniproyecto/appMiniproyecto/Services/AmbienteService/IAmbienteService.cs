using appMiniproyecto.Data.Entities;

namespace appMiniproyecto.Services.AmbienteService
{
    public interface IAmbienteService
    {
        List<Ambiente> GetAllAmbientes();
        Ambiente GetAmbienteById(int? id);
        bool CreateAmbiente(Ambiente ambiente);
        bool UpdateAmbiente(Ambiente ambiente);
    }
}
