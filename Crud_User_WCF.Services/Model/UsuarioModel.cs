using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Model
{
    [DataContract]
    public class UsuarioModel
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public string RG { get;  set; }

        [DataMember]
        public DateTime DataExpedicao { get;  set; }

        [DataMember]
        public DateTime DataNascimento { get;  set; }

        [DataMember]
        public string OrGaoExpedicao { get;  set; }

        [DataMember]
        public string UF { get;  set; }

        [DataMember]
        public string Sexo { get;  set; }

        [DataMember]
        public string EstadoCivil { get;  set; }

        [DataMember]
        public EnderecoModel EnderecoModel { get; set; }

        public UsuarioModel()
        {
                
        }

        public UsuarioModel(Guid id, string cPF, string nome,
                        string rG, DateTime dataExpedicao, DateTime dtNascimento, string orGaoExpedicao,
                        string uF, string sexo, string estadoCivil)
        {
            Id = id;
            CPF = cPF;
            Nome = nome;
            RG = rG;
            DataExpedicao = dataExpedicao;
            DataNascimento = dtNascimento;
            OrGaoExpedicao = orGaoExpedicao;
            UF = uF;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }
    }
}
