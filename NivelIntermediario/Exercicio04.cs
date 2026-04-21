public partial class ListaEncadeada
{
    public void Inverter()
    {
        No? anterior = null;
        No? atual = Cabeca;
        No? proximo = null;

        while(atual != null)
        {
            proximo = atual.Proximo;
            atual.Proximo = anterior;
            anterior = atual;
            atual = proximo;
        }
        Cabeca = anterior;
    }
}