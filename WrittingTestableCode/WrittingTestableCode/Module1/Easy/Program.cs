﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittingTestableCode.Module1.Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = decimal.Parse(args[0]);
            var service = decimal.Parse(args[1]);
            var discount = decimal.Parse(args[2]);
            Calculator calculator=new Calculator();
            var total = calculator.GetTotal(parts,service,discount);
            Console.WriteLine($"Total Price: {total}");

        }
    }
}
