using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    [ServiceContract(Namespace = " http:eXia_A4_WCF1")]
    public interface i_dispatching
    {

        [OperationContract]
        MSG dispatching(MSG msg);

    }

    [DataContract]
    public struct MSG
    {
        [DataMember]
        public bool op_statut;
        [DataMember]
        public string op_name;
        [DataMember]
        public string op_infos;
        [DataMember]
        public string app_name;
        [DataMember]
        public string app_version;
        [DataMember]
        public string app_token;
        [DataMember]
        public string user_token;
        [DataMember]
        public string user_login;
        [DataMember]
        public string user_password;
        [DataMember]
        public object[] data_table;
    }
}
