// Lista Linear Sequencial - Fila

int[] fila = new int[3];
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
    if (fim == 3)
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

while(!EstaCheia()){
    Insere(Convert.ToInt32(Console.ReadLine()));
}

int maior = PrimeiroFila();
int menor = PrimeiroFila();
int soma = 0;
int cont = 0;

while(!EstaVazia()) {
    int x = Remove();
    if(x > maior) {
        maior = x;
    }
    if (x < menor){
        menor = x;
    }
    soma = soma + x;
    cont++;
}
System.Console.WriteLine(maior);
System.Console.WriteLine(menor);
System.Console.WriteLine(media / cont);
