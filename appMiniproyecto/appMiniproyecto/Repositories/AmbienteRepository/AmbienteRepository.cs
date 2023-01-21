using appMiniproyecto.Data;
using appMiniproyecto.Data.Entities;

namespace appMiniproyecto.Repositories.AmbienteRepository
{
    public class AmbienteRepository : IAmbienteRepository
    {
        private readonly ApplicationDbContext _context;

        public AmbienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateAmbiente(Ambiente ambiente)
        {
            _context.Add(ambiente);
            return _context.SaveChanges() > 0;
        }

        public List<Ambiente> GetAllAmbientes()
        {
            return _context.Ambientes.ToList();
        }

        public Ambiente GetAmbienteById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            Ambiente objAmbiente = _context.Ambientes.Find(id);
            return objAmbiente;
        }

        public bool UpdateAmbiente(Ambiente ambiente)
        {
            _context.Update(ambiente);
            return _context.SaveChanges() > 0;
        }
    }
}
