using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("Podaj liczbę arabską od 1 do 1 000 000: ");
            a = Convert.ToDouble(Console.ReadLine());

            c = a;

            Console.Write("Twoja liczba to ");

            if (a == 1000000)
                Console.WriteLine("milion");
            
            else if (a >= 900000) { a -= 900000; Console.Write("dziewięćset "); }
            else if (a >= 800000) { a -= 800000; Console.Write("osiemset "); }
            else if (a >= 700000) { a -= 700000; Console.Write("siedemset "); }
            else if (a >= 600000) { a -= 600000; Console.Write("sześćset "); }
            else if (a >= 500000) { a -= 500000; Console.Write("pięćset "); }
            else if (a >= 400000) { a -= 400000; Console.Write("czterysta "); }
            else if (a >= 300000) { a -= 300000; Console.Write("trzysta "); }
            else if (a >= 200000) { a -= 200000; Console.Write("dwieście "); }
            else if (a >= 100000) { a -= 100000; Console.Write("sto "); }

            if (a >= 90000) { a -= 90000; Console.Write("dziewięćdziesiąt "); }
            else if (a >= 80000) { a -= 80000; Console.Write("osiemdziesiąt "); }
            else if (a >= 70000) { a -= 70000; Console.Write("siedemdziesiąt "); }
            else if (a >= 60000) { a -= 60000; Console.Write("sześćdziesiąt "); }
            else if (a >= 50000) { a -= 50000; Console.Write("pięćdziesiąt "); }
            else if (a >= 40000) { a -= 40000; Console.Write("czterdzieści "); }
            else if (a >= 30000) { a -= 30000; Console.Write("trzydzieści "); }
            else if (a >= 20000) { a -= 20000; Console.Write("dwadzieścia "); }
            else if (a >= 19000) { a -= 19000; Console.Write("dziewietnaście "); }
            else if (a >= 18000) { a -= 18000; Console.Write("osiemnaście "); }
            else if (a >= 17000) { a -= 17000; Console.Write("siedemnaście "); }
            else if (a >= 16000) { a -= 16000; Console.Write("szesnaście "); }
            else if (a >= 15000) { a -= 15000; Console.Write("piętnaście "); }
            else if (a >= 14000) { a -= 14000; Console.Write("czternaście"); }
            else if (a >= 13000) { a -= 13000; Console.Write("trzynaście "); }
            else if (a >= 12000) { a -= 12000; Console.Write("dwanaście "); }
            else if (a >= 11000) { a -= 11000; Console.Write("jedenaście "); }
            else if (a >= 10000) { a -= 10000; Console.Write("dziesięć"); }

            b = a;

            if (a >= 9000) { a -= 9000; Console.Write("dziewięć"); }
            else if (a >= 8000) { a -= 8000; Console.Write("osiem"); }
            else if (a >= 7000) { a -= 7000; Console.Write("siedem"); }
            else if (a >= 6000) { a -= 6000; Console.Write("sześć"); }
            else if (a >= 5000) { a -= 5000; Console.Write("pięć"); }
            else if (a >= 4000) { a -= 4000; Console.Write("cztery"); }
            else if (a >= 3000) { a -= 3000; Console.Write("trzy"); }
            else if (a >= 2000) { a -= 2000; Console.Write("dwa"); }
            else if (a >= 1000 && c >= 1999 && c != 1000 ) { a -= 1000; Console.Write("jeden"); }
            
            if (b <= 4999 && b >= 2000) { Console.Write(" tysiące "); }
            else if (c < 1000) { Console.Write(""); }
            else if (c >= 1000 && c < 2000 && a > 1000 || c == 1000) { a -= 1000; Console.Write(" tysiąc "); }
            else Console.Write(" tysięcy ");
            
            if (a >= 900) { a -= 900; Console.Write("dziewięćset "); }
            else if (a >= 800) { a -= 800; Console.Write("osiemset "); }
            else if (a >= 700) { a -= 700; Console.Write("siedemset "); }
            else if (a >= 600) { a -= 600; Console.Write("sześćset "); }
            else if (a >= 500) { a -= 500; Console.Write("pięćset "); }
            else if (a >= 400) { a -= 400; Console.Write("czterysta "); }
            else if (a >= 300) { a -= 300; Console.Write("trzysta "); }
            else if (a >= 200) { a -= 200; Console.Write("dwieście "); }
            else if (a >= 100) { a -= 100; Console.Write("sto "); }

            if (a >= 90) { a -= 90; Console.Write("dziewięćdziesiąt "); }
            else if (a >= 80) { a -= 80; Console.Write("osiemdziesiąt "); }
            else if (a >= 70) { a -= 70; Console.Write("siedemdziesiąt "); }
            else if (a >= 60) { a -= 60; Console.Write("sześćdziesiąt "); }
            else if (a >= 50) { a -= 50; Console.Write("pięćdziesiąt "); }
            else if (a >= 40) { a -= 40; Console.Write("czterdzieści "); }
            else if (a >= 30) { a -= 30; Console.Write("trzydzieści "); }
            else if (a >= 20) { a -= 20; Console.Write("dwadzieścia "); }

            switch (a)
            {
                case 19: Console.Write("dziewietnaście"); break;
                case 18: Console.Write("osiemnaście"); break;
                case 17: Console.Write("siedemnaście"); break;
                case 16: Console.Write("szesnaście");break;
                case 15: Console.Write("piętnaście");break;
                case 14: Console.Write("czternaście");break;
                case 13: Console.Write("trzynaście");break;
                case 12: Console.Write("dwanaście");break;
                case 11: Console.Write("jedenaście");break;
                case 10: Console.Write("dziesięć");break;
                case 9: Console.Write("dziewięć");break;
                case 8: Console.Write("osiem");break;
                case 7: Console.Write("siedem");break;
                case 6: Console.Write("sześć");break;
                case 5: Console.Write("pięć");break;
                case 4: Console.Write("cztery");break;
                case 3: Console.Write("trzy");break;
                case 2: Console.Write("dwa");break;
                case 1: Console.Write("jeden");break;
                
            }

            

                    Console.ReadKey();
        }
    }
}