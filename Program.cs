using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo(1,2,"M");
            Console.WriteLine("{0}", td);
            Console.ReadLine();
        }
        
    }
}