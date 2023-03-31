using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();
            TimeSpan td1 = crono1.Elapsed;
            TimeSpan td2 = crono2.Elapsed;
            string elapsedTime = String.Format("{2:00}.{3:00}",
            td1.Hours, td1.Minutes, td1.Seconds,
            td1.Milliseconds / 10);
            string elapsedTime2 = String.Format("{2:00}.{3:00}",
            td2.Hours, td2.Minutes, td2.Seconds,
            td2.Milliseconds / 10);
            Console.WriteLine("Tempo decorrido no cronometro 1: " + elapsedTime +" Tempo decorrido no cronometro 2: " + elapsedTime2);

        }   
    }
}
