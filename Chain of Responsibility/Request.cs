using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Request
    {
        public string Type { get; }
        public int numA {  get; }
        public int numB { get; }

        public Request(string type, int NumA,int NumB)
        {
            Type = type;
            numA = NumA;
            numB = NumB;
        }

    }
}
