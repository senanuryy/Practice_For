using System;

namespace Practice_For
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
                        
            Console.WriteLine("\n2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
            Console.WriteLine("---------------------------------------------------------------");
            
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
            Console.WriteLine("--------------------------------------------------------------------");
           
            for (int i = 1; i <= 20; i ++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }                
            }

            Console.WriteLine("\n4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------");

            int sum = 0;
            
            for (int i = 50; i <= 150; i ++)
            {
                sum+= i;                
            }
            
            Console.WriteLine(sum);

            Console.WriteLine("\n5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i; 
                }                    
                else
                {
                    sumOdd += i;
                }                    
            }

            Console.WriteLine($"Tek sayıların toplamı: {sumOdd}");
            Console.WriteLine($"Çift sayıların toplamı: {sumEven}");

        }         
    }
}