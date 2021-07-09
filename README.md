# Reposit�rio para Estudos de OOP

Os 4 pilares da programa��o orientada a objetos s�o: Abstra��o, Encapsulamento, Heran�a e Polimorfismo;

## Abstra��o

A abstra��o � utilizada para a defini��o de entidades do mundo real. Essas entidades s�o consideradas tudo que � real, tendo como considera��o as suas caracter�sticas e a��es, por exemplo:

| Entidade | Caracteristicas | A��es |
|---|---|---|
| Carro, Moto | Tamanho, cor, peso, altura, valor | Acelerar, parar, ligar, desligar |
| Viol�o | Tamanho, peso, madeira | Tocar nota, tocar acorde, afinar |
| Conta no Banco | Saldo, limite, numero | Depositar, sacar, ver extrato |

## Encapsulamento

Encapsulamento � o processo de ocultar o funcionamento interno de nossas classes. Em C #, temos quatro palavras-chave modificadores de acesso que permitem cinco maneiras de controlar a visibilidade do c�digo.

- **Private:** Visivel apenas para a classe que o cont�m;
- **Protected:** Visivel apenas para as classes que herdam;
- **Internal:** Visivel apenas para as classes do mesmo assembly;
- **Protected Internal:** Visivel apenas para as classes que herdam e estejam no mesmo assembly;
- **Public:** Visivel para todos;

## Heran�a

As classes podem herdar de outras classes, o que significa que a sub classe obt�m todo o comportamento da classe herdada, tamb�m
conhecida como classe base. Quando herdamos de uma classe, obtemos uma rela��o similar a "� um".

- **Composi��o:** Usando a composi��o, podemos definir uma rela��o "tem um" ao inv�s da rela��o "� um" fornecida pela heran�a. Desta forma podemos compor nosso objeto com diversas caracter�sticas, como por exemplo: Um carro n�o � um motor, ele tem um motor al�m de outras partes como portas, rodas, janelas, chassi, etc..

## Polimorfismo

Definimos Polimorfismo como um princ�pio a partir do qual as classes derivadas de uma �nica classe base s�o capazes de invocar os m�todos que, embora apresentem a mesma assinatura, comportam-se de maneira diferente para cada uma das classes derivadas.

Com o Polimorfismo, os mesmos atributos e objetos podem ser utilizados em objetos distintos, por�m, com implementa��es l�gicas diferentes.

Por exemplo: podemos assumir que uma bola de futebol e uma camisa da sele��o brasileira s�o artigos esportivos, mais que o c�lculo deles em uma venda � calculado de formas diferentes.