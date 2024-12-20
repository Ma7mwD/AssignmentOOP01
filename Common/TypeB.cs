using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        public int d;
        public TypeB()
        {
            TypeA t = new TypeA();
            d = t.y + t.z; 
        }

    }
}
