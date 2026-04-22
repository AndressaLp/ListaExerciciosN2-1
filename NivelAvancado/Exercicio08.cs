using System.Dynamic;

public partial class ListaEncadeada
{
    public void RemoverDuplicatasComSet()
    {
        if(Cabeca == null) return;

        HashSet<int> vistos =  new HashSet<int>();
        No? atual = Cabeca;
        No? anterior = null;

        while(atual != null)
        {
            if(vistos.Contains(atual.Dado))
            {
                anterior!.Proximo = atual.Proximo;
            }
            else
            {
                vistos.Add(atual.Dado);
                anterior = atual;
            }
            atual = atual.Proximo;
        }
    }
    // Analise:
    // Versão com Set: Preferível na maioria das aplicações modernas, pois o tempo de execução é muito menor, sendo ideal para listas grandes onde memória RAM extra não é um problema crítico.

    public void RemoverDuplicatasSemAux()
    {
        No? fixo = Cabeca;

        while(fixo != null)
        {
            No? anterior = fixo;
            No? scanner = fixo.Proximo;

            while(scanner != null)
            {
                if(scanner.Dado == fixo.Dado)
                {
                    anterior.Proximo = scanner.Proximo;
                }
                else
                {
                    anterior = scanner;
                }
                scanner = scanner.Proximo;
            }
            fixo = fixo.Proximo;
        }
    }
    // Analise:
    // Versão sem Auxiliar: Preferível em sistemas embarcados ou dispositivos com memória extremamente limitada, onde não se pode gastar espaço extra, mesmo que o processamento demore mais.
}