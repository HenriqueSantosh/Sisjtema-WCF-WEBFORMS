using Crud_User_WCF.Data.Entity; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Data.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario GetUsuarioId(Guid id);
        Usuario GetUsuarioEnderecoById(Guid id);
        UsuarioEnderecoView GetUsuarioEnderecoViewById(Guid id);
        IEnumerable<Usuario> GetUsuarioList();
        void DeleteUser(Guid id);
        void UpdateUser(Guid id, Usuario user);

    }
}
