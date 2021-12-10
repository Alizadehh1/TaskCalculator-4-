using System;

namespace Task_12._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Emeliyyati daxil edin ( '+' '-' '*' '/' ) : ");
            string calcul = Console.ReadLine();
            
            if (calcul == "+" )
            {
                Console.Write("A ededini daxil Et: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("B ededini daxil Et: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Toplama(a, b);
            }
            else if (calcul=="-")
            {
                Console.Write("A ededini daxil Et: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("B ededini daxil Et: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Ferg(a, b);
            }
            else if (calcul=="*")
            {
                Console.Write("A ededini daxil Et: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("B ededini daxil Et: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Hasil(a,b);
            }
            else if (calcul=="/")
            {
                Start1:
                    Console.Write("A ededini daxil Et: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("B ededini daxil Et: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Nisbet(a,b);
                if (b == 0)
                {
                    Console.WriteLine("Ededleri Duzgun daxil edin!!");
                    goto Start1;
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Emeliyyati Duzgun Daxil edin!");
            }
        }

        static double Toplama(double a,double b)
        {
            double cem = a + b;
            Console.WriteLine($"{a} + {b} = {cem}");
            return cem;
        }
        static double Ferg(double a, double b)
        {
            
            double ferg = a - b;
            Console.WriteLine($"{a} - {b} = {ferg}");
            return ferg;
        }
        static double Hasil(double a, double b)
        {
            double hasil = a * b;
            Console.WriteLine($"{a} * {b} = {hasil}");
            return hasil;
        }
        static double Nisbet(double a, double b)
        {

            double nisbet = a / b;
            Console.WriteLine($"{a} / {b} = {nisbet}");
            return nisbet;
        }
    }
}
