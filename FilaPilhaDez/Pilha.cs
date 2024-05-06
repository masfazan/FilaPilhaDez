
namespace FilaPilhaDez
{
    internal class Pilha
    {
       
            Numero topo;


            public Pilha()
            {
                topo = null;

            } //pilha

            Boolean PilhaVazia()
            {
                if (topo == null) //quando o topo for null está vazia
                    return true;
                else
                    return false;
            }

            public void PushPilha(Numero aux)
            {
                if (PilhaVazia() == true)
                {
                    topo = aux;
                }

                else
                {
                    aux.setNanterior(topo);//set porque atribui valor
                    topo = aux;
                }
            }


            public void PrintPilha()
            {
                Numero aux = topo;

                if (PilhaVazia())
                {
                    Console.WriteLine("Pilha vazia");

                }
                else
                {
                    do
                    {
                        Console.WriteLine(aux.ToString());
                        aux = aux.getNanterior();
                    } while (aux != null);
                    Console.ReadKey();
                }
            }

        
    }
}
