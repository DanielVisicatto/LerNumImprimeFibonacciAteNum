int fbnt1 = 1, fbnt2 = 1, proxFbnt = 0;
Console.Write("Digite um número para trazer Fibonacci: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Inteiro por favor!");
}
else if (number == 1)
{
    Console.WriteLine("1");
}
else if (number == 2)
{
    Console.WriteLine("1, 1");
}
else
{
    Console.WriteLine("Você digitou {0}\n" +
        "Sequência Fibonacci até {0}...", number);

    
    Console.Write("{0}, {1}", fbnt1, fbnt2);// imprimindo os 2 primeiros valores...
    proxFbnt = fbnt1 + fbnt2;//calculando o proximo da sequencia...

    int cont = 3;
    //while(proxFbnt <= number)// percorrendo os fibonacci até o número...
    while (cont <= number)
    {
        //imprimindo o proximo fibonacci...
        //Console.Write(", {0}", proxFbnt);
        //andando pela sequencia e imprimindo proximo...
        TrocaValorEPegaProx();
        Console.Write(", {0}", proxFbnt);
        cont++;
    }
}
void TrocaValorEPegaProx()
{
    fbnt1 = fbnt2;
    fbnt2 = proxFbnt;
    proxFbnt = fbnt1 + fbnt2;
}
//Console.Write("Digite um número para trazer Fibonacci: ");
//if(!int.TryParse(Console.ReadLine(), out var number))
//{
//    Console.WriteLine("Inteiro por favor!");
//}
//else
//{
//    #region[comentado]
//    //int ant = 1, prox = 0, atual = 1;
//    //for (int i = 0; i < number; i++)
//    //{
//    //    atual = prox + ant;
//    //    ant = prox;
//    //    prox = atual;

//    //    Console.Write(" {0},", prox);
//    //}
//    #endregion


// com duas variáveis
//    int anterior = 1, proximo = 0;
//    for(int i = 0; i < number;i++)
//    {
//        Console.Write("{0}, ", proximo);
//        proximo += anterior;
//        anterior = proximo - anterior;
//    }
//}


//Testando possibilidade de 1 variável...
//int number = 1;
//Console.Write("{0}", number);
//for (; number <= 10; number ++)
//{
//    Console.Write(", {0} ", number);
//    number+= 1;
//}