using appMiniproyecto.Data.Entities;
using appMiniproyecto.Repositories.AmbienteRepository;
using NuGet.Protocol.Core.Types;

namespace appMiniproyecto.Services.AmbienteService
{
    public class AmbienteService : IAmbienteService
    {
        private readonly IAmbienteRepository _ambienteRepository;

        public AmbienteService(IAmbienteRepository ambienteRepository)
        {
            _ambienteRepository = ambienteRepository;
        }
        public bool CreateAmbiente(Ambiente ambiente)
        {
            return _ambienteRepository.CreateAmbiente(ambiente);
        }

        public List<Ambiente> GetAllAmbientes()
        {
            return _ambienteRepository.GetAllAmbientes();
        }

        public Ambiente GetAmbienteById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return _ambienteRepository.GetAmbienteById(id);
        }

        public bool UpdateAmbiente(Ambiente ambiente)
        {
            return _ambienteRepository.UpdateAmbiente(ambiente);
        }
    }
}
