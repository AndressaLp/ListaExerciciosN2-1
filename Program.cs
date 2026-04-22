Console.WriteLine("Exercício 1 - Percorrer e Imprimir uma Lista");
ListaEncadeada lista = new ListaEncadeada();
lista.InserirFinal(10);
lista.InserirFinal(20);
lista.InserirFinal(30);
lista.Imprimir(); 
Console.WriteLine("\n");


Console.WriteLine("Exercício 2 - Fatorial Recursivo");
FatorialRecursivo fat = new FatorialRecursivo();
Console.WriteLine($"Fatorial de 0: , {fat.Fatorial(0)}");
Console.WriteLine($"Fatorial de 5: , {fat.Fatorial(5)}");
Console.WriteLine($"Fatorial de 10: , {fat.Fatorial(10)}");
Console.WriteLine("\n");


Console.WriteLine("Exercício 3 - Contar Nós da Lista");
Console.WriteLine($"Contagem iterativa: {lista.Contar()}");
Console.WriteLine($"Contagem recursiva: {lista.ContarRec(lista.Cabeca)}");
Console.WriteLine("\n");


Console.WriteLine("Exercício 4 - Inverter Lista Encadeada");
lista.Cabeca = null;
lista.InserirFinal(1);
lista.InserirFinal(2);
lista.InserirFinal(3);
lista.InserirFinal(4);
Console.WriteLine($"Antes de inverter: ");
lista.Imprimir();
lista.Inverter();
Console.WriteLine();
Console.WriteLine($"Depois de inverter: ");
lista.Imprimir();
Console.WriteLine("\n");


Console.WriteLine("Exercício 5 - Fibonacci com Memoização");
Fibonacci fib = new Fibonacci();
int n = 20;
fib.FibNaive(n);
Console.WriteLine($"[Naive] n={n}, chamadas: {Fibonacci.chamadasNaive}");
var meuCache = new Dictionary<int, long>();
fib.FibMemo(n, meuCache);
Console.WriteLine($"[Memo] n={n}, chamadas: {Fibonacci.chamadasMemo}");
Console.WriteLine("\n");


Console.WriteLine("Exercício 6 - Busca Recursiva em Lista");
lista.Cabeca = null;
lista.InserirFinal(2);
lista.InserirFinal(4);
lista.InserirFinal(6);
bool existe = lista.ExisteRec(lista.Cabeca, 4);
int posicao = lista.PosicaoRec(lista.Cabeca, 4);
int maior = lista.MaiorRec(lista.Cabeca);
Console.WriteLine($"Existe 4: {existe}, Posição do 4: {posicao}, Maior valor: {maior}");
Console.WriteLine("\n");


Console.WriteLine("Exercício 7 - Torre de Hanói - Contar Movimentos");
TorreHanoi torreHanoi = new TorreHanoi();
int totalMovimentos = 0;
int numDiscos = 3;
torreHanoi.Hanoi(numDiscos, 'A', 'C', 'B', ref totalMovimentos);
Console.WriteLine($"Total de movimentos para {numDiscos} discos: {totalMovimentos}");
Console.WriteLine("\n");


Console.WriteLine("Exercício 8 - Remover Duplicatas");
lista.Cabeca = null;
lista.InserirFinal(1);
lista.InserirFinal(2);
lista.InserirFinal(3);
lista.InserirFinal(2);
lista.InserirFinal(4);
lista.InserirFinal(1);
Console.WriteLine($"Antes de remover duplicatas: ");
lista.Imprimir();
Console.WriteLine();
// Descomentar/comentar linha quando precisar testar outro método
lista.RemoverDuplicatasComSet();
// lista.RemoverDuplicatasSemAux();
Console.WriteLine($"Depois de remover duplicatas: ");
lista.Imprimir();
Console.WriteLine("\n");


Console.WriteLine("Exercício 9 - Detectar Ciclo em Lista");
No? no4 = lista.Cabeca!.Proximo!.Proximo!.Proximo;
No? no2 = lista.Cabeca.Proximo;
no4!.Proximo = no2; 
Console.WriteLine($"Tem ciclo? {lista.TemCiclo()}");
No? inicio = lista.InicioCiclo();
if (inicio != null) {
    Console.WriteLine($"O ciclo começa no nó com valor: {inicio.Dado}");
}
Console.WriteLine("\n");


Console.WriteLine("Exercício 10 - Merge Sort em Lista Encadeada");
ListaEncadeada listaMerge = new ListaEncadeada();
int[] valores = {5, 1, 4, 2, 8, 3};
foreach(int valor in valores)
{
    listaMerge.InserirFinal(valor);
}
Console.WriteLine($"Antes da ordenação: ");
listaMerge.Imprimir();
Console.WriteLine();
listaMerge.Ordenar();
Console.WriteLine($"Depois do Merge Sort: ");
listaMerge.Imprimir();
Console.WriteLine("\n");