using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Model
{
    [DataContract]
    public class UsuarioEnderecoViewModel
    {
        
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public string RG { get; set; }

        [DataMember]
        public DateTime DataExpedicao { get; set; }

        [DataMember]
        public string OrgaoExpedicao { get; set; }

        [DataMember]
        public string UFExpedicao { get; set; }

        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public string Sexo { get; set; }

        [DataMember]
        public string EstadoCivil { get; set; }

        [DataMember]
        public string CEP { get; set; }

        [DataMember]
        public string Logradouro { get; set; }

        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public string Complemento { get; set; }

        [DataMember]
        public string Bairro { get; set; }

        [DataMember]
        public string Cidade { get; set; }

        [DataMember]
        public string UF { get; set; }

        public UsuarioEnderecoViewModel()
        {
            
        }

        public UsuarioEnderecoViewModel(Guid id, string nome, string Cpf,
            string rG, DateTime dataExpedicao, string orgaoExpedicao,
            string uFExpedicao, DateTime dataNascimento, string sexo,
            string estadoCivil, string cEP, string logradouro, string
            numero, string complemento, string bairro, string cidade, string uF)
        {
            Id = id;
            Nome = nome;
            CPF = Cpf;
            RG = rG;
            DataExpedicao = dataExpedicao;
            OrgaoExpedicao = orgaoExpedicao;
            UFExpedicao = uFExpedicao;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }


    }
}

