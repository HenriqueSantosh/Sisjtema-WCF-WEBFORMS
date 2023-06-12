using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Services.Model
{
    [DataContract]
    public class EnderecoWS
    {

        [DataMember]
        public string cep { get; set; }

        [DataMember]
        public string logradouro { get; set; }

       [DataMember]
        public string bairro { get; set; }

        [DataMember]
        public string localidade { get; set; }

        [DataMember]
        public string uf { get; set; }

    }
}
