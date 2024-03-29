﻿
using CHAIN_OF_RESPONSABILITY.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manipulador pA = new PersonagemA();
            Manipulador pB = new PersonagemB();
            Manipulador pC = new PersonagemC();

            pA.defineSucessor(pB);
            pB.defineSucessor(pC);

            int[] requisicoes = { 5, 8, 15, 20, 18, 3, 27, 20 };

            foreach (int req in requisicoes)
            {
                pA.Convoca(req);
            }

            Console.ReadKey();
        }

    }
}