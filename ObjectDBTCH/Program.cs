﻿using System;
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
            Field pole = new Field(1);
            pole.Chng_check();
            Console.WriteLine(pole.Value + ":" +pole.Check);
            pole.Chng_check();
            Console.WriteLine(pole.Check);
            Console.ReadKey();
        }
    }
}
