using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Output "99 bottles of beer on the wall.  99 bottles of beer.  Take 1 down and pass it around, 98 bottles of beer on the wall.";
            // Count down until there are no more bottles of beer on the wall.

           

            int i;
            for (i = 0; i < 100; i++)
            {
                
                if (i == 98)
                {
                    Console.WriteLine("1 bottle of beer on the wall. 1 bottle of beer. Take 1 down and pass it around,");
                    
                }
                else if (i == 99)
                {
                    {
                        Console.WriteLine("No more bottles of beer on the wall. No more bottles of beer.");

                    }
                }
                else
                {
                    Console.WriteLine($"{99 - i} bottles of beer on the wall. {99 - i} bottles of beer. Take 1 down and pass it around,");
                }

                

            }
           
            Console.ReadLine();
        }
    }
}
