using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            new IProblem[]
                {
                    /*
                    new Problem1(),
                    new Problem2(),
                    new Problem3(),
                    new Problem4()
                    */
                    new Problem5()
                }
                .ForEach(Execute);
        }

        private static void Execute(IProblem p)
        {
            WriteHeader(p);
            TimedExecute(p);
        }

        private static void WriteHeader(IProblem p)
        {
            Separator();
            Debug.WriteLine(p.Name);
            Debug.WriteLine(p.Description);
            Separator();
        }

        private static void Separator()
        {
            Debug.WriteLine("-------------------------------");
        }

        private static void TimedExecute(IProblem problem)
        {
            var timer = Stopwatch.StartNew();
            var result = problem.Execute();
            timer.Stop();

            Debug.WriteLine(string.Format("Executed in {0}ms", timer.ElapsedMilliseconds));
            Debug.WriteLine(string.Format("Result: {0}", result));
        }
    }
}
