using Crud_User_WCF.Data.Entity;
using Crud_User_WCF.Data.Interfaces;
using Crud_User_WCF.Data.Repository;
using Crud_User_WCF.Services.Interfaces;
using Crud_User_WCF.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Repository
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }
        public void Add(UsuarioModel obj)
        {
            var user = new Usuario(obj.CPF,obj.Nome, obj.RG, obj.DataExpedicao,
                obj.DataNascimento, obj.OrGaoExpedicao, obj.UF, obj.Sexo, obj.EstadoCivil);

            var enderecoModel = obj.EnderecoModel;
            var endereco = new Endereco(enderecoModel.Cep, enderecoModel.Logradouro,
                enderecoModel.Numero, enderecoModel.Complemento, enderecoModel.Bairro,
                 enderecoModel.Cidade, enderecoModel.UF);

             user.SetEndreco(endereco, user.Id);
                
            _repository.Add(user);
        }

        public void Delete(Guid id)
        {
            _repository.DeleteUser(id);
        }

        public UsuarioEnderecoViewModel GetUsuarioEnderecoViewById(Guid id)
        {
            var view = _repository.GetUsuarioEnderecoViewById(id);
            return new UsuarioEnderecoViewModel(view.Id, view.Nome, view.CPF, view.RG, view.DataExpedicao,
                view.OrgaoExpedicao, view.UFExpedicao, view.DataNascimento, view.Sexo, view.EstadoCivil,
                view.CEP, view.Logradouro, view.Numero, view.Complemento, view.Bairro, view.Cidade, view.UF);
        }

        public UsuarioModel GetUsuarioId(Guid id)
        {
            var obj = _repository.GetUsuarioId(id);
            return new UsuarioModel(obj.Id, obj.CPF, obj.Nome, obj.RG, obj.DataExpedicao,
                obj.DataNascimento, obj.OrGaoExpedicao, obj.UF, obj.Sexo, obj.EstadoCivil);
                
        }

        public IEnumerable<UsuarioModel> GetUsuarioList()
        {
            var listUser = _repository.GetUsuarioList();
            return listUser.Select(obj => new UsuarioModel(obj.Id, obj.CPF, obj.Nome, obj.RG, obj.DataExpedicao,
                obj.DataNascimento, obj.OrGaoExpedicao, obj.UF, obj.Sexo, obj.EstadoCivil)).ToList();
        }

        public void Update(Guid id,UsuarioModel obj)
        {
            var enderecoModel = obj.EnderecoModel;

            var user = new Usuario();         
            user.Update(obj.CPF, obj.Nome, obj.RG, obj.DataExpedicao,
                obj.DataNascimento, obj.OrGaoExpedicao, obj.UF, obj.Sexo, obj.EstadoCivil);

            var endereco = new Endereco(enderecoModel.Cep, enderecoModel.Logradouro, enderecoModel.Numero,
                enderecoModel.Complemento, enderecoModel.Bairro, enderecoModel.Cidade, enderecoModel.UF);
            user.SetEndreco(endereco, id);
            
            _repository.UpdateUser(id, user);
        }
    }
}
