using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Problem13AverageLoadTimeCalculator
{
    class Problem13AverageLoadTimeCalculator
    {
        static void Main(string[] args)
        {
            var URLs = new[] 
        { 
            "http://www.google.com", 
            "http://softuni.bg ", 
            "http://www.slashdot.org"
        };

            var tasks = URLs.Select(
            url => Task.Factory.StartNew(task =>
            {
                using (var client = new WebClient())
                {
                    var t = (string)task;
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    String result = client.DownloadString(t);
                    stopwatch.Stop();
                    Console.WriteLine(String.Format("{0} = {1}", url, stopwatch.Elapsed));
                }
            }, url)
                ).ToArray();
            Task.WaitAll(tasks);
        }
    }
}
