using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FakeTyresNameSpace
{
    public class FakeTyres : TyreCheck
    {
        override
        public int GetPressure()
        {
            return 35;
        }
    }
}
