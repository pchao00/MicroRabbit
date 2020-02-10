

//using NetStandard;
using NetStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Test();
            Console.WriteLine(obj.Echo("aa"));

        }
    }
}
