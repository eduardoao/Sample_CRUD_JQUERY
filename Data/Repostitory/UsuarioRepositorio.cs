using Domain.Entities;
using Domain.Interfaces;
using System.Linq;

namespace Data.Repostitory
{
    public class UsuarioRepositorio<T> : Repository<T> where T : Usuario
    {
        private Context.DataAccessContext context;

        public UsuarioRepositorio()
        {
            context = System.Activator.CreateInstance<Context.DataAccessContext>();

        }

        public UsuarioRepositorio(Context.DataAccessContext  Contexto): base( Contexto)
        {

        }

        public Usuario SelectEmail(Usuario obj)
        {            
            return context.Set<Usuario>().Where(c => c.Email == obj.Email).Select(s =>s).FirstOrDefault();
        }


    }
}
