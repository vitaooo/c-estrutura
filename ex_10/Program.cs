char[] pilhaPalavra = new char[20];
int posicao = 0;

void InsereFrase(char caractere){
    if (posicao < pilhaPalavra.Lenght)
    {
        pilhaPalavra[posicao] = caractere;
        posicao++;
    }
}

char Remove()
{
    if (posicao > 0)
    {
        posica--;
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

int qtd = pilhaPalavra.Length;

int i = 0;
while (pilhaPalavra.Lenght <= qtd){
    while(pilhaPalavra[i] != ' '){
        InsereFrase(pilhaPalavra[i]);
        i++;
    }
    while(pilhaPalavra[i] != ' '){
        System.Console.WriteLine(Remove());
    }
    
}