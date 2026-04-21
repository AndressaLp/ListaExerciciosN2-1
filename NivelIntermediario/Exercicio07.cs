public class TorreHanoi
{
    public void Hanoi(int n, char origem, char destino, char auxiliar, ref int contador)
    {
        if(n == 1)
        {
            contador++;
            Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
            return;
        }

        Hanoi(n - 1, origem, auxiliar, destino, ref contador);

        contador++;
        Console.WriteLine($"Mover disco {n} de {origem} para {destino}");

        Hanoi(n - 1, auxiliar, destino, origem, ref contador);
    }

    // Fórmula do número de movimentos em função de n
    // Fórmula: M(n) = 2^n - 1
    // Demonstração da complexidade:
    // A recorrência do algoritmo é:
    // M(n) = 2M(n-1) + 1
    // Isso gera uma árvore de recursão com crescimento exponencial
    // Portanto, a complexidade é O(2^n)
}