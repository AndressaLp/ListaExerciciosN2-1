public partial class ListaEncadeada
{
    public bool ExisteRec(No? no, int valor)
    {
        // Caso base, sem valor na lista
        if(no == null) return false;
        // Caso base, valor encontrado
        if(no.Dado == valor) return true;
        // Chamada recursiva, procura no próximo nó
        return ExisteRec(no.Proximo, valor);
    }

    public int PosicaoRec(No? no, int valor, int pos = 0)
    {
        // Caso base, não achou o valor
        if(no == null) return -1;
        // Caso base, achou o valor
        if(no.Dado == valor) return pos;
        // Chamada recursiva, tenta no próximo nó incrementando o contador
        return PosicaoRec(no.Proximo, valor, pos + 1);
    }

    public int MaiorRec(No? no)
    {
        if(no == null) return -1;
        // Caso base, se for o último nó, o próximo é nulo
        if(no.Proximo == null) return no.Dado;
        // Chamada recursiva, busca o maior valor
        int maiorResto = MaiorRec(no.Proximo);

        return (no.Dado > maiorResto) ? no.Dado : maiorResto;
    }
}