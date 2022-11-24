using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pro_vodnik_
{
    internal class menu

    {
         public static  int position = 0;
        public  menu(int a, int b)
        {
            min = a;
            max = b;

        }

        public static int menushka() 
        {
           
        
        while (y.clavisha.Key != ConsoleKey.F2)
          {
               
                
                if (y.clavisha.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("  ");
                    position--;

                    if (position < min)
                    {
                        position = min;
                    }
                }
                
                if (y.clavisha.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("  ");
                    position++;
                    if (position > max )
                    {
                        position = max;
                    }
                }

            
                else if (y.clavisha.Key == ConsoleKey.Enter)
                {
                    break;

                }
                else if (y.clavisha.Key == ConsoleKey.Escape)
                {
                    return -1;
                }
                Console.SetCursorPosition(0, position);
               
                Console.WriteLine("->");
                y.clavisha = Console.ReadKey();

            }
            return position;
        }
        public static int max;
        public static int min;
            

    }
}
