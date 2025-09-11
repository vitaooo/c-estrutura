int[] pilha = new int[20];
int topo = 0;

void Insere(int valor){
    pilha[topo] = valor;
    topo = topo + 1;
}

int Remove(){
    topo = topo - 1;
    return (pilha[topo]);
}

bool EstaVazia(){
    if(topo == 0){
        return true;
    } else {
        return false;
    }
}

bool EstaCheia(){
    if (topo == 20){
        return true;
    } else {
        return false;
    }
}

//principal
int n;
System.Console.Write("Digite um numero: ");
n = Convert.ToInt32(Console.ReadLine());

while (n != 0){
    Insere(n%2);
    n = n / 2;
}

// int r;
while (!EstaVazia())
{
    //r = Remove();
    Console.Write(Remove());
}