using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Kérem a téglalap a oldalát: ");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            Console.WriteLine("Kérem a téglalap a oldalát: ");
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            int ter = a1 * b1;
            int ker = 2*(a1+b1);
            Console.WriteLine($"A téglalp területe: {ter }");
            Console.WriteLine($"A téglalap kerülete: {ker}");
            
            Console.WriteLine("Kérem a négyzet a oldalát: ");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            int ter =  a1*a1 ;
            int ker = 4 * a1; 
            Console.WriteLine($"A négyzet területe: {ter}");
            Console.WriteLine($"A négyzet kerülete: {ker}");

            
            Console.WriteLine("Kérem a hármszög a oldalát: ");
            string aoldal = Console.ReadLine();
            int a = int.Parse(aoldal);
            Console.WriteLine("Kérem a hármszög b oldalát: ");
            string boldal = Console.ReadLine();
            int b = int.Parse(boldal);
            Console.WriteLine("Kérem a hármszög c oldalát: ");
            string coldal = Console.ReadLine();
            int c = int.Parse(coldal);


            if (a + b >= c && a + c >= b && c + b >= a)
            {
                Console.WriteLine("A hármoszög lehetséges");
            }
            else 
            {
                Console.WriteLine("A hármoszög nem lehetséges");
            }
            
            Console.WriteLine("Kérem a hármszög a oldalát: ");
            string aoldal = Console.ReadLine();
            int a = int.Parse(aoldal);
            Console.WriteLine("Kérem a hármszög b oldalát: ");
            string boldal = Console.ReadLine();
            int b = int.Parse(boldal);
            int pit = (a * a) + (b * b);

            double coldal = Math.Sqrt(pit);
            double ker = coldal + b + a;
            double ter = (double)(a * b) / 2;
            Console.WriteLine(Math.Sqrt(pit));
            Console.WriteLine($"A háromszög kerülete: {ker}");
            Console.WriteLine($"A háromszög területe: {ter}");
            
            int[] a = { 1, 2, 3, 4, 5, 66, 77, 4, 54, 22, 53, 98, -1 };
            int min = a[0];
            foreach (int i in a) 
            {
                if (min > i) 
                {
                    min = i;
                    
                } 
                
            }
            Console.WriteLine(min);


            int max = a[0];

            for (int i = 0; i < a.Length; i++) 
            {
                if (max < a[i]) 
                {
                    max = a[i];
                }

            }
            Console.WriteLine(max);

            int sum = 0;
            foreach (int i in a) 
            {
                sum += i;
            }
            Console.WriteLine(sum);
            
            List<int> szamok = new List<int>{ 1, 2, 3, 4, 5, 66, 77, 4, 54, 22, 53, 98, -1 };
            List<int> paros = new List<int> { };
            foreach (int i in szamok) 
            {
                if (i % 2==0) 
                {
                    paros.Add(i);
                }
            }
            Console.WriteLine("2-vel osztható számok "+string.Join(",",paros));
            
            Console.WriteLine("Adj meg egy számot 1-7 ig :");
                int nap = int.Parse(Console.ReadLine());

            switch (nap)
            {
                case 1:
                    Console.WriteLine("hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;
           }
             */

                Console.WriteLine("Add meg a heti aktivitásodat (pl. FFFGGGUUUFFFGGKKK):");
                string activities = Console.ReadLine().ToUpper();

                int totalDistance = CalculateDistance(activities);

                bool hasU = activities.Contains("U");
                bool hasG = activities.Contains("G");
                bool hasF = activities.Contains("F");
                bool hasK = activities.Contains("K");

                int bonus = 0;
                if (hasU && hasG && hasF && hasK)
                {
                    bonus = 10;
                    Console.WriteLine("Bravó! Jutalma még 10 km.");
                }
                else
                {
                    Console.WriteLine("Nem jár jutalom.");
                }

                int totalWithBonus = totalDistance + bonus;

                Console.WriteLine($"Összesen gyűjtött kilométer: {totalWithBonus} km");

                if (totalWithBonus >= 40)
                {
                    Console.WriteLine("Gratulálok, kihívás teljesítve!");
                }
                else
                {
                    Console.WriteLine("Legközelebb sikerül!");
                }
            }

            static int CalculateDistance(string input)
            {
                int sum = 0;
                foreach (char c in input)
                {
                    switch (c)
                    {
                        case 'U': sum += 1; break;
                        case 'G': sum += 1; break;
                        case 'F': sum += 2; break;
                        case 'K': sum += 10; break;
                        default:
                            Console.WriteLine($"Ismeretlen karakter: {c} (kimarad a számításból)");
                            break;
                    }
                }
                return sum;
            }
        }



    }
