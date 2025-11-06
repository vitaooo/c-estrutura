pessoa lista = null;

void Insere(string n, string i, string w){
    pessoa no = new pessoa();
    no.nome = n;
    no.idade = i;
    no.whats = w;
    no.prox = lista;
    lista = no;
}

pessoa Remove(){
    pessoa no = lista;
    if(lista != null){
        lista = lista.prox;
    }
    return no;
}

void Exibe (pessoa atu){
    System.Console.WriteLine("Dados atuais");
    System.Console.WriteLine("Nome: " + atu.nome);
    System.Console.WriteLine("Idade: "+ atu.idade);
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

// Principal
pessoa anterior, atual;
anterior = atual = null;
string op = Console.ReadLine(); 
while(op != "4"){

    System.Console.WriteLine("1 - Incluir");
    System.Console.WriteLine("2 - Alterar");
    System.Console.WriteLine("3 - Excluir");
    System.Console.WriteLine("4 - sair");
    if(op == "1"){
        System.Console.WriteLine("Digite o seu nome, idade e seu número de telefone: ");
        string n = Console.ReadLine();
        string i = Console.ReadLine();
        string w = Console.ReadLine();
        
        Insere(n, i, w);
    } else if(op == "2"){
        Consulta(nomep, ref anterior, ref atual);
        if(atual != null){
            Exibe(atual);
        }else {
            System.Console.WriteLine("Não encontrou!");
        }
    } else if(op == "3"){
        if(atual != null){
            Exibe(atual);
            Remove(atual);
        } else {
            System.Console.WriteLine("Não encontrado!");
        }
    } else if(op == "4"){
        Exibe();
    }
}


// No fim programa 
class pessoa {
    public string nome = "";
    public string idade = "";
    public string whats = "";
    public pessoa prox = null;

}