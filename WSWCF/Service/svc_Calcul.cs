using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class svc_Calcul : i_calcul
    {
        public int m_add(int n, int m)
        {
            Console.WriteLine("Add");
            return n + m;
        }

        public int m_sous(int n, int m)
        {
            Console.WriteLine("Substract");
            return n - m;
        }

        public int m_mul(int n, int m)
        {
            Console.WriteLine("Multiply");
            return n * m;
        }

    }
}
