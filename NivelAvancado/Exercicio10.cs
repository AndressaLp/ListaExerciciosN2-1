public partial class ListaEncadeada 
{
    public void Ordenar()
    {
        Cabeca = MergeSort(Cabeca);
    }

    private No? EncontrarMeio(No? cabeca)
    {
        if(cabeca == null) return cabeca;

        No? lento = cabeca;
        No? rapido = cabeca.Proximo;

        while(rapido != null && rapido.Proximo != null)
        {
            lento = lento!.Proximo;
            rapido = rapido.Proximo.Proximo;
        }
        return lento;
    }

    private No? Mesclar(No? l1, No? l2)
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        if(l1.Dado <= l2.Dado)
        {
            l1.Proximo = Mesclar(l1.Proximo, l2);
            return l1;
        }
        else
        {
            l2.Proximo = Mesclar(l1, l2.Proximo);
            return l2;
        }
    }

    public No? MergeSort(No? cabeca)
    {
        if(cabeca == null || cabeca.Proximo == null) return cabeca;

        No? meio = EncontrarMeio(cabeca);
        No? proximaParte = meio!.Proximo;
        meio.Proximo = null;

        No? esquerda = MergeSort(cabeca);
        No? direita = MergeSort(proximaParte);

        return Mesclar(esquerda, direita);
    }
}