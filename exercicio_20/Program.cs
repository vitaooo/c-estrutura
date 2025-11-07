pessoa lista = null;

void Insere(string n, string i, string w){
    pessoa no = new pessoa();
    no.nome = n;
    no.idade = i;
    no.whats = w;
    no.prox = lista;
    lista = no;
}

void Exclui(pessoa ant, pessoa atu){
    if(ant == null){
        lista = lista.prox;
    } else if (atu.prox == null){
        ant.prox = null;
    } else {
        ant.prox = atu.prox;
    }
}

void Exibe (pessoa atu){
    System.Console.WriteLine("Dados atuais");
    System.Console.WriteLine("Nome: " + atu.nome);
    System.Console.WriteLine("Idade: " + atu.idade);
    System.Console.WriteLine("Whats: " + atu.whats);
}

void Consulta ( string np, ref pessoa ant, ref pessoa atu){
    ant = null;
    atu = lista;
    while (atu != null && np != atu.nome){
        ant = atu;
        atu = atu.prox;
    }
}

void Alterar(pessoa atu){
    string choice = "0";
    while(choice != "4"){
        choice = Console.ReadLine();
        System.Console.WriteLine("O que deseja alterar ?");
        System.Console.WriteLine("1 - nome");
        System.Console.WriteLine("2 - idade");
        System.Console.WriteLine("3 - whats");
        System.Console.WriteLine("4 - sair");
        if(choice == "1"){
            System.Console.WriteLine("Digite o novo nome: ");
            string novoNome = Console.ReadLine();
            atu.nome = novoNome;
        } else if(choice == "2"){
            System.Console.WriteLine("Digite a idade: ");
            string novaIdade = Console.ReadLine();
            atu.idade = novaIdade;
        } else if(choice == "3"){
            System.Console.WriteLine("Digite o novo número: ");
            string novoNumero = Console.ReadLine();
            atu.whats = novoNumero;
        }
    }
    
}

void ExibeTodos(){
    pessoa aux = lista; // começa do início da lista
    if(aux == null){
        System.Console.WriteLine("Lista vazia.");
        return;
    }

    while(aux != null){
        Exibe(aux); //Reutiliza a função
        System.Console.WriteLine("---"); // separador
        aux = aux.prox; // pula para o próximo
    }

}

// Principal
pessoa anterior, atual;
anterior = atual = null;
string op = "0";
while(op != "5"){
    op = Console.ReadLine(); 
    System.Console.WriteLine("1 - Incluir");
    System.Console.WriteLine("2 - Alterar");
    System.Console.WriteLine("3 - Excluir");
    System.Console.WriteLine("4 - Exibir todos");
    System.Console.WriteLine("5 - Sair");
    if(op == "1"){
        System.Console.WriteLine("Digite o seu nome, idade e seu número de telefone: ");
        string n = Console.ReadLine();
        string i = Console.ReadLine();
        string w = Console.ReadLine();
        
        Insere(n, i, w);
    } else if(op == "2"){
        System.Console.WriteLine("Qual nome você quer alterar?");
        string nomeBusca = Console.ReadLine();
        Consulta(nomeBusca, ref anterior, ref atual);

        if(atual != null){
            Exibe(atual);
            Alterar(atual);
        }else {
            System.Console.WriteLine("Não encontrou!");
        }
    } else if(op == "3"){
        System.Console.WriteLine("Qual nome você quer excluir?");
        string nomeBusca = Console.ReadLine();
        Consulta(nomeBusca, ref anterior, ref atual);

        if(atual != null){
            Consulta(atual);
            Exibe(atual);
            Exclui(anterior, atual);
            System.Console.WriteLine("Exclusão concluída!");
        } else {
            System.Console.WriteLine("Não encontrado!");
        }
    } else if(op == "4"){
        ExibeTodos();
    }
}


// No fim programa 
class pessoa {
    public string nome = "";
    public string idade = "";
    public string whats = "";
    public pessoa prox = null;

}