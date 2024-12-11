using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {

        List<string> partecipanti = new List<string>();
        partecipanti.Add("a");
        partecipanti.Add("b");
        partecipanti.Add("c");
        partecipanti.Add("d");
        partecipanti.Add("e");
        partecipanti.Add("f");
        partecipanti.Add("g");
        partecipanti.Add("h");
        partecipanti.Add("i");
        partecipanti.Add("j");

        Random turno = new Random();

        while (partecipanti.Count > 0)
        {
            /*
            string partecipante = partecipanti[turno.Next(partecipanti.Count)];
            Thread partecipante1 = new Thread();*/
            int indice = turno.Next(partecipanti.Count);
            string partecipante = partecipanti[indice];
            Console.WriteLine($"e' il turno di {partecipante}");
            Thread.Sleep(1000);
            Console.WriteLine($"{partecipante} ha finito");
            partecipanti.RemoveAt(indice);
        }
        Console.WriteLine("Finito");

    }

}
