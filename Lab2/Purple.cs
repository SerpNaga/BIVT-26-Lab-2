using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i=1; i <= n; i++)
            {
                answer += (p+(n-1)*h)*2;
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (b <= a)
            {
                ++quotient;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
            while (b>0)
            {
                number *= b;
                b--;
            }
            while (number>=10)
            {
                number /= 10;
                answer++;
            }
                // end

                return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            for (int i=1; i <= 64; i++)
            {
                answer += (long)Math.Pow(2, i);
            }
            answer /= 15*1000;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}