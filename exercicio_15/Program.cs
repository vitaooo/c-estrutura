// Lista Linear Sequencial - Fila

int[] fila = new int[20];
int inicio = 0, fim = 0;

void Insere(int valor)
{
    fila[fim] = valor;
    fim += 1;
}

int Remove() {
    inicio = inicio + 1;
    return (fila[inicio - 1]);
}

bool EstaVazia()
{
    if (inicio == fim)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool EstaCheia()
{
    if (fim == 20)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int PrimeiroFila()
{
    return fila[inicio];
}

string op = "";

while (op != "0")
{
    System.Console.WriteLine(" 1 - Adicionar na fila");
    System.Console.WriteLine(" 2 - Qtde de aviões");
    System.Console.WriteLine(" 3 - Autoriza a delocagem");
    System.Console.WriteLine(" 4 - Lista de Aviões");
    System.Console.WriteLine(" 5 - Primeiro da fila");
    System.Console.WriteLine("");
    System.Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();

    if (op == "1")
    {
        System.Console.WriteLine("Digite o n° do avião:");
        int n = Convert.ToInt32(Console.ReadLine());
        if (EstaCheia() == false)
        {
            Insere(n);
        }
        else
        {
            System.Console.Write("Fila cheia!");
        }
    }
    else if (op == "3")
    {
        if (EstaVazia() == false)
        {
            int n = Remove();
            System.Console.WriteLine($"Avião {n} decolou!");
        }
        else
        {
            System.Console.WriteLine("Fila vazia!");
        }
    }
    else if (op == "5")
    {
        System.Console.WriteLine($"Primeiro da fila é {PrimeiroFila()}");
    }
}