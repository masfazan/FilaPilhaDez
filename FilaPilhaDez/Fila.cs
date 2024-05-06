namespace FilaPilhaDez
{
    internal class Fila
    {
        Numero head;
        Numero tail;
        public Fila()
        {
            this.head = null;
            this.tail = null;

        } //fila

        Boolean FilaVazia()
        {
            if (head == null && head == null)
                return true;
            else
                return false;
        }

        public void PushFila(Numero aux)
        {
            if (FilaVazia() == true)
            {
                head = tail = aux;
            }

            else
            {
                tail.setProx(aux);//set porque atribui valor
                tail = aux;
            }
        }



        public void PrintFila()
        {
            Numero aux = head;

            if (FilaVazia())
            {
                Console.WriteLine("Fila vazia");

            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getProx();
                } while (aux != null);
                Console.ReadKey();
            }
        }
    }
}

