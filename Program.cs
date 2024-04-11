using System;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To jest równanie kwadratowe: ax^2 + bx + c = 0!");

            Console.WriteLine("Podaj liczbę a!");
            double mka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b!");
            double mkb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę c!");
            double mkc = Convert.ToDouble(Console.ReadLine());

            int mkl0 = 0; // w niektórych miejscach zerowych wychodzi -0, dlatego jest ten int

            if (mka == 0)
            {
                double mkrl = -(mkc / mkb);
                if (mkb > 0)
                {
                    if (mkc == 0)
                    {
                        Console.WriteLine("Jest to równanie liniowe i wygląda w następujący sposób:\n" +
                            "{0}x + {1} = 0", mkb, mkc);
                        Console.WriteLine("Równanie liniowe ma następujące miejsce zerowe: {0}", mkl0);
                    }
                    else
                    {
                        Console.WriteLine("Jest to równanie liniowe i wygląda w następujący sposób:\n" +
                            "{0}x + {1} = 0", mkb, mkc);
                        Console.WriteLine("Równanie liniowe ma następujące miejsce zerowe: {0}", mkrl);
                    }
                }
                else
                {
                    Console.WriteLine("Jest to równanie liniowe i wygląda w następujący sposób:\n" +
                        "{0}x + {1} = 0", mkb, mkc);
                    Console.WriteLine("Równanie liniowe ma następujące miejsce zerowe: {0}", mkrl);
                }
            }
            else
            {
                Console.WriteLine("Twoje równanie kwadratowe wygląda w następujący sposób:\n" +
                    "{0}x^2 + {1}x + {2} = 0", mka, mkb, mkc);

                double mkdelta = (mkb * mkb) - (4 * mka * mkc);
                Console.WriteLine("Twoja delta wynosi: {0}", mkdelta);
                if (mkdelta < 0)
                {
                    Console.WriteLine("Równanie kwadratowe nie ma miejsc zerowych!");
                }
                else if (mkdelta == 0)
                {
                    double mkx0 = -((mkb) / (2 * mka));
                    if (mkx0 == -0)
                    {
                        Console.WriteLine("Równanie kwadratowe ma jedno miejsce zerowe! Jest to {0}!", mkl0);
                    }
                    else
                    {
                        Console.WriteLine("Równanie kwadratowe ma jedno miejsce zerowe! Jest to {0}!", mkx0);
                    }
                }
                else
                {
                    double mkpierwiastek = Convert.ToDouble(Math.Sqrt(mkdelta));
                    Console.WriteLine("Pierwiastek z delty wynosi: {0}", mkpierwiastek);
                    double mkx1 = ((-mkb - mkpierwiastek) / (2 * mka));
                    double mkx2 = ((-mkb + mkpierwiastek) / (2 * mka));

                    if (mkx1 == -0)
                    {
                        Console.WriteLine("Równanie kwadratowe ma dwa miejsca zerowe! To są: {0} i {1}!", mkl0, mkx2);
                    }
                    else if (mkx2 == -0)
                    {
                        Console.WriteLine("Równanie kwadratowe ma dwa miejsca zerowe! To są: {0} i {1}!", mkx1, mkl0);
                    }
                    else
                    {
                        Console.WriteLine("Równanie kwadratowe ma dwa miejsca zerowe! To są: {0} i {1}!", mkx1, mkx2);
                    }
                }
            }
        }
    }
}