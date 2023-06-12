using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Model
{
    [DataContract]
    public class EnderecoModel
    {
        [DataMember(Order = 1)]
        public Guid Id { get; private set; }

        [DataMember(Order = 2)]
        public string Cep { get; private set; }

        [DataMember]
        public string Logradouro { get; private set; }

        [DataMember]
        public string Numero { get; private set; }

        [DataMember]
        public string Complemento { get; private set; }

        [DataMember]
        public string Bairro { get; private set; }

        [DataMember]
        public string Cidade { get; private set; }

        [DataMember]
        public string UF { get; private set; }

        public EnderecoModel()
        {
            
        }

        public EnderecoModel(string cep, string logradouro, string numero,
          string complemento, string bairro, string cidade, string uF)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }

        public EnderecoModel(Guid id, string cep, string logradouro, string numero,
         string complemento, string bairro, string cidade, string uF)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }
    }
}
