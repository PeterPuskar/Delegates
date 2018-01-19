using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {
        private Timer timer; //* kvoli simulacii prehriatiu stroja
        private Random randomizer = new Random();

        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed();


        }

        public delegate void PrehratiHandler(int teplota);
        public event PrehratiHandler Prehrati;



        

    }
}