using System;

namespace probleme_setul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prb1();
            //prb2();
            //prb3();
            //prb4();
            //prb5();
            //prb6();
            //prb7();
            //prb8();
            //prb9();
            //prb10();
            //prb11();
            //prb12();
            //prb13();
            //prb14();
            //prb15();
            //prb16();
            //prb17();
        }
        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
        /// </summary>
        private static void prb17()
        {
            int n, a, contor = 0, f = 0, max = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Secventa nu este parantezata corect");
            }
            else
            {
                contor++;
                for (int i = 2; i <= n; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        contor++;
                    }
                    else
                    {
                        if (a == 1)
                        {
                            contor--;
                            if (contor != 0)
                            {
                                f++;
                                if (f > max)
                                {
                                    max = f;
                                }
                            }
                        }
                    }

                }
                if (contor == 0 && a != 0)
                {
                    Console.WriteLine($"Secventa este parantezata corect iar nivelul maxim de incuibare a parantezelor este {max}");
                }
                else
                {
                    Console.WriteLine("Secventa nu este parantezata corect");
                }

            }
            Console.ReadLine();
        }
        /// <summary>
        /// Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        private static void prb16()
        {
            int n, a, b = 0, c = 0, d = 0, aux, f = 1, aux2 = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            aux = a;
            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (i == 2)
                {
                    aux = b;
                }
                if (a < b && d != 0)
                {
                    f = 0;
                    break;
                }
                if (a > b && c != 0)
                {
                    d--;
                }
                if (a < b)
                {
                    c++;
                }
                a = b;
            }
            if (f == 1 && (aux <= aux2 || aux <= b))
            {
                Console.WriteLine("Secventa este bitonica rotita");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica rotita");
            }
            Console.ReadLine();
        }
        /// <summary>
        ///  Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        private static void prb15()
        {
            int n, c = 0, a, b, f = 1, d = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            if (n == 2)
            {
                Console.WriteLine("Secventa nu este bitonica");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if (a <= b && d == 0)
                    {
                        c++;
                    }
                    else
                    {
                        if (a > b && c == 0)
                        {
                            f = 0;
                            break;
                        }
                        else
                        {
                            if (a >= b && c != 0)
                            {
                                d++;
                            }
                            else
                            {
                                if (a < b && d != 0)
                                {
                                    f = 0;
                                    break;
                                }
                            }
                        }
                    }
                    a = b;
                }
                if (f == 1)
                {
                    Console.WriteLine("Secventa este bitonica");
                }
                else
                {
                    Console.WriteLine("Secventa nu este bitonica");
                }
            }
            Console.ReadLine();
        }

        private static void prb14()
        {

            Console.ReadLine();

        }
        /// <summary>
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>


        private static void prb13()
        {
            int n, a, b = 0, f = 1, d = 0, aux;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            aux = a;
            if (n == 2)
            {
                Console.WriteLine("Secventa este crescatoare rotita");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if (a > b && d != 0)
                    {
                        f = 0;
                        break;
                    }
                    if (a > b)
                    {
                        d++;
                    }
                    a = b;
                }
                if (aux < b)
                {
                    f = 0;
                }
                if (f == 1)
                {
                    Console.WriteLine("Secventa este crescatoare rotita");
                }
                else
                {
                    Console.WriteLine("Secventa nu este crescatoare rotita");
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// </summary>
        private static void prb12()
        {
            int n, a, c = 0, b, cont = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a != 0 && b != 0)
                {
                    c++;
                }
                else
                {
                    if (c != 0)
                    {
                        cont++;
                        c = 0;
                    }
                    else
                    {
                        c = 0;
                    }
                }
                a = b;
            }
            if (c != 0)
            {
                cont++;
            }
            if (cont != 0)
            {
                Console.WriteLine($"In secventa sunt {cont} grupuri de numere consecutive diferite de 0");
            }
            else
            {
                Console.WriteLine("In secventa nu sunt grupuri de numere consecutive diferite de 0");
            }
            Console.ReadLine();

        }
        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        private static void prb11()
        {
            int n, a, invers, cifr, suma = 0, aux;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                invers = 0;
                a = int.Parse(Console.ReadLine());
                aux = a;
                while (aux != 0)
                {
                    cifr = aux % 10;
                    invers = invers * 10 + cifr;
                    aux = aux / 10;
                }
                suma += invers;
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este {suma}");
            Console.ReadLine();
        }
        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void prb10()
        {
            int a, contor = 1, b, n, max = 0, f = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a == b)
                {
                    contor++;
                    if (contor > max)
                    {
                        max = contor;
                    }
                    f++;
                }
                else
                {
                    contor = 1;
                }
                a = b;
            }
            if (f != 0)
            {
                Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {max}");
            }
            else
            {
                Console.WriteLine("In secventa nu sunt numere consecutive egale");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// </summary>
        private static void prb9()
        {
            int n, a, b, v = 0, c1 = 0, c2 = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    c1++;
                }
                else
                {
                    if (a > b && c1 != 0)
                    {
                        v++;
                        break;
                    }
                }
                if (a > b)
                {
                    c2++;
                }
                else
                {
                    if (a < b && c2 != 0)
                    {
                        v++;
                        break;
                    }
                }
                a = b;
            }
            if (v == 0)
            {
                Console.WriteLine("Secventa este monotona");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci.
        /// </summary>
        private static void prb8()
        {
            int n, f1, f2, f = 0;
            n = int.Parse(Console.ReadLine());
            f1 = 0;
            f2 = 1;
            if (n == 1)
            {
                Console.WriteLine("Primul termen din sir este 0");
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine("Al doilea termen din sir este 1");
                }
            }
            for (int i = 3; i <= n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
            }
            if (n > 2)
            {
                Console.WriteLine($"Al {n} lea termen din sir este {f}");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        private static void prb7()
        {
            int n, max = int.MinValue, min = int.MaxValue, a;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine($"Valoarea minima din secventa este {min},iar valoarea maxima {max}");
            Console.ReadLine();

        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void prb6()
        {
            int a, b, c, cont = 0, n;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (n == 2)
            {
                if (a <= b)
                {
                    Console.WriteLine("Numerele din serie sunt in ordine crescatoare");
                }
                else
                {
                    Console.WriteLine("Numerele din serie nu sunt in ordine crescatoare");
                }
            }
            else
            {

                for (int i = 3; i <= n; i++)
                {
                    c = int.Parse(Console.ReadLine());
                    if (!(a <= b && b <= c))
                    {
                        cont++;
                        break;
                    }
                    a = b;
                    b = c;
                }
                if (cont != 0)
                {
                    Console.WriteLine("Numerele din serie nu sunt in ordine crescatoare");
                }
                else
                {
                    Console.WriteLine("Numerele din serie sunt in ordine crescatoare");
                }
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        private static void prb5()
        {
            int n, a, contor = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i == a)
                {
                    contor++;
                }
            }
            Console.WriteLine($"{contor} elemente sunt egale cu pozitia pe care apar");
            Console.ReadLine();
        }
        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
        /// </summary>
        private static void prb4()
        {
            int n, contor = 0, a, x, f = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                {

                    f = 1;
                    break;
                }
                contor++;
            }
            if (f == 1)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {contor}");
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void prb3()
        {
            int n, suma = 0, prod = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                prod *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este {prod}");
            Console.ReadLine();
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void prb2()
        {
            int n, c1 = 0, c2 = 0, c3 = 0, nr;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > 0)
                {
                    c1++;
                }
                if (nr == 0)
                {
                    c2++;
                }
                if (nr < 0)
                {
                    c3++;
                }
            }
            Console.WriteLine($"Sunt {c1} numere pozitive,{c2} numere egale cu 0 si {c3} numere negative");
            Console.ReadLine();
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        private static void prb1()
        {
            int n, x, contor = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    contor++;
            }
            Console.WriteLine($"numarul de numare pare este {contor}");
            Console.ReadLine();
        }
    }
}