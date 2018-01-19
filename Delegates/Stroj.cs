using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazevStroje;
        private Teplomer teplomer = new Teplomer();

        public Stroj(string nazevStroje)
        {
            teplomer.PrehratiStroje



            this.nazevStroje = nazevStroje;
        }
        private void onPrehratiStroje(int teplota)
        {
            Console.WriteLine("Doslo k prehriatiu Stroja")
            VypniStroj();
        }

        public void ZapniStroj()
        {
            Console.WriteLine("Vypinam {0}", nazevStroje);
        }


    }


}