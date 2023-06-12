using Crud_User_WCF.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace Crud_User_WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<UsuarioModel> GetUserList();

        [OperationContract]
        UsuarioModel GetUserById(Guid id);

        [OperationContract]
        UsuarioEnderecoViewModel GetUsuarioEnderecoViewById(Guid id);

        [OperationContract]
        bool Add(UsuarioModel obj);
       
        [OperationContract]
        bool Update(Guid id, UsuarioModel obj);

        [OperationContract]
        bool Delete(Guid id);

        [OperationContract]
        EnderecoWS GetEnderecoWS(string CEP);

        // TODO: Adicione suas operações de serviço aqui
    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    // Você pode adicionar arquivos XSD ao projeto. Depois de criar o projeto, use os tipos de dados definidos nele diretamente, com o namespace "Crud_User_WCF.ContractType".
   
}
