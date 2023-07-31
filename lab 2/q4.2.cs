using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace HelloWorldNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloObj = new HelloWorld();
            helloObj.SayHello(); 
            Console.ReadLine(); 
        }
    }
}