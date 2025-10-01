using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024okt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> uveg = new List<int> { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };

            Console.WriteLine(uveg);

            Console.WriteLine("Marinéni lekvárja :");
            string a = Console.ReadLine();
            int l = int.Parse(a);
            int sum = uveg.Sum();
            if (sum > l || sum==l )
            {
                Console.WriteLine("Belefog férni");
            }
            else 
            {
                Console.WriteLine("Nem fog bele férni");
            }

            if (l > 0 && l < 200)
            {
                Console.WriteLine("Marinéninek ennyi lekvárja van : " + a);
            }
            else
            {
                Console.WriteLine("Ez kevés vagy sok lesz");
            }
            
            
            int max = uveg.Max();
            int b = 1;
            foreach (int i in uveg)
            {
                if (i == max)
                {
                    Console.WriteLine($"A legnagyobb üveg: {max} dl és a {b}.a sorban");
                }
                b++;

            }

            


                
        }
    }
}
