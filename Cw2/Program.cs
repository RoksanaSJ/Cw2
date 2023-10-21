using System.ComponentModel.Design;
using System.IO.IsolatedStorage;
using System.Reflection.Metadata.Ecma335;

namespace Cw2
{
    internal class Program
    {
        //nic nie zwraca
        static void nicNieZwracam(int a)
        {

        }
        //nie nie dostaje
        static void nicNiedostaje()
        {

        }

      
        static int dodaj (int a, int b)
        {
            return a + b;
        }
        static double dodaj(int b, double a)
        {
            return a + b;
        }

        static double dodaj(double a, int b)
        {
            return a + b;
        }
        //czy jest parzysta
        static bool isEven (int number)
        {   if (number % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }

        }

        //czy liczba jest liczbą pierwszą!
        static bool isPrimary(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                { return false; }
            }

            return true;
        }

        //tablica - najwiekszy element
       // static int getMax(int[] tab) 
       // {

         //   int max = tab[0];
    //  foreach (int value in tab)
           // {  if (value > max)
            //    {
           //         max = value; ;
           //     }
          //  }
            
     //   }

        //

        static int countNumberInTable (int number, int[] table)
        {
            int count = 0;
            foreach (int value in table)
            {
                if (value == number)
                {
                    count++;
                }
            }


            return count;
        }
            
        //wy swietla tablice [ , , , ]
        static void printTable(int[] tab)
        {
            string txt = "[";
            for (int i = 0; i < tab.Length; i++)
            {
                txt += tab[i];
                if (i < tab.Length - 1)
                {
                    txt += ",";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }

        //na ktorym miejscu jest dana liczba w tablicy
        // wywo lujemy funkcje, którą mamy, potem tworzę tabelkę --> przechodze przez zablice i sprawdzamy, czy np. 8 = 8 --> bierzemy indeks i zmienamy. j nam zwiększa pustą tablicę

       static int[] indexesOfNumber(int number, int[] tab)
        {
            int count = countNumberInTable(number, tab);
            int[] indexes = new int[count];
            int j = 0;
            for(int i = 0; i< tab.Length; i++)
            {
                if (tab[i] == number)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            
      }

      
        static void Main(string[] args)
        {
        int[] tab = { 1, 5, 10, 22, 14 };
          Console.WriteLine(isEven(7));
          Console.WriteLine(isPrimary(5));
         printTable(tab);
         printTable(indexesOfNumber(5, tab));
        }
    }
}