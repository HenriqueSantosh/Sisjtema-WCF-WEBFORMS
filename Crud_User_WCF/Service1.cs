using Crud_User_WCF.Services.Interfaces;
using Crud_User_WCF.Services.Model;
using Crud_User_WCF.Services.Repository;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text.Json;

namespace Crud_User_WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class Service1 : IService1
    {
        private readonly IUsuarioService _usuarioService;

        public Service1()
        {
            _usuarioService = new UsuarioService();
        }

        public IEnumerable<UsuarioModel> GetUserList()
        {
            return _usuarioService.GetUsuarioList();
        }

       
        public UsuarioModel GetUserById(Guid id)
        {
            return _usuarioService.GetUsuarioId(id);
        }

        public bool Add(UsuarioModel obj)
        {
            try
            {
                _usuarioService.Add(obj);
                return true;

            }
            catch (Exception ex)
            {
                throw new FaultException($"Erro ao  {ex}");                
            }
        }

        public bool Update(Guid id, UsuarioModel obj)
        {
            try
            {
               _usuarioService.Update(id, obj);
                return true;
            }
            catch (Exception ex)
            {
                throw new FaultException($"Erro ao deletar usúario {ex}");                
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                _usuarioService.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                throw new FaultException($"Erro ao deletar usúario {ex}");
            }
        }

        public EnderecoWS GetEnderecoWS(string CEP)
        {
            try
            {
                RestClient rest = new RestClient($"https://viacep.com.br/ws/{CEP}/json/");
                RestRequest restRequest = new RestRequest();
                restRequest.Method = Method.Get;

                RestResponse responde = rest.Execute(restRequest);

                if (responde.ContentLength <= -1 ||
                    responde.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    throw new Exception("Erro ao consultar o CEP");

                EnderecoWS enderecoWS = JsonSerializer.Deserialize<EnderecoWS>(responde.Content);
                return enderecoWS;
            }
            catch (Exception ex)
            {
                throw new FaultException($"Erro de Servidor {ex}");                
            }
           
        }

        public UsuarioEnderecoViewModel GetUsuarioEnderecoViewById(Guid id)
        {
            try
            {
                return _usuarioService.GetUsuarioEnderecoViewById(id);
            }
            catch (Exception ex)
            {

                throw new FaultException($"Erro ao recuperar o usúario {ex}");
            }
        }
    }
}
