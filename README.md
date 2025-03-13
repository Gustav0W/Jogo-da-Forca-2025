# Jogo da forca

![](https://i.imgur.com/ehh1jfT.gif)

## Introdu��o

� uma calculadora que consegue fazer as 4 opera��es matem�ticas e mostrar a tabuada, incr�vel.

## Funcionalidades

- **Opera��es b�sicas**: Realize somas, subtra��es, multiplica��es, divis�es e veja a tabuada de qualquer n�mero.
- **Suporte a decimais**: Trabalhe com n�meros de at� duas casas decimais, n�o arredonda.
- **Entradas validadas**: A calculadora garante que apenas op��es v�lidas sejam aceitas.
- **Tratamento de divis�o por zero**: A calculadora identifica e valida erros de divis�o por zero.
- **Hist�rico de opera��es**: Ela tamb�m armazena o hist�rico de opera��es!

## Como Utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
```
git clone https://github.com/Gustav0W/Calculadora-Tabajara
```
2. Abra o terminal ou o prompt de comando e navegue at� a pasta ra�z.
```
cd Calculadora-Tabajara
```
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.
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

6. Voc� ver� esse terminal:
```
Console.WriteLine("=================================");
Console.WriteLine("    Calculadora Tabajara 2025    ");
Console.WriteLine("=================================");

Console.WriteLine("1- Somar");
Console.WriteLine("2- Subtrair");
Console.WriteLine("3- Multiplicar");
Console.WriteLine("4- Divis�o");
Console.WriteLine("5- Tabuada");
Console.WriteLine("6- Hist�rico");
Console.WriteLine("S- Sair");
```
