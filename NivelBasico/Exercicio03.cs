public partial class ListaEncadeada 
{
    public int Contar()
    {
        int contador = 0;
        No? atual = Cabeca;

        while(atual != null)
        {
            contador++;
            atual = atual.Proximo;
        }

        return contador;
    }

    public int ContarRec(No? no)
    {
        if(no == null) return 0;
        return 1 + ContarRec(no.Proximo);
    }
}