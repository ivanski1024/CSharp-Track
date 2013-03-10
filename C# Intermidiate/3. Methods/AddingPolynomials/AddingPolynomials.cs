using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int[] polynom1 = EnterPolynom(), polynom2 = EnterPolynom();
            int[] polynomSum = SumPolynoms(polynom1, polynom2);
            Console.WriteLine(" {0}\n+\n {1}\n=\n {2}", PrintThisPolynom(polynom1), PrintThisPolynom(polynom2), PrintThisPolynom(polynomSum));
        }

        static StringBuilder PrintThisPolynom(int[] p)
        {
            StringBuilder output = new StringBuilder();
            bool first = true;
            for (int i = p.Length - 1; i >= 0; i--)
            {
                if (p[i] != 0)
                {
                    if (!first)
                    {
                        output.Append("+ ");
                    }
                    output.Append(p[i]);
                    if (i == 1)
                    {
                        output.Append("x ");
                    }
                    else if (i > 1)
                    {
                        output.Append("x^");
                        output.Append(i);
                        output.Append(" ");

                    }
                    first = false;
                }
            }
            return output;
        }

        static int[] SumPolynoms(int[] p1, int[] p2)
        {
            int[] p3 = p1.Length < p2.Length ? SumPolynomsWithDifferentLength(p1, p2) : SumPolynomsWithDifferentLength(p2, p1);
            return p3;
        }

        static int[] SumPolynomsWithDifferentLength(int[] shortP, int[] longP)
        {
            int[] p = new int[longP.Length];
            for (int i = 0; i < shortP.Length; i++)
            {
                p[i] = shortP[i] + longP[i];
            }
            for (int i = shortP.Length; i < longP.Length; i++)
            {
                p[i] = longP[i];
            }
            return p;
        }

        static int[] EnterPolynom()
        {
            Console.WriteLine("Enter a polynoms queficients:");
            string line = Console.ReadLine();
            string[] quef = line.Split(' ');
            int[] polynomQuef = new int[quef.Length];
            for (int i = 0; i < quef.Length; i++)
            {
                polynomQuef[i] = int.Parse(quef[i]);
            }
            return polynomQuef;
        }
    }
}
