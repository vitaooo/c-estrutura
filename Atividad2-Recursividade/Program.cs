using System;
namespace Atividad2_Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}


potencia(x, y) {
    if(x <= y) {
        x ** potencia(x, y - 1);
    return x;
    }
}

string op;
op = "0";
while (op != "7"){
    Console.WriteLine("Menu Dos exercícios");
    Console.WriteLine("1 - Ex 1");
    Console.WriteLine("2 - Ex 2");
    Console.WriteLine("3 - Ex 3");
    Console.WriteLine("4 - Ex 4");
    Console.WriteLine("5 - Ex 5");
    Console.WriteLine("6 - Ex 6");
    Console.WriteLine("7 - sair");

    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada");
    System.Console.WriteLine("");
    op = Console.ReadLine();

    if (op == "1")
    {  

        int x;
        int y;
        Console.WriteLine("Número da base: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Número ddo expoente: ");
        y = Convert.ToInt32(Console.ReadLine());


        potencia(x, y);
    }
}