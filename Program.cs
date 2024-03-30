using System;

namespace assignment8ex1
{
    class Program
    {
        // Declaring the delegate
        public delegate void HereComesTheSunDelegate();

        public class HereComesTheSun
        {
            public static void chorus()
            {
                Console.Write("Here comes the sun, doo-doo-doo-doo\r\n");
                Console.WriteLine("Here comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
            }
            public static void chorus2()
            {
                Console.WriteLine("Here comes the sun\r\nHere comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.WriteLine("Sun, sun, sun, here it comes");
                Console.WriteLine();
            }
            public static void verse1()
            {
                Console.Write("Little darlin', it's been a long, cold, lonely winter\r\n");
                Console.WriteLine("Little darlin', it feels like years since it's been here");
                Console.WriteLine();
            }
            public static void verse2()
            {
                Console.Write("Little darlin', the smile's returning to their faces\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been here");
                Console.WriteLine();
            }
            public static void verse3()
            {
                Console.Write("Little darlin', I feel that ice is slowly melting\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been clear");
                Console.WriteLine();
            }
            public static void end()
            {
                Console.WriteLine("It's alright");
            }
            public static void title()
            {
                Console.WriteLine("Title:"+"Here comes the sun");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate
            Program.HereComesTheSunDelegate delegateInstance = new Program.HereComesTheSunDelegate(HereComesTheSun.title);

            // Add methods to the delegate
            delegateInstance += HereComesTheSun.chorus;
            delegateInstance += HereComesTheSun.verse1;
            delegateInstance += HereComesTheSun.chorus;
            delegateInstance += HereComesTheSun.verse2;
            delegateInstance += HereComesTheSun.chorus2;
            delegateInstance += HereComesTheSun.verse3;
            delegateInstance += HereComesTheSun.chorus;
            delegateInstance += HereComesTheSun.chorus;
            delegateInstance += HereComesTheSun.end;

            // Invoke the multicast delegate
            delegateInstance();
        }
    }
}
