int number;
ProcessaDados();

void ProcessaDados()
{
    Console.Write("Digite um número para trazer Fibonacci: ");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Inteiro por favor!");
    }
    else
    {
        GerarFibonacci(number);
        ImprimirSequencia();
    }
}
int GerarFibonacci(int n)
{
    //Base 0 e 1 imutavel.
    if (n <= 1)
    {
        return n;
    }
    //Senao retorna a soma dos dois numeros que vem antes do que foi digitado digitado n-1 e n-2
    else
    {
        return GerarFibonacci(n - 1) + GerarFibonacci(n - 2);
    }
}
void ImprimirSequencia()
{
    //um for comum onde o incremento i será a base da chamada recursiva GerarFibonacci(i) 
    for (int i = 0; i < number; i++)
    {
        Console.Write("{0}, ",GerarFibonacci(i));
    }
}