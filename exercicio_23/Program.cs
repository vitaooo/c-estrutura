// Variáveis de controle da Fila
No inicio = null;
No fim = null;

void Inserir(int num)
{
    // 1. Cria o novo nó
    No novo = new No();
    novo.numero = num;
    // novo.prox já é null por definição da classe

    // 2. Verifica se a fila está vazia
    if (inicio == null)
    {
        // Se está vazia, o novo nó é o primeiro e o último
        inicio = novo;
        fim = novo;
    }
    else
    {
        // 3. Se não está vazia, o 'fim' atual aponta para o 'novo'
        fim.prox = novo;
        
        // 4. O 'novo' nó agora é o novo 'fim' da fila
        fim = novo;
    }
    
    Console.WriteLine($"[+] Número {num} inserido no FIM da fila.");
}

void Remover()
{
    // 1. Verifica se a fila está vazia
    if (inicio == null)
    {
        Console.WriteLine("Fila vazia. Impossível remover.");
        return; // Sai da função
    }

    // 2. Guarda o número que será removido (apenas para exibir)
    int valorRemovido = inicio.numero;

    // 3. "Avança" o ponteiro 'inicio' para o próximo nó
    inicio = inicio.prox;

    // 4. CASO ESPECIAL: Se a fila ficou vazia após a remoção...
    if (inicio == null)
    {
        // ...devemos atualizar o 'fim' para null também.
        fim = null;
    }

    Console.WriteLine($"[-] Número {valorRemovido} removido do INÍCIO da fila.");
}


void ExibirTodos()
{
    if (inicio == null)
    {
        Console.WriteLine("Fila vazia.");
        return;
    }

    Console.WriteLine("\n--- Conteúdo da Fila (Início -> Fim) ---");
    No aux = inicio; // Cria um ponteiro auxiliar começando no 'inicio'
    
    while (aux != null) // Enquanto não chegar ao fim da lista
    {
        Console.Write($"[{aux.numero}] -> "); // Exibe o número
        aux = aux.prox; // Pula para o próximo
    }
    
    Console.WriteLine("NULL (Fim da Fila)");
    Console.WriteLine("------------------------------------------");
}


// --- PROGRAMA PRINCIPAL ---

string op = "0";
while (op != "4")
{
    Console.WriteLine("\n==== Menu da Fila (FIFO) ====");
    Console.WriteLine("1 - Inserir (no Fim)");
    Console.WriteLine("2 - Remover (do Início)");
    Console.WriteLine("3 - Exibir Fila");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    op = Console.ReadLine();

    switch (op)
    {
        case "1":
            Console.Write("Digite o número inteiro para inserir: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Inserir(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
            }
            break;
        case "2":
            Remover();
            break;
        case "3":
            ExibirTodos();
            break;
        case "4":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

// Classe que define o nó da lista
class No
{
    public int numero;      // O dado (um número inteiro)
    public No prox = null; // O ponteiro para o próximo
}

