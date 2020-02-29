using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();

            ConsoleColor[] darkColors = { 
                   
                  ConsoleColor.DarkBlue,   
                  ConsoleColor.DarkCyan,
                  ConsoleColor.DarkGreen,
                  ConsoleColor.DarkMagenta,
                  ConsoleColor.DarkYellow
                    
            };

            int randomIndex;
            int duration = 1000;

            Console.Beep(3200, duration);

            Console.SetWindowPosition(0, 0);
            
            while (true)
            {
                

               Console.SetWindowSize(
                    
                    random.Next(10, Console.LargestWindowWidth),
                    random.Next(10, Console.LargestWindowHeight)
               );

                randomIndex = random.Next(0, darkColors.Length);

                Console.BackgroundColor = darkColors[randomIndex];

                Console.Clear();
                Console.Beep(random.Next(37, 3200), duration);
                Thread.Sleep(duration);

            }



            string title = "I'm Khan and I'm not a Programmer";

            int i;

            Console.Title = "";
            for (i = 0; i < title.Length; i++)
            {

                Console.Title += Convert.ToString(title[i]);
                Thread.Sleep(250);

            }


            



            

            







           

            while (true)
            {
               

                
                Thread.Sleep(250);
            }

            






            string[,] rectangl = new string[10, 10];

            rectangl[0, 0] = "ali";

            string[][] jagged = new string[10][];








        }
    }
}
