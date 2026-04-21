public class No
{
    public int Dado { get; set; }
    public No? Proximo { get; set; }

    public No(int dado)
    {
        Dado = dado;
        Proximo = null;
    }
}

public partial class ListaEncadeada
{
    public No? Cabeca { get; set; }

    public ListaEncadeada()
    {
        Cabeca = null;
    }

    public void InserirFinal(int dado)
    {
        No NovoNo = new No(dado);

        if(Cabeca == null)
        {
            Cabeca = NovoNo;
            return;
        }
        else
        {
            No atual = Cabeca;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            atual.Proximo = NovoNo;
        }
    }

    public void Imprimir()
    {
        No? atual = Cabeca;

        while(atual != null)
        {
            Console.Write($"{atual.Dado} → ");
            atual = atual.Proximo;
        }

        Console.Write("None");
    }
}