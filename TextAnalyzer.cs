﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("treasureisland.txt");
            System.Console.WriteLine(input);
        }

    }
}
