# Jogo da forca

![](https://i.imgur.com/IwgXDun.gif)

## Introdução

Temos aqui um simples, mas funcional, jogo da forca!! Ele escolhe uma palavra seleta sozinho, à qual você tem que adivinhar.


## Funcionalidades

- **Escolha aleatória**: A palavra é escolhida de maneira aleatória dentre as que foram colocadas no programa.
- **Preenchimento automático**: Ele preenche sozinho o espaço que você acertou as letras e o boneco na forca.

## Como Utilizar

1. Clone o repositório ou baixe o código fonte.
```
git clone https://github.com/Gustav0W/Jogo-da-Forca-2025
```
2. Abra o terminal ou o prompt de comando e navegue até a pasta raíz.
```
cd Jogo-da-Forca-2025
```
3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```
4. Em seguida compile com o comando: 
```
dotnet build --configuration Release
```

5. Execute com o comando:
```
dotnet run
```

6. Você verá esse terminal:
```
----------------------------------
           Jogo da Forca
----------------------------------
 ________________
 |/             |
 |
 |
 |
 |
 |
 |
_|____
----------------------------------
Erros do jogador: 0
----------------------------------
Palavra escolhida: ______ (Aqui pode variar)
----------------------------------
Digite uma letra válida:
```
