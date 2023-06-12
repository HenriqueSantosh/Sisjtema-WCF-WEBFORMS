using Crud_User_WCF.Data.Entity;
using Crud_User_WCF.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Interfaces
{
    public interface IUsuarioService 
    {
        UsuarioModel GetUsuarioId(Guid id);
        IEnumerable<UsuarioModel> GetUsuarioList();
        UsuarioEnderecoViewModel GetUsuarioEnderecoViewById(Guid id);
        void Add(UsuarioModel obj);
        void Update(Guid id, UsuarioModel obj);
        void Delete(Guid id);
    }
}
