using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Dimenstional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = new string[5];
            arrays[0] = "AAA";
            arrays[1] = "BBB";
            arrays[2] = "CCC";
            arrays[3] = "DDD";
            arrays[4] = "EEE";

            Console.WriteLine("\t1\t2\t3\t4\t5\n\n\t");
            for(int i=0;i<5;i++)
            {   
                Console.WriteLine("{0}\t",arrays[i]);
                Console.ReadLine();
            }

        }
    }
}
