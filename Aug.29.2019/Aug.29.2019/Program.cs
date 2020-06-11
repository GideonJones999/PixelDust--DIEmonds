using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Aug._29._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 For PixelDust");
            Console.WriteLine("2 For DIEmonds");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                PixelDust();
            else
                DIEmonds();
        }
        static void PixelDust()
        {
            Console.Clear();
            //SSS
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sandstorm_9);
            player.PlayLooping();
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Random num = new Random();
            while (true){
                Console.Write(" ");
                Console.BackgroundColor = (ConsoleColor)(num.Next((15)+1));
            }
        }
        static void DIEmonds()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 5-(i-1); j >= 1; j--)
                {
                    Console.Write(" "); 
                }
                for (int j = i*2-1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                for (int j = 5 - (i - 1); j >= 1; j--)
                {
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 5 - (i - 1); j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i * 2 - 1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                for (int j = 5 - (i - 1); j >= 1; j--)
                {
                    Console.Write(" ");

                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
