using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using field_space;

namespace ObjectDBTCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Field pole = new Field("front","tyl");
            Console.WriteLine(pole.Fld_foregrnd);
            Console.ReadKey();
        }
    }
}
