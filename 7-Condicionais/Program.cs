using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("7 - Projeto Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhda. Então pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }


}
