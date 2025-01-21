
using System;

namespace Setul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            //Problema6();
            //Problema7();
            //Problema8();
            //Problema9();
            //Problema10();
            //Problema11();
            //Problema12();
            //Problema13();
            //Problema14();
            //Problema15();
            //Problema16();
            //Problema17();
        }

        private static void Problema1()
        {
            Console.Write("Introduceti numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int contorPare = 0;

            Console.WriteLine($"Introduceti cele {n} numere:");
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                {
                    contorPare++;
                }
            }

            Console.WriteLine($"Numarul de elemente pare este: {contorPare}");
        }

        private static void Problema2()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int countNegative = 0;
            int countZero = 0;
            int countPositive = 0;

            Console.WriteLine($"Introdu cele {n} numere:");
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());

                if (numar < 0)
                {
                    countNegative++;
                }
                else if (numar == 0)
                {
                    countZero++;
                }
                else
                {
                    countPositive++;
                }
            }

            Console.WriteLine($"Numere negative: {countNegative}");
            Console.WriteLine($"Numere zero: {countZero}");
            Console.WriteLine($"Numere pozitive: {countPositive}");
        }

        private static void Problema3()
        {
            Console.Write("Introdu valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            int produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }

        private static void Problema4()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu numarul a: ");
            int a = int.Parse(Console.ReadLine());

            int pozitie = -1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == a && pozitie == -1)
                {
                    pozitie = i;
                }
            }

            Console.WriteLine($"Pozitia numarului {a} in secventa este: {pozitie}");
        }

        private static void Problema5()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == i)
                {
                    count++;
                }
            }

            Console.WriteLine($"Numarul de elemente egale cu pozitia lor este: {count}");
        }

        private static void Problema6()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            bool esteCrescatoare = true;
            Console.Write("Introdu elementul 0: ");
            int anterior = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int curent = int.Parse(Console.ReadLine());

                if (curent < anterior)
                {
                    esteCrescatoare = false;
                }

                anterior = curent;
            }

            Console.WriteLine($"Secventa este crescatoare: {esteCrescatoare}");
        }

        private static void Problema7()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu primul element: ");
            int numar = int.Parse(Console.ReadLine());

            int maxim = numar;
            int minim = numar;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                numar = int.Parse(Console.ReadLine());

                if (numar > maxim)
                {
                    maxim = numar;
                }

                if (numar < minim)
                {
                    minim = numar;
                }
            }

            Console.WriteLine($"Cea mai mare valoare este: {maxim}");
            Console.WriteLine($"Cea mai mica valoare este: {minim}");
        }

        private static void Problema8()
        {
            Console.Write("Introdu valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Primul numar din sirul lui Fibonacci este: 0");
            }
            else if (n == 2)
            {
                Console.WriteLine("Al 2-lea numar din sirul lui Fibonacci este: 1");
            }
            else
            {
                int a = 0, b = 1, fib = 0;

                for (int i = 3; i <= n; i++)
                {
                    fib = a + b;
                    a = b;
                    b = fib;
                }

                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {fib}");
            }
        }

        private static void Problema9()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            bool esteMonotonaCrescatoare = true;
            bool esteMonotonaDescrescatoare = true;

            Console.Write("Introdu elementul 0: ");
            int anterior = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int curent = int.Parse(Console.ReadLine());

                if (curent < anterior)
                {
                    esteMonotonaCrescatoare = false;
                }

                if (curent > anterior)
                {
                    esteMonotonaDescrescatoare = false;
                }

                anterior = curent;
            }

            if (esteMonotonaCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare");
            }
            else if (esteMonotonaDescrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona");
            }
        }

        private static void Problema10()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int maxConsecutive = 1;
            int countConsecutive = 1;

            Console.Write("Introdu elementul 0: ");
            int numar = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int curent = int.Parse(Console.ReadLine());

                if (curent == numar)
                {
                    countConsecutive++;
                    if (countConsecutive > maxConsecutive)
                    {
                        maxConsecutive = countConsecutive;
                    }
                }
                else
                {
                    countConsecutive = 1;
                }

                numar = curent;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {maxConsecutive}");
        }

        private static void Problema11()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            double sumaInverselor = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                double numar = double.Parse(Console.ReadLine());

                if (numar != 0)
                {
                    sumaInverselor += 1 / numar;
                }
                else
                {
                    Console.WriteLine("Nu se poate calcula inversa pentru 0.");
                }
            }

            Console.WriteLine($"Suma inverselor numerelor din secventa este: {sumaInverselor}");
        }

        private static void Problema12()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int grupuri = 0;
            bool inGrup = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar != 0)
                {
                    if (!inGrup)
                    {
                        grupuri++;
                        inGrup = true;
                    }
                }
                else
                {
                    inGrup = false;
                }
            }

            Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {grupuri}");
        }

        private static void Problema13()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu elementul 0: ");
            int numar = int.Parse(Console.ReadLine());

            int primul = numar;
            int ultimul = numar;
            bool esteCrescatoare = true;


            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                numar = int.Parse(Console.ReadLine());

                if (numar < ultimul)
                {
                    esteCrescatoare = false;
                }

                ultimul = numar;
            }

            if (esteCrescatoare)
            {
                Console.WriteLine("Secventa este crescatoare.");
                return;
            }

            bool esteCrescatoareRotita = false;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Introdu elementul pentru rotirea " + i + ": ");
                numar = int.Parse(Console.ReadLine());

                if (numar < primul)
                {
                    esteCrescatoareRotita = true;
                    break;
                }

                primul = numar;
            }

            if (esteCrescatoareRotita)
            {
                Console.WriteLine("Secventa este crescatoare rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este crescatoare rotita.");
            }
        }

        private static void Problema14()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu elementul 0: ");
            int numar = int.Parse(Console.ReadLine());

            int primul = numar;
            int ultimul = numar;
            bool esteMonotonaCrescatoare = true;
            bool esteMonotonaDescrescatoare = true;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                numar = int.Parse(Console.ReadLine());

                if (numar < ultimul)
                    esteMonotonaCrescatoare = false;

                if (numar > ultimul)
                    esteMonotonaDescrescatoare = false;

                ultimul = numar;
            }

            if (esteMonotonaCrescatoare || esteMonotonaDescrescatoare)
            {
                Console.WriteLine("Secventa este monotona.");
                return;
            }

            bool esteMonotonaRotita = false;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Introdu elementul pentru rotirea " + i + ": ");
                numar = int.Parse(Console.ReadLine());

                if (numar < primul)
                {
                    esteMonotonaRotita = true;
                    break;
                }

                primul = numar;
            }

            if (esteMonotonaRotita)
                Console.WriteLine("Secventa este monotona rotita.");
            else
                Console.WriteLine("Secventa nu este monotona rotita.");
        }

        private static void Problema15()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu elementul 0: ");
            int numar = int.Parse(Console.ReadLine());

            int primul = numar;
            int ultimul = numar;
            bool esteCrescatoare = true;
            bool esteBitonica = false;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                numar = int.Parse(Console.ReadLine());

                if (esteCrescatoare)
                {
                    if (numar < ultimul)
                    {
                        esteCrescatoare = false;
                        esteBitonica = true;
                    }
                }

                if (!esteCrescatoare)
                {
                    if (numar > ultimul)
                    {
                        esteBitonica = false;
                        break;
                    }
                }

                ultimul = numar;
            }

            if (esteBitonica)
                Console.WriteLine("Secventa este bitonica.");
            else
                Console.WriteLine("Secventa nu este bitonica.");
        }

        private static void Problema16()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu elementul 0: ");
            int numar = int.Parse(Console.ReadLine());

            int primul = numar;
            int ultimul = numar;
            bool esteCrescatoare = true;
            bool esteBitonica = false;
            bool esteBitonicaRotita = false;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introdu elementul {i}: ");
                numar = int.Parse(Console.ReadLine());

                if (esteCrescatoare)
                {
                    if (numar < ultimul)
                    {
                        esteCrescatoare = false;
                        esteBitonica = true;
                    }
                }

                if (!esteCrescatoare)
                {
                    if (numar > ultimul)
                    {
                        esteBitonica = false;
                        break;
                    }
                }

                ultimul = numar;
            }


            if (esteBitonica)
            {
                Console.WriteLine("Secventa este bitonica.");
                return;
            }

            for (int i = 1; i < n; i++)
            {
                int rotitPrimul = ultimul;
                int rotitUltimul = primul;
                bool rotitCrescator = true;
                bool rotitBitonica = true;

                for (int j = 0; j < n; j++)
                {
                    if (rotitCrescator)
                    {
                        if (rotitPrimul < rotitUltimul)
                        {
                            rotitCrescator = false;
                            rotitBitonica = true;
                        }
                    }

                    if (!rotitCrescator)
                    {
                        if (rotitPrimul > rotitUltimul)
                        {
                            rotitBitonica = false;
                            break;
                        }
                    }

                    rotitUltimul = rotitPrimul;
                    rotitPrimul = numar;
                }

                if (rotitBitonica)
                {
                    esteBitonicaRotita = true;
                    break;
                }
            }


            if (esteBitonicaRotita)
                Console.WriteLine("Secventa este bitonica rotita.");
            else
                Console.WriteLine("Secventa nu este bitonica rotita.");
        }

        private static void Problema17()
        {
            Console.Write("Introdu numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int nivel = 0;
            int maxNivel = 0;
            bool corect = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementul {i} (0 sau 1): ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == 0)
                    nivel++;
                else if (numar == 1)
                    nivel--;

                if (nivel < 0)
                {
                    corect = false;
                    break;
                }

                if (nivel > maxNivel)
                    maxNivel = nivel;
            }

            if (nivel != 0)
                corect = false;

            if (corect)
                Console.WriteLine($"Secventa este corecta si nivelul maxim de incuibare este {maxNivel}.");
            else
                Console.WriteLine("Secventa nu este corecta.");
        }

    }
}
