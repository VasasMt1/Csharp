using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*
            Console.WriteLine("Tégalalap kerület és terület ");
            Console.Write("Kérem az a oldalt:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a b oldalát:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("A kerület:" + 2 * a + 2 * b);
            double ker = 2 * a + 2 * b;
            double ter = a * b;
            Console.WriteLine($"A Terület {ter}");

            if (ker == ter)
            {
                Console.WriteLine("Egyenlő");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerület nagyobb");
            }
            else 
            {
                Console.WriteLine("A terület nagyobb");
            }



            Random rnd = new Random();
            Console.WriteLine("Tanár diák kocka játék");
            int tanar = rnd.Next(1, 6);
            Console.WriteLine($"Tanár dobott:{tanar}");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"Diák dobott:{diak}");
            if (tanar == diak)
            {
                Console.WriteLine("Egyenlő");
            }
            else if (tanar > diak) 
            { 
                Console.WriteLine("Tanár nagyobbat dobott");
            }
            else
            {
                Console.WriteLine("Diák nyert");
            }


            for (int i = 1; i <= 5; i++) {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("Hajrá zteE!!!");
            }
            for (int i = 1; i <= 3; i++) {
                Console.WriteLine("Fujpest");
            
            Console.WriteLine("Kérek számokat");
            Console.Write("Kérek egy számot");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérek még egy számot");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a * b);
            Console.WriteLine(2*b * a);
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 1; i <= 2; i++)
            {
                for (int i2 = 1; i2 <= 3; i2++)
                {
                    Console.WriteLine("Fujpest");
                    
                }
                Console.WriteLine("Hajrá zteE!!!");

           

            }
            string[] nevek = { "Anna", "Béla", "Csaba" };
            for (int i = 0; i < nevek.Length; i++) 
            {
                Console.WriteLine(nevek[i]);
            }
                        string[] nevek = { "Anna", "Béla", "Csaba" };
            foreach (string i in nevek) 
            {
                Console.WriteLine(i);
            }
            double[] nevek2 = { 1, 2, 3, 4 };
            foreach (double i in nevek2) 
            {
                Console.WriteLine(i);
            }

            int i = 0;
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }


            int g = 0;
            do 
            {
                Console.WriteLine(g);
                g++;
            }while (g < 5);
             
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            int min = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine("A legkisebb száma a listában:"+min);
            
            int max = szamok[0];
            for (int i = 1; i < szamok.Length; i++) 
            {
                if (szamok[i] > max)
                {
                max = szamok[i];
                }
            }
            Console.WriteLine("A legnagyob szám a listában: "+max);

            int max2 = szamok[0];
            

            foreach (int i in szamok)
            {
                if (i > max2) 
                {
                    max2 = i;  
                }
            }
            Console.WriteLine("A legnagyobb szám megint: "+max2);
            
            int min2 = szamok[0];
            int i2 = 1;
            while (i2 < szamok.Length) 
            {
                if (szamok[i2] < min2) 
                {
                    min2 = szamok[i2];
                }
                i2++;
            }
            Console.WriteLine("A legkisebb szám : "+min2);


            int max3 = szamok[0];
            int i3 = 1;
            do
            {
                if (szamok[i3] > max3)
                {
                    max3 = szamok[i3];
                }
                i3++;
            }while (i3 < szamok.Length);
            Console.WriteLine("A legnagyobb szm:"+max3);


            int min4 = szamok.Min();
            Console.WriteLine($"A legkisseb szm: {min}.");

            int max5 = szamok.Max();
            Console.WriteLine($"A legnagyob szám: {max}");

            int max7 = szamok[0];
            for (int i = 1; i < szamok.Length; i++) 
            {
                if (szamok[i] > max7)
                {
                    max7 = szamok[i];

                }
            }
            Console.WriteLine("A legnagyobb szám"+max7);


            int max8 = szamok[0];
            foreach (int szam in szamok) 
            {
                if (szam > max8) 
                {
                    max8 = szam;
                }

            }
            Console.WriteLine($"A legnagyobb szám {max8}");
            int max10 = szamok[0];
            int i4 = 1;
            while (i4 < szamok.Length)
            {
                if (szamok[i4] > max10)
                {
                    max10 = szamok[i4];
                }
                i4++;
            }
            Console.WriteLine("A legnagyobb szám : " + max10);

            int max11 = szamok[0];
            int i11 =1;
            do 
            {
                if (szamok[i11] > max11)
                    
                { 
                    max11 = szamok[i11];
                }
                i11++;


            }while (i11 < szamok.Length);
            Console.WriteLine($"A legnagyobb szám: {max11}");



            int max15 = szamok.Max();
            Console.WriteLine($"A legnagyob szám: {max15}");
            
            List<int> szamok = new List<int> { 4,8,15,16,23,42};
            int keresett = 16;
            bool megtalalva = false;
            for (int i = 0; i < szamok.Count; i++)
                if(szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtatlálva a(z) {i} indexen");
                    megtalalva=true;
                    break;
                }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában"); 
            }
            
            List<int> list = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 15;
            bool megtalalva=false;
            int index = 0;
            foreach (int i in list)
            {
                if (i == keresett) 
                {
                    Console.WriteLine($"A kresett szám ({keresett}) megtatlálva a(z) {index} indexen");
                    megtalalva = true;
                    break;
                }
                index++;

            }
            if (!megtalalva) { 
            Console.WriteLine($"A {keresett} szám nincs a listában");
                
            }
            
            List<int> list = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 15;
            bool megtalalva = false;
            int i = 0;
            while(i <list.Count )
            {
                if (list[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i} indexen");
                    megtalalva = true;
                    break;
                }
                i++;

 

            }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }
            
            List<int> list = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int i = 0;

            if (list.Count > 0) 
            {
                do
                {
                    if (list[1] == keresett)
                    {
                        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i}");
                        megtalalva = true;
                        break;
                    }
                    i++;
                }while (i < list.Count);

            }
            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában");
            }
            

            List<int> list = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            if (list.Contains(keresett))
            {
                Console.WriteLine($"A keresett szám ({keresett}) megtalálva a listában.");
            }
            else 
            {
                Console.WriteLine($"A ({keresett}) szám nincs benne a listában");
            }
            
            List<int> list = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            int index = list.IndexOf(keresett);
            if (index != -1)
            {
                Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {index} indexen");

            }
            else 
            {
                Console.WriteLine($"{keresett} szám nincs a listában ");
            }
            
            List<int>szamok = new List<int> {1,2,3,4,5,6,7,8 };
            List<int> parosszamok = new List<int> ();
            foreach (int i in szamok)
            {
                if (i % 2 == 0)
                {
                    parosszamok.Add(i);
                }
            }
            Console.WriteLine("2-vel osztható számok:"+ string.Join(",",parosszamok));


            */
            Console.WriteLine("Adj meg  egy számot (1-7):");
                int nap = int.Parse(Console.ReadLine());
            switch (nap)
            {
                case 1: 
                    Console.WriteLine("Hétfő");
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
        }




    }
    }



       
