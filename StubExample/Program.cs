using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeTyresNameSpace;
namespace StubExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //accelerate(new InnerWork(), new FakeTyres());
        }
        public static int  accelerate(InnerWork iw,TyreCheck tc)
        {
            //Console.WriteLine(tc.GetPressure());
            //Console.ReadLine();
            if (iw.StartCar()&&tc.GetPressure()==35)
            {
                return 10;
            }
                return 0;
        } 
    }
}
