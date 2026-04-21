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