string op;
op = "0";
while (op != "3")
{
    Console.WriteLine("Menu Principal!");
    Console.WriteLine("1 - Função sem vetor");
    Console.WriteLine("2 - função com vetor");
    Console.WriteLine("3 - sair");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada");
    op = Console.ReadLine();
    Console.WriteLine("");

    if (op == "1")
    {
        int nI, nF;

        Console.WriteLine("Número incial: ");

        //nI = int.Parse(Console.ReadLine());
        nI = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Número final: ");

        //nF = int.Parse(Console.ReadLine());
        nF = Convert.ToInt32(Console.ReadLine());

        int soma = nI + nF;
        Console.WriteLine();
        Console.WriteLine("O resultado da função é " + soma);
        Console.WriteLine();
    }

    else if (op == "2")
    {
        Console.WriteLine("Menu Secundário");
        Console.WriteLine("1 - Inteiros em ordem crescente");
        Console.WriteLine("2 - Inteiros em ordem decrescente");
        Console.WriteLine("3 - Inteiros ímpares(crescente)");
        Console.WriteLine("4 - Somatório dos inteiros");


    }
}