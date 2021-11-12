# Repositório para Estudos de OOP

Os 4 pilares da programação orientada a objetos são: Abstração, Encapsulamento, Herança e Polimorfismo;

## Abstração

Classes e métodos abstratos, servem para moldar uma estrutura comum para entidades (classes) de um programa que compartilham algumas características, mas que diferem em outras. Não é permitido criar instâncias de classes abstratas, apenas da classe concreta que implementa a abstração.

Suponha que seja necessário criar várias classes que possuem algumas características e comportamentos em comum, mas que ao mesmo tempo possuem suas particularidades, o que impede de se trabalhar com uma única classe. Nessas situações, podemos criar uma classe superior que sirva como molde para as demais, definindo sua estrutura base e que tenha, ou não, métodos já implementados por padrão.

Para os métodos cuja execução seja comum a todas as classes filhas, pode-se implementá-los ainda na classe abstrata, e todas as classes filhas herdarão o mesmo comportamento. Já aqueles métodos que serão implementados de formas distintas nas classes que os herdarão, podem ser declarados apenas como uma assinatura, sem corpo, para que cada classe filha os implemente como for mais adequado.

## Encapsulamento

Encapsulamento é o processo de ocultar o funcionamento interno de nossas classes. Em C #, temos quatro palavras-chave modificadores de acesso que permitem cinco maneiras de controlar a visibilidade do código.

- **Private:** Visivel apenas para a classe que o contém;
- **Protected:** Visivel apenas para as classes que herdam;
- **Internal:** Visivel apenas para as classes do mesmo assembly;
- **Protected Internal:** Visivel apenas para as classes que herdam e estejam no mesmo assembly;
- **Public:** Visivel para todos;

## Herança

As classes podem herdar de outras classes, o que significa que a sub classe obtém todo o comportamento da classe herdada, também
conhecida como classe base. Quando herdamos de uma classe, obtemos uma relação similar a "é um".

- **Composição:** Usando a composição, podemos definir uma relação "tem um" ao invés da relação "é um" fornecida pela herança. Desta forma podemos compor nosso objeto com diversas características, como por exemplo: Um carro não é um motor, ele tem um motor além de outras partes como portas, rodas, janelas, chassi, etc..

## Polimorfismo

Definimos Polimorfismo como um princípio a partir do qual as classes derivadas de uma única classe base são capazes de invocar os métodos que, embora apresentem a mesma assinatura, comportam-se de maneira diferente para cada uma das classes derivadas.

Com o Polimorfismo, os mesmos atributos e objetos podem ser utilizados em objetos distintos, porém, com implementações lógicas diferentes.

Por exemplo: podemos assumir que uma bola de futebol e uma camisa da seleção brasileira são artigos esportivos, mais que o cálculo deles em uma venda é calculado de formas diferentes.