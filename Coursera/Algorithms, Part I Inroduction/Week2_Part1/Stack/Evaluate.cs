using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    private class Evaluate
    {
        // Двухстековый алгоритм Дейкстры
        public void Run()
        {
            Stack<string> operations = new Stack<string>();
            Stack<double> vals = new Stack<double>();

            string s;
            do
            {
                s = Console.In.ReadLine();

                if (s.Equals("(")) ;
                else if (s.Equals("+"))
                    operations.Push(s);
                else if (s.Equals("-"))
                    operations.Push(s);
                else if (s.Equals("*"))
                    operations.Push(s);
                else if (s.Equals("/"))
                    operations.Push(s);
                else if (s.Equals(")"))
                {
                    string op = operations.Pop();
                    double v = vals.Pop();

                    if (op.Equals("+"))
                        v = vals.Pop() + v;
                    else if (op.Equals("-"))
                        v = vals.Pop() - v;
                    else if (op.Equals("*"))
                        v = vals.Pop() * v;
                    else if (op.Equals("/"))
                        v = vals.Pop() / v;
                    vals.Push(v);
                }
                else if (!string.IsNullOrEmpty(s))
                    vals.Push(double.Parse(s));
            }
            while (!string.IsNullOrEmpty(s));


            Console.WriteLine(vals.Pop());
            Console.ReadLine();
        }
    }
}
