using System;

namespace job_two
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double w1;
               double L = 0.7;
               double m = 2;
               double w = 4;
               double a = w;
               double b = (m * m) - 1;
                w1 = (a / b);
                Console.WriteLine("w1=" + w1);
                double c = 2*w1;
                double d = L;
                double I1 = Math.Sqrt(c/d);
                Console.WriteLine("I1=" + I1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
