/*
    README
    
    kəsrləri nöqtə (.) ilə deyil, vergül (,) ilə qeyd edin

*/
using System;

namespace MinHalfMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1 = 0, X2 = 0, A = 0, B = 0, Result;

            Console.WriteLine("Numune:     f(x) = i1*X^3 + i2*X^2 + i3*X + i4");

            Console.Write("En boyuk dereceni (quvvet) daxil edin: ");
            int Derece=Convert.ToInt32(Console.ReadLine());
            int[] IndexArr=new int[Derece+1];

            for (int i = 0; i < Derece+1; i++)
            {
                Console.Write($">>>  i{i+1} = ");
                IndexArr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n-----[A;b] ");
            Console.Write("A = ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("B = ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSiqma = ");
            double Siqma = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEpsilon = ");
            double Epsilon = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                X1 = (A + B - Siqma) / 2;
                X2 = (A + B + Siqma) / 2;

                if (FxCalculator(IndexArr, Derece, X1) > FxCalculator(IndexArr, Derece, X2))
                    A = X1;
                else
                    B = X2;

                Console.WriteLine($"X1 = {X1}    X2 = {X2}    A = {A}    B = {B} \n\n");
                if (Math.Abs(A - B) <= Epsilon)
                {
                    Result = (A + B) / 2;
                    break;
                }
            }
            Console.WriteLine($"x* = (a+b)/2 = {Result}");
        }

        public static double FxCalculator(int[] IndexArr,int Derece, double x)
        {
            double result = 0;
            for (int i = 0; i < Derece+1; i++)
            {
                result += IndexArr[i]*Math.Pow(x,Derece-i);
            }
            return result;
        }
    }
}
