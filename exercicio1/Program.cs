void crescenteI(int nI, int nF) {
    System.Console.WriteLine("");
    System.Console.WriteLine("----");
    while (nI <= nF) {
        System.Console.WriteLine(nI);
        nI += 1;
    }
    System.Console.WriteLine("----");
    System.Console.WriteLine("");
}

void descrescente



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
    System.Console.WriteLine("");
    op = Console.ReadLine();
    Console.WriteLine("");

    if (op == "1")
    {
        int nI, nF;

        Console.WriteLine("Número incial: ");
        System.Console.WriteLine("");

        //nI = int.Parse(Console.ReadLine());
        nI = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Número final: ");
        System.Console.WriteLine("");

        //nF = int.Parse(Console.ReadLine());
        nF = Convert.ToInt32(Console.ReadLine());

        int soma = nI + nF;
        Console.WriteLine();
        Console.WriteLine("O resultado da função é " + soma);
        Console.WriteLine();

        System.Console.WriteLine("Menu Secundário");
        System.Console.WriteLine("1 - Ordem crescente");
        System.Console.WriteLine("2 - Ordem descrescente");
        System.Console.WriteLine("3 - Somente impares");
        System.Console.WriteLine("4 - Somatório");
        System.Console.WriteLine("Opção desejada: ");
        System.Console.WriteLine("");
        string op2 = Console.ReadLine();

        if (op2 == "1") {
            crescenteI(nI, nF);
        }
    }

     else if (op == "2")
    {
      /*Console.WriteLine("Menu Secundário");
        Console.WriteLine("1 - Inteiros em ordem crescente");
        Console.WriteLine("2 - Inteiros em ordem decrescente");
        Console.WriteLine("3 - Inteiros ímpares(crescente)");
        Console.WriteLine("4 - Somatório dos inteiros"); */

    }
}