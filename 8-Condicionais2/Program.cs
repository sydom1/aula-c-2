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

        // pode ser usado as variaveis tbm para deixar o codigo mais limpo.
        //bool acompanhdo = quantidadePessoas > 1;
        //bool grupo = true;

        // pode usar o || ou tbm o &&
        if (idadeJoao >= 18 || quantidadePessoas > 1)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }


}