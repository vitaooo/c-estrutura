char[] pilhaPalavra = new char[20];
int posicao = 0;

void InsereFrase(char caractere){
    if (posicao < pilhaPalavra.Length)
    {
        pilhaPalavra[posicao] = caractere;
        posicao++;
    }
}

char Remove()
{
    if (posicao > 0)
    {
        posicao--;
        return pilhaPalavra[posicao];
    }
    return '\0';
}

bool EstaVazia(){
    if(posicao == 0){
        return true;
    } else {
        return false;
    }
}

bool EstaCheia(){
    if (posicao == 20){
        return true;
    } else {
        return false;
    }
}

//principal
string f;
Console.Write("Digite uma frase: ");
f = Console.ReadLine();

int qtd = f.Length;

int i = 0;

while (i < qtd){
    while(i < qtd && f[i] != ' '){
        InsereFrase(f[i]);
        i++;
    }

    while(!EstaVazia()){
        char r = Remove();
        System.Console.Write(r); 
    }
    System.Console.Write(' ');
    i++;
} 