using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_3_9a
{
    internal class graf
    {
        public string[] Cvor;
        public List<grana>[] grane;
        public graf()
        {
            Console.WriteLine("Unesite broj cvorova: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Cvor = new string[n];
            grane = new List<grana>[n];
            for (int i =   0; i < n; i++)
            {
                grane[i] = new List<grana>();
            }
        }
    }
}
