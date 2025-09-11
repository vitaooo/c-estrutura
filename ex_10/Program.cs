char[] pilhaPalavra = new char[20];
int posicao = 0;

void InsereFrase(char frase){
    pilhaPalavra[posicao] = frase;
    posicao = posicao + 1;
}

char Remove(){
    posicao = posicao - 1;
    return (pilhaPalavra[posicao]);
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

//char c = pilhaPalavra[i];
//int qtd = pilhaPalavra.Length;

InsereFrase(f);


while (pilhaPalavra[posicao] != ' '){
    InsereFrase(f);
    Remove();
    
}