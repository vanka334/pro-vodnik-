using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_vodnik_
{
    internal static  class diski
    {

        public static void diskach()
        {
            
            int i = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int kolvo = allDrives.Length;
            foreach (var item in allDrives)
            {
                
            Console.WriteLine("  " + item.Name  + "  Всего места: " + ((item.TotalSize/1024)/1024)/1024+ " Гб" + "   Свободного места:  " + ((item.TotalFreeSpace/ 1024)/1024)/1024 + " Гб");
            }
            menu menu = new menu(0,kolvo - 1);

            int pos = menu.menushka();
            y.clavisha = Console.ReadKey();
            Console.Clear();
            tuc(allDrives[pos].ToString());
            y.clavisha = new ConsoleKeyInfo((char)ConsoleKey.Z, ConsoleKey.Z, false, false, false);
            pos = 0;



        }
        
        static void tuc(string paf)
        {
            while (y.clavisha.Key != ConsoleKey.T)
            {
                int pos = 0;
                string[] directories = Directory.GetDirectories(paf);
                string[] allFiles = Directory.GetFiles(paf);
                int kolvo = directories.Length + allFiles.Length;
                menu menu = new menu(0,kolvo - 1);
                foreach(var item in directories )
                {
                    Console.WriteLine("  "+ item);
                }
                foreach(var item in allFiles)
                {
                    Console.WriteLine("  " + item);
                }
                y.clavisha= new ConsoleKeyInfo((char)ConsoleKey.Z,ConsoleKey.Z,false,false,false);
                pos = menu.menushka();
                Console.Clear();
                if (pos == -1)
                {
                    return;
                }
                

                else if (pos < directories.Length)
                {
                    tuc(directories[pos].ToString());
                }
                else 
                {
                    Process.Start(new ProcessStartInfo { FileName = allFiles[pos - directories.Length], UseShellExecute = true });
                }
                
                 
            }

        }
    }
}
