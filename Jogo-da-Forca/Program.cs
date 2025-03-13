namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = 
            {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random geradorDeNumeros = new Random();

            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);
            string palavraEscolhida = palavras[indiceEscolhido];


            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
            {
                letrasEncontradas[caractereAtual] = '_';
            }
            //Quantidade de erros limite
            int quantidadeErros = 0;
            bool jogadorAcertou = false;
            bool jogadorErrou = false;


            do
            {
            //Operador ternário
                string cabecaDoDesenho = quantidadeErros >= 1 ? " O " : " ";
                string troncoDoDesenho = quantidadeErros >= 2 ? "x" : " ";
                string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : " ";
                string bracoDireitoDoDesenho = quantidadeErros >= 3 ? "\\" : " ";
                string bracoEsquerdoDoDesenho = quantidadeErros >= 4 ? "/" : " ";
                string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\" : " " ;

                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("           Jogo da Forca          ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" ________________                 ");
                Console.WriteLine(" |/             |                 ");
                Console.WriteLine(" |             {0}                ", cabecaDoDesenho);
                Console.WriteLine(" |             {0}{1}{2}          ", bracoEsquerdoDoDesenho, troncoDoDesenho ,bracoDireitoDoDesenho);
                Console.WriteLine(" |             {0}                ", troncoInferiorDoDesenho);
                Console.WriteLine(" |             {0}                ", pernasDoDesenho);
                Console.WriteLine(" |                                ");
                Console.WriteLine(" |                                ");
                Console.WriteLine("_|____                            ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Erros do jogador: {quantidadeErros}");
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Palavra escolhida: {String.Join("", letrasEncontradas)}");
                Console.WriteLine("----------------------------------");

                //dado um caractere
                Console.Write("Digite uma letra válida: ");
                string entradaInicial = Console.ReadLine()!.ToUpper();

                if (entradaInicial.Length > 1)
                {         
                    Console.WriteLine("Informe apenas um caractere");
                    continue;
                }

                //Lógica do jogo
                char chute = entradaInicial[0];

                bool letraFoiEncontrada = false;

                for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                {
                    char caractereAtual = palavraEscolhida[contadorCaracteres];

                    if (chute == caractereAtual)
                    {
                        letrasEncontradas[contadorCaracteres] = caractereAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                string palavraEncontradaCompleta = string.Join("", letrasEncontradas);

                jogadorAcertou = palavraEncontradaCompleta == palavraEscolhida;

                if(jogadorAcertou)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"Você acertou! A palavra é {palavraEscolhida}, parabéns");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ReadLine();
                }

                jogadorErrou = quantidadeErros > 5;

                if (jogadorErrou)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"Você não conseguiu, a palavra era {palavraEscolhida} :( tente novamente!");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ReadLine();
                }

            } while (jogadorAcertou == false && jogadorErrou == false);

        }
    }
}
