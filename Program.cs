using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleStars
{
    /*
        The program shows two types of stars, one that flashes and one that moves.
        Rewrite the code by introducing an interface, so that the foreloop in the
        main program can be simplified to this: 

        foreach (var star in stars)
        {
            star.Show();
            star.Update();
        }
     */
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new object[]
            {
                new PhasesStar(random),
                new PhasesStar(random),
                new PhasesStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
            };
            while (true)
            {
                Console.Clear();     
                foreach (var star in stars)
                {
                    if (star is PhasesStar)
                    {
                        var phasesStar = (PhasesStar)star;
                        phasesStar.Show();
                        phasesStar.Update();
                    }
                    else if (star is MovableStar)
                    {
                        var phasesStar = (MovableStar)star;
                        phasesStar.Show();
                        phasesStar.Update();
                    }
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
