using Crud_User_WCF.Data.Interfaces;
using Crud_User_WCF.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Crud_User_WCF.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public void DeleteUser(Guid id)
        {
           var user = DbSet.FirstOrDefault(c => c.Id == id);
            if(user != null)
               this.Delete(user);
        }

        public Usuario GetUsuarioEnderecoById(Guid id)
        {
            return DbSet.Include(c => c.Endereco)
                .FirstOrDefault(c => c.Id == id);
        }

        public UsuarioEnderecoView GetUsuarioEnderecoViewById(Guid id)
        {
            return _dbContex.Query<UsuarioEnderecoView>().FirstOrDefault(c => c.Id == id);
        }

        public Usuario GetUsuarioId(Guid id)
        {
            return DbSet.FirstOrDefault(c => c.Id == id);

        }

        public IEnumerable<Usuario> GetUsuarioList()
        {
            return DbSet.ToList();
        }

        public void UpdateUser(Guid id, Usuario user)
        {
            var userEnttity = this.GetUsuarioEnderecoById(id);
            
            if(user != null)
            {
                var endereco = user.Endereco;
                userEnttity.Update(user.CPF, user.Nome, user.RG,user.DataExpedicao,
                   user.DataNascimento, user.OrGaoExpedicao, user.UF, user.Sexo, user.EstadoCivil);

                userEnttity.Endereco.UpdateEndereco(endereco.Cep, 
                    endereco.Logradouro, endereco.Numero, endereco.Complemento, endereco.Bairro,
                    endereco.Cidade, endereco.UF);

                this.Update(userEnttity);
            }
        }
    }
}
