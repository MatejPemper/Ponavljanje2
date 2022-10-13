using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvljanje2
{
    internal class Program
    {

        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            public Stablo(bool otpadajuListovi)
            {
                OtpadajuListovi = otpadajuListovi;
            }

             bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
            public override string ToString()
            {
                if (OtpadajuListovi == true)
                { vrstaStabla = "bijelogoricno"; }

                if (OtpadajuListovi == false)
                { vrstaStabla = "crnogoricno"; }
  
                return ("Otpadaju listovi: " + OtpadajuListovi +  "\n Vrsta stabla: " + vrstaStabla);

            }

            static void Main(string[] args)
            {


                Stablo stablo1 = new Stablo(true);
                Stablo stablo2 = new Stablo(false);

                Console.WriteLine(stablo1.ToString());
                Console.WriteLine(stablo2.ToString());
                Console.ReadKey();

            }
        }
    }
}
