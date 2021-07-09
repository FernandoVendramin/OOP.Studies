# Repositório para Estudos de OOP

Os 4 pilares da programação orientada a objetos são: Abstração, Encapsulamento, Herança e Polimorfismo;

## Abstração

A abstração é utilizada para a definição de entidades do mundo real. Essas entidades são consideradas tudo que é real, tendo como consideração as suas características e ações, por exemplo:

| Entidade | Caracteristicas | Ações |
|---|---|---|
| Carro, Moto | Tamanho, cor, peso, altura, valor | Acelerar, parar, ligar, desligar |
| Violão | Tamanho, peso, madeira | Tocar nota, tocar acorde, afinar |
| Conta no Banco | Saldo, limite, numero | Depositar, sacar, ver extrato |

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