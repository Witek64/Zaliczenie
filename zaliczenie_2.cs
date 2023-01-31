using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)

        {
            Wizytowka w;
            Console.WriteLine("Podaj imię: ");
            w.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            w.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj adres e-mail: ");
            w.email = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu: ");
            w.telefon = Console.ReadLine();

            int a;
            int i = w.imie.Length + w.nazwisko.Length + 1;
            int e = w.email.Length + 8;
            int t = w.telefon.Length + 5;
            
            if (Math.Max(i, e) > Math.Max(e, t))
            {
                a = Math.Max(i, e);
            }
            else
            {
                a = Math.Max(e, t);
            }
            

            int j;

            // top row
            Console.Write("*");
            for (j = 0; j < (2 * a); j++) Console.Write("*");
            Console.Write("*");

            // into 1 row
            Console.Write("\n*");

            // space before name
            for (j = 0; j < (a - i/2); j++)
            {
                Console.Write(" ");
            }

            //name
            Console.Write("{0} {1}", w.imie, w.nazwisko);

            //space after name
            if(i%2!=0){
                for (j = 0; j < ((a - 1) - i / 2); j++)
                {

                    Console.Write(" ");
                }
            }
            else
            {
                for (j = 0; j < (a - i / 2); j++)
                {

                    Console.Write(" ");
                }
            }
            
            //ending star of 1 row
            Console.Write("*");

            // into 2 row
            Console.Write("\n*");

            // space before email
            for (j = 0; j < (a - e / 2); j++)
            {
                Console.Write(" ");
            }

            //email
            Console.Write("e-mail: {0}", w.email);

            //space after email
            if (e % 2 != 0)
            {
                for (j = 0; j < ((a - 1) - e / 2); j++)
                {

                    Console.Write(" ");
                }
            }
            else
            {
                for (j = 0; j < (a - e / 2); j++)
                {

                    Console.Write(" ");
                }
            }

            //ending star of 2 row
            Console.Write("*");

            // into 3 row
            Console.Write("\n*");

            // space before phone
            for (j = 0; j < (a - t / 2); j++)
            {
                Console.Write(" ");
            }

            //name
            Console.Write("tel. {0}", w.telefon);

            //space after phone
            if (t % 2 != 0)
            {
                for (j = 0; j < ((a - 1) - t / 2); j++)
                {

                    Console.Write(" ");
                }
            }
            else
            {
                for (j = 0; j < (a - t / 2); j++)
                {

                    Console.Write(" ");
                }
            }

            //ending star of 3 row
            Console.Write("*");

            // into closing row
            Console.Write("\n");

            // bottom row
            Console.Write("*");
            for (j = 0; j < (2 * a); j++) Console.Write("*");
            Console.Write("*");

            Console.ReadKey();
        }
    }

    struct Wizytowka
    {
        public string imie, nazwisko, email, telefon;
    }
}
