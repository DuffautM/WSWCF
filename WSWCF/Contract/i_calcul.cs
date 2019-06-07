using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    [ServiceContract(Namespace = " http:eXia_A4_WCF1")]
    public interface i_calcul
    {
        [OperationContract]
        int m_add(int n, int m);
        [OperationContract]
        int m_sous(int n, int m);
        [OperationContract]
        int m_mul(int n, int m);
    }
}
