
using FilaPilhaDez;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main()
    {
        Pilha pilha = new Pilha();
        Fila fila = new Fila();
       

    /*5)Cadastre 10 núms em uma fila dinâmica e +10 em uma pilha dinâmica,
    em seguida mostre os 3 relatórios: (Sorteio)
    a) os núms que estão nas duas estruturas
    b) os que estão na fila
    c) os que estão na pilha*/

        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            int aux = rnd.Next(1,51);
            fila.PushFila(new Numero(aux));
        }
        Console.WriteLine("Números fila");
        fila.PrintFila();
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            int aux = rnd.Next(1, 51);
            pilha.PushPilha(new Numero(aux));
        }
        Console.WriteLine($"Números pilha");
        pilha.PrintPilha();
        




    }
}