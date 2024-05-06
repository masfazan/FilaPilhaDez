
namespace FilaPilhaDez
{

    internal class Numero
    {
        int numero;
        Numero nanterior;
        Numero proximo;

        public Numero(int numero)
        {
            this.numero = numero;
            this.nanterior = null;
        }

        public int getNumero() //retornar valor
        {
            return numero;
        }

        public int setNumero() //atribuir valor
        {
            return numero;
        }

        public override string? ToString()
        {
            return numero.ToString();
        }

        public Numero getNanterior() //retornar valor anterior
        {
            return nanterior;
        }

        public void setNanterior(Numero numero) //atribuir valor ao anterior
        {
            this.nanterior = numero;
        }

        public void setProx(Numero aux) //set do próximo
        {
            this.proximo = aux;
        }
        public Numero getProx()
        {
            return this.proximo;
        }

    }
}

