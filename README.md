<div align="center">
    <h3>ALGORITMOS AVANÇADOS</h3>
    <h1>Lista de Exercícios</h1>
    <h3>Listas Encadeadas & Recursividade</h3>
</div>

---

</br>

# Nível básico

### Exercício 1 - Percorrer e Imprimir uma Lista
**Tópicos:** Lista Encadeada, percurso

Dada a classe No e ListaEncadeada, implemente o método imprimir() que percorre todos os nós e exibe os valores separados por →, terminando com None.

Saída esperada para [10, 20, 30]:  10 → 20 → 30 → None

---

### Exercício 2 - Fatorial Recursivo
**Tópicos:** Recursividade, caso base

Implemente a função fatorial(n) de forma recursiva. Considere que n! = n × (n−1)! e que 0! = 1 é o caso base.
- Entrada: inteiro n ≥ 0
- Saída: valor de n!
- Restrição: não use laços (for / while)

Teste:  fatorial(0)=1 | fatorial(5)=120 | fatorial(10)=3628800

---

### Exercício 3 - Contar Nós da Lista
**Tópicos:** Lista Encadeada, contagem

Implemente o método contar() na classe ListaEncadeada que retorna o número total de nós da lista.

Em seguida, implemente também a versão recursiva como função auxiliar contar_rec(no) que recebe o nó atual e retorna a contagem a partir dele.

---

<br>

# Nível intermediário

### Exercício 4 - Inverter Lista Encadeada
**Tópicos:** Lista Encadeada, manipulação de ponteiros

Implemente o método inverter() que inverte a lista in-place (sem criar uma nova lista). Ao final, self.cabeca deve apontar para o antigo último nó.

💡  Dica: use três ponteiros  anterior = None, atual = self.cabeca, proximo = None. A cada passo, inverta o ponteiro de atual e avance os três.

Exemplo:  1 → 2 → 3 → 4 → None  após inverter →  4 → 3 → 2 → 1 → None

---

### Exercício 5 - Fibonacci com Memoização
**Tópicos:** Recursividade, memoização, complexidade

a) Implemente fib_naive(n) recursivo sem memoização (O(2ⁿ)).

b) Implemente fib_memo(n, cache={}) com memoização (O(n)).

c) Compare o número de chamadas entre as duas versões para n = 20. Instrua um contador global em cada implementação e imprima o resultado.

---

### Exercício 6 - Busca Recursiva em Lista
**Tópicos:** Lista Encadeada, recursividade

Implemente sem usar laços:
- existe_rec(no, valor) → retorna True se o valor estiver na lista, False caso contrário.
- posicao_rec(no, valor, pos=0) → retorna o índice do valor (0-based) ou -1 se não encontrado.
- maior_rec(no) → retorna o maior valor da lista (assuma lista não vazia).

Para cada função, identifique explicitamente o caso base e a chamada recursiva em um comentário no código.

---

### Exercício 7 - Torre de Hanói - Contar Movimentos
**Tópicos:** Recursividade, análise de complexidade

Implemente a solução recursiva da Torre de Hanói que imprime cada movimento e conta o total de movimentos.

Após implementar, responda: qual é a fórmula do número de movimentos em função de n? Demonstre que a complexidade é O(2ⁿ).

---

</br>

# Nível avançado

### Exercício 8 - Remover Duplicatas
**Tópicos:** Lista Encadeada, sets, ponteiros

Implemente o método remover_duplicatas() que remove todos os nós com valores repetidos, mantendo a primeira ocorrência de cada valor.

a) Versão com set auxiliar (O(n) tempo, O(n) espaço extra).

b) Versão sem estrutura auxiliar (O(n²) tempo, O(1) espaço extra).

Exemplo:  1 → 2 → 3 → 2 → 4 → 1 → None  →  1 → 2 → 3 → 4 → None

🤔  Analise: em qual cenário você preferiria cada versão? Justifique em 2-3 linhas.

---

### Exercício 9 - Detectar Ciclo em Lista
**Tópicos:** Lista Encadeada, algoritmo de Floyd

Uma lista com ciclo é aquela em que o proximo de algum nó aponta para um nó anterior, criando um loop infinito.

Implemente tem_ciclo(cabeca) usando o algoritmo de Floyd (tartaruga e lebre):
- Dois ponteiros: lento avança 1 passo, rapido avança 2 passos.
- Se eles se encontrarem, há ciclo. Se rapido chegar em None, não há ciclo.

Bônus: implemente inicio_ciclo(cabeca) que retorna o nó onde o ciclo começa (fase 2 do algoritmo de Floyd).

---

### Exercício 10 - Merge Sort em Lista Encadeada
**Tópicos:** Lista Encadeada, recursividade, divisão e conquista

Implemente o Merge Sort recursivo para ordenar uma lista encadeada. Complexidade esperada: O(n log n).

Implemente as três funções abaixo:
- encontrar_meio(cabeca) → retorna o nó do meio (use ponteiros lento e rápido).
- mesclar(l1, l2) → mescla duas listas ordenadas em uma única lista ordenada (recursivo ou iterativo).
- merge_sort(cabeca) → divide a lista ao meio, ordena recursivamente e mescla.

💡  Dica: encontrar_meio com dois ponteiros garante divisão O(n) sem precisar saber o tamanho da lista.