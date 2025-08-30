int potencia(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    else
    {
        System.Console.WriteLine("");
        return x * potencia(x, y - 1);
    }
}

static void cubos(int n)
{
    cubosRec(1, n);
}
static void cubosRec(int i, int n)
{
    if (i > n)
        return;
    Console.WriteLine(i * i * i);
    cubosRec(i + 1, n);
}

int mdc(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    else if (x < y)
    {
        return mdc(y, x);
    }
    else
    {
        return mdc(x - y, y);
    }
}

int fibRecursiva(int n)
{
    if (n == 0 || n == 1)
        return n;
    return fibRecursiva(n - 1) + fibRecursiva(n - 2);

}

int fibIterativo(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    int a = 0, b = 1, resultado = 0;
    for (int i = 2; i <= n; i++)
    {
        resultado = a + b;
        a = b;
        b = resultado;
    }
    return resultado;
}

string decParaBi(int n)
{
    if (n == 0)
        return "0";
    if (n == 1)
        return "1";

    return decParaBi(n / 2) + (n % 2).ToString();
}

string op;
op = "0";
while (op != "6")
{
    Console.WriteLine("Menu Dos exercícios");
    Console.WriteLine("1 - Ex 2");
    Console.WriteLine("2 - Ex 3");
    Console.WriteLine("3 - Ex 4");
    Console.WriteLine("4 - Ex 5");
    Console.WriteLine("5 - Ex 6");
    Console.WriteLine("6 - sair");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada");
    op = Console.ReadLine();

    if (op == "1")
    {
        int x;
        int y;
        Console.WriteLine("Número da base: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Número do expoente: ");
        y = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(potencia(x, y));
    }
    else if (op == "2")
    {
        int n;
        Console.WriteLine("Número de 'n' ");
        n = Convert.ToInt32(Console.ReadLine());
        cubos(n);
    }
    else if (op == "3")
    {
        int x;
        int y;
        Console.WriteLine("Número de 'x' e 'y' ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(mdc(x, y));
    }
    else if (op == "4")
    {
        int n;
        Console.WriteLine("Tamanho da sequência de Fibonacci");
        n = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Fibonacci recursivo de " + n + ":" + fibRecursiva(n));
        System.Console.WriteLine("Fibonacci Iterativo de " + n + ":" + fibIterativo(n));
    }
    else if (op == "5")
    {
        int n;
        System.Console.WriteLine("Escolha um número para transformar em binário: ");
        n = Convert.ToInt32(Console.ReadLine());
        string binario = decParaBi(n);
        System.Console.WriteLine("O número "+ n+ " em binário é: "+ binario);
    }
}