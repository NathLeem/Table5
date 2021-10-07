using System;

namespace Table5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int Result;
            int valeur;

            Console.WriteLine("entrez une valeur:");
            N = Convert.ToInt32(Console.ReadLine());

            MethodeDuProjet MesOutils = new MethodeDuProjet();
            MesOutils.Table5(valeur,N,out Result);

            Console.WriteLine($"Voici tout les multiples de 5 jusque 500: {Result}");
        }
    }
}
