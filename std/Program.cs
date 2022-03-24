using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string line = Console.ReadLine();

            int n = int.Parse(line);

            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            int sum = arr.Sum();
            double mean = sum / (double)n;

            double sqDevSum = 0;
            foreach(int val in arr)
            {
                double deviation = val - mean;
                sqDevSum += deviation * deviation; 
            }

            double std = Math.Sqrt(sqDevSum/n);

            Console.WriteLine($"{std:0.0}");

            return;
        }
    }
}
