using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    static class Calculator
    {
        public static dynamic Add(dynamic a, dynamic b)
            => double.Parse(a) + double.Parse(b);
        public static dynamic Sub(dynamic a, dynamic b)
            => double.Parse(a) - double.Parse(b);
        public static dynamic Mul(dynamic a, dynamic b)
            => double.Parse(a) * double.Parse(b);
        public static dynamic Div(dynamic a, dynamic b)
            => double.Parse(a) / double.Parse(b);

        public static bool TryParse(string str, out dynamic result)
        {
            result = 0;
            var args = str.Split(' ');
            if (args.Length != 3)
                return false;
            switch (args[1])
            {
                case "+":
                    result = Calculator.Add(args[0], args[2]);
                    return true;
                case "-":
                    result = Calculator.Sub(args[0], args[2]);
                    return true;
                case "*":
                    result = Calculator.Mul(args[0], args[2]);
                    return true;
                case "/":
                    result = Calculator.Div(args[0], args[2]);
                    return true;
                default:
                    return false;
            }
        }
    }
}
