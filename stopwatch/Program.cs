using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;
        private bool _hasValidDuration;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            _startTime = DateTime.Now;
            _isRunning = true;
            _hasValidDuration = false;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running.");
            }

              _stopTime = DateTime.Now;
             _isRunning = false;
            _hasValidDuration = true;
        }

        public TimeSpan GetDuration()
        {
            if (_isRunning)
            {
                return DateTime.Now - _startTime;
            }

            if (_hasValidDuration)
            {
                return _stopTime - _startTime;
            }

            throw new InvalidOperationException(
                "No valid duration available.");
        }

    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("To start press 0");
            Console.WriteLine("To end press 1");
            Console.WriteLine("To show interval press 2");
            Console.WriteLine("To exit press 3");

            while (true)
            {
                string choose = Console.ReadLine();
                int x = Convert.ToInt32(choose);

                if (x == 0)
                {
                    watch.Start();
                }

                if (x == 1)
                {
                    watch.Stop();
                }

                if (x == 2)
                {
                    Console.WriteLine(watch.GetDuration());
                }

                if (x == 3)
                {
                    return;
                }
            }
        }

    }
}
