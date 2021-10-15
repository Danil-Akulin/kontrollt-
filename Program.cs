using System;

namespace Akulin_Kontrolltöö
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Variant

        Ü 1.Sisestage klaviatuurilt suvalise pikkusega string ja arvutage stringi määratud märgi esinemise protsent.

        Ü 2.Arvestades reaalarvude massiivi mõõtmetega 10x10 Leidke iga rea ​​elementide summa, iga veeru elementide korrutis ja põhidiagonaali maksimaalne element
             (vihje: kõik elemendid, mille rea number on sama kui veeru number).
        Ü 3.Antud: teave üliõpilase kohta sisaldab järgmisi elemente:
            а) perekonnanimi, eesnimi;
            б) rühma kood;
            в) hulk hindeid iga distsipliini kohta semestris (2–5).
        Õpilasteave on M [] massiivi element.
        Stipendiumi tellimusse kaasatavate õpilaste nimed on vaja kindlaks määrata sessiooni tulemuste põhjal (tingimus - hinded kõikidel erialadel mitte alla nelja).
            */

            string[] massive_ocenok;
            string[] M;
            Console.WriteLine("Tere, palun sisestage oma ees- ja perekonnanimi");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Sisestage oma rühm (TARpv20 / TITpv20)");
            string gruppi_rühma = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Sisestage oma hinne matemaatikas, vene keeles, ujumises");
            string ocenki = Console.ReadLine();
            Console.WriteLine(ocenki);
            Console.Clear();

            int[] nums2 = new int[4];

            if (gruppi_rühma == "TARpv20")
            {/*
                if ()
                {

                }*/
            }
            else
            {
                Console.WriteLine("Kahjuks on kõik kohad võetud");
            }







            Console.Clear();
            Console.WriteLine("Sisestage suvalise pikkusega string:");
            string str = Console.ReadLine();
            Console.WriteLine("Sisestage märk, et leida selle esinemise protsent stringist:");
            char sym = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = str.Length;
            char[] strArr = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (strArr[i] == sym)
                {
                    counter++;
                }
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double prc = (counterDouble / lengthDouble) * 100;
            Console.WriteLine($"Märgi esinemise protsent {sym} on võrdne {prc}%");
            Console.ReadLine();


            while (true)
            {
                Console.Clear();
                int[,] myArray = new int[3, 3];
                Random random = new Random();
                for (int i = 0; i < myArray.GetLength(0); i++)
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        myArray[i, j] = random.Next(100);
                for (int y = 0; y < myArray.GetLength(0); y++)
                {
                    for (int x = 0; x < myArray.GetLength(1); x++)
                        Console.Write(myArray[y, x] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine("Elementide summa arvutamiseks sisestage rea number: ");
                int N = Int32.Parse(Console.ReadLine()) - 1;
                int sum = 0;
                for (int i = 0; i < myArray.GetLength(1); i++)
                    sum += myArray[N, i];
                Console.WriteLine("Elementide summa= " + sum);
                for (int y = 0; y < myArray.GetLength(0); y++)
                {
                    sum = 0;
                    for (int x = 0; x < myArray.GetLength(1); x++)
                        sum += myArray[y, x];
                    Console.WriteLine("Sisseehitatud elementide summa " + (y + 1) + " hulk = " + sum);
                }
                Console.WriteLine();
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    int proizv = 1;
                    for (int y = 0; y < myArray.GetLength(0); y++)
                        proizv *= myArray[y, x];
                    Console.WriteLine("Elementide toode aastal " + (x + 1) + " veerg = " + proizv);
                }
                Console.WriteLine();
                int max = myArray[0, 0];
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            if (max < myArray[i, j])
                            {
                                max = myArray[i, j];
                            }
                        }
                    }
                }
                Console.WriteLine("Maksimaalne element põhidiagonaalis = " + max);
                Console.ReadKey();

            }
        }
    }
}
