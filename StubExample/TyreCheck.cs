using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTyresNameSpace
{
    public class TyreCheck
    {
        virtual public int GetPressure()
        {
            Random random = new Random();
            return random.Next(0, 35);
        }
    }
}
