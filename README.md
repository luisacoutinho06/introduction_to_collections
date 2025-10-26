# Introdução às Coleções em C#

Este projeto apresenta uma coleção de implementações práticas que exploram o funcionamento das principais **estruturas de dados e coleções do C#**, abordando desde conceitos básicos de armazenamento até consultas avançadas com LINQ.

A solução está organizada em diferentes módulos, cada um focado em um tipo de coleção ou conceito específico. O objetivo é compreender o comportamento, as características e as operações disponíveis em cada estrutura, analisando quando e por que utilizá-las.

## Estruturas e Conceitos Abordados

### Arrays
Exploração de arrays como estrutura de armazenamento indexado de tamanho fixo.  
Inclui operações de declaração, inicialização, atribuição, modificação de elementos e cópia de dados entre arrays.


### Listas (`List<T>`)
Estudo das listas como coleções dinâmicas que permitem crescimento e manipulação flexível.  
Foram abordadas operações de adição, remoção, ordenação e totalização de valores, além da utilização de listas de objetos e listas somente leitura.


### Conjuntos (`HashSet<T>` e `SortedSet<T>`)
Análise dos conjuntos e suas propriedades, com foco na **eliminação de duplicidades** e nas operações de **união, interseção e diferença**.  
Também foi implementado um comparador personalizado (`IComparer`) para controle da ordenação e comparação de elementos.


### Dicionários (`Dictionary<TKey, TValue>`, `SortedDictionary<TKey, TValue>`)
Aplicação do conceito de pares chave-valor para mapeamento e acesso eficiente aos dados.  
Inclui inserção, substituição, verificação de existência e entendimento do funcionamento interno baseado em hashing.  
Além disso, foram estudadas coleções ordenadas como `SortedList` e `SortedDictionary`.


### Arrays Multidimensionais e Jagged Arrays
Exploração de estruturas de armazenamento com múltiplas dimensões.  
Os **arrays multidimensionais** foram usados para representar tabelas e grades, enquanto os **jagged arrays** permitiram trabalhar com coleções de tamanhos variáveis, demonstrando flexibilidade na modelagem dos dados.


### Listas Ligadas, Pilhas e Filas
Estudo de estruturas que gerenciam a ordem dos elementos de forma dinâmica:
- **LinkedList**: manipulação de elementos encadeados.  
- **Stack (Pilha)**: estrutura LIFO (último a entrar, primeiro a sair).  
- **Queue (Fila)**: estrutura FIFO (primeiro a entrar, primeiro a sair).


### Consultas com LINQ
Introdução às consultas integradas à linguagem para manipulação de coleções.  
Foram aplicadas operações de **filtragem**, **ordenação**, **projeção** e **transformação de dados**, além de consultas encadeadas utilizando expressões lambda.


### Operadores Avançados do LINQ
Utilização de operadores adicionais para manipulação e recorte de sequências de dados, incluindo métodos para **paginação**, **filtragem condicional** e **controle de intervalos**.  
Foram abordados operadores como `Take`, `Skip`, `TakeWhile`, `SkipWhile` e equivalentes.


### Covariância e Conversão de Coleções
Análise do comportamento da **covariância em coleções genéricas** e da **conversão entre diferentes tipos de coleções**, reforçando a interoperabilidade entre estruturas que compartilham tipos compatíveis.


### Laço `foreach`
Revisão e aplicação do `foreach` como forma simplificada e segura de percorrer coleções.  
O foco foi compreender sua integração com a interface `IEnumerable` e como ele abstrai a complexidade da iteração manual.



