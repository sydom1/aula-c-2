using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("5 - Projeto Caracteres e textos");

        char letra = 'A';
        Console.WriteLine(letra);

        letra = (char)(66);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string cursos = @"Cursos disponíveis: 
- Go
- C#
- Pyton
- Java"; // o @ serve para quebrar a linha
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }


}
