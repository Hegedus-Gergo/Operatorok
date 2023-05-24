using System;
using LINQ;
using System.Collection.Generic;

namespace Operatorok
{
    internal class Program
    {
        StreamReader sr = new StreamReader("kifejezesek.txt");
        List<string> elemek = sr.Select(x => x.Split("\n")).ToList();

        static void VisszaTero() {
            List<string> OPERATOR = new List<string>("+", "-", "*", "/","div","mod");
            if (OPERATOR not in elemek){
                Console.WriteLine("Hiba");
            }
        }
        static void Main(string[] args)
        {
            //2
            int kifejezesekSzama = elemek.Count(x=>x);
            //3
            int maradekosOsztasSzama = elemek.Where(x => x[1]=="mod").Count();
            //4
            bool mindket10elOszthato = elemek.Where(x => x[0][^1] == 0 && x[2][^1] == 0);
            //5
            int pluszok = elemek.Where(x => x[1]=="+");
            int minuszok = elemek.Where(x => x[1] == "-");
            int szorzas = elemek.Where(x => x[1] == "*");
            int simaosztas = elemek.Where(x => x[1] == "/");
            int egeszosztas = elemek.Where(x => x[1] == "div");
            int modok = elemek.Where(x => x[1] == "mod");
            //7
            while(true){
                Console.WriteLine("Kérek egy kifejezést: ");
                string input = Console.ReadLine();
                if (input == "vége")
                {
                    break;
                }
                else { 
                VisszaTero()
                }
            }
            //8
            StreamWriter sw = new StreamWriter("eredmenyek.txt");
            
        }
    }
}
