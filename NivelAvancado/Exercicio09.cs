public partial class ListaEncadeada
{
    public bool TemCiclo()
    {
        No? lento = Cabeca;
        No? rapido = Cabeca;

        while(rapido != null && rapido!.Proximo != null)
        {
            lento = lento!.Proximo;
            rapido = rapido.Proximo.Proximo;
            if(lento == rapido) return true;
        }
        return false;
    }

    public No? InicioCiclo()
    {
        No? lento = Cabeca;
        No? rapido = Cabeca;
        bool encontrou = false;

        while(rapido != null && rapido.Proximo != null)
        {
            lento = lento?.Proximo;
            rapido = rapido.Proximo.Proximo;
            if(lento == rapido)
            {
                encontrou = true;
                break;
            }
        }

        if(!encontrou) return null;

        No? p1 = Cabeca;
        No? p2 = lento;
        while(p1 != p2)
        {
            p1 = p1?.Proximo;
            p2 = p2?.Proximo;
        }
        return p1;
    }
}