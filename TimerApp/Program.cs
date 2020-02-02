using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Timer mytime = new Timer(new TimerCallback(TheTime), null, 0, 1000);
            Console.ReadLine();

          

        }

            static void TheTime(object time)
            {
                Console.WriteLine(DateTime.Now.ToString("h: mm:ss"));
            }

        }
    }

