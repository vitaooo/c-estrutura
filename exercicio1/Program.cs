
void crescente (int nI, int nF) {

    if (nI <= nF){
        System.Console.WriteLine(nI);
        crescente(nI + 1, nF);
    }
    System.Console.WriteLine("");
} 

void decrescente(int nI, int nF) {
    if (nI >= nF){
        System.Console.WriteLine(nI);
        decrescente(nI - 1, nF);
    }
}

void imparesI(int nI, int nF) {
    while (nI <= nF) {
        if (nI % 2 != 0) {
            Console.WriteLine("Número "+ nI+ "é ímpar");
        }
        nI += 1;
    }
}



int somatorio(int nI, int nF) {
    if (nI < nF) {
        return nI + somatorio(nI + 1, nF);
    } else {
        return nI;
    }
}



string op;
op = "0";
while (op != "3")
{
    Console.WriteLine("Menu Principal!");
    Console.WriteLine("1 - Função sem vetor");
    Console.WriteLine("2 - função com vetor");
    Console.WriteLine("3 - sair");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada");
    System.Console.WriteLine("");
    op = Console.ReadLine();
    Console.WriteLine("");

    if (op == "1")
    {
        int nI, nF;

        Console.WriteLine("Número incial: ");
        System.Console.WriteLine("");

        //nI = int.Parse(Console.ReadLine());
        nI = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Número final: ");
        System.Console.WriteLine("");

        //nF = int.Parse(Console.ReadLine());
        nF = Convert.ToInt32(Console.ReadLine());

        int soma = nI + nF;
        Console.WriteLine();
        Console.WriteLine("O resultado da função é " + soma);
        Console.WriteLine();

        System.Console.WriteLine("Menu Secundário");
        System.Console.WriteLine("1 - Ordem crescente");
        System.Console.WriteLine("2 - Ordem descrescente");
        System.Console.WriteLine("3 - Somente impares");
        System.Console.WriteLine("4 - Somatório");
        System.Console.WriteLine("Opção desejada: ");
        System.Console.WriteLine("");
        string op2 = Console.ReadLine();
        System.Console.WriteLine("");

        if (op2 == "1") {
            crescente(nI, nF);

        } else if (op2 == "2") {
            decrescente(nI, nF);

        } else if (op2 == "3") {
        
            imparesI(nI, nF);

        } else if(op2 == "4") {
            int s;
            s = somatorio(nI, nF);
            System.Console.WriteLine(s);
        }
    }

     else if (op == "2")
    {
        int[] vetor;
        vetor = new int[3];
        int i;

        vetorRec(i) {
            if(i < 3) {
                for(i = 0; i< 3; i++) {
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                    return vetorRec(i + 1);
                }
            }
        }



        /*
        int i;

        for(i = 0; i < 3; i++){
            System.Console.WriteLine("digita ai");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(i = 0; i < 3; i++){
            System.Console.WriteLine(vetor[i]);
        }*/
        
      /*Console.WriteLine("Menu Secundário");
        Console.WriteLine("1 - Inteiros em ordem crescente");
        Console.WriteLine("2 - Inteiros em ordem decrescente");
        Console.WriteLine("3 - Inteiros ímpares(crescente)");
        Console.WriteLine("4 - Somatório dos inteiros"); */

    }
}