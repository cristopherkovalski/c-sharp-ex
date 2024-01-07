namespace AdaME
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha o programa a ser executado:");
            Console.WriteLine("1. Conversor de Temperatura");
            Console.WriteLine("2. Verificador de Números Primos");
            Console.WriteLine("3. Calcular o fatorial de um número");
            Console.WriteLine("4. Ordenar um array de números");
            Console.WriteLine("5. Verificar se uma palavra é um palíndromo");
            Console.WriteLine("6. Calcular a raiz quadrada de um número");
            Console.WriteLine("7. Converter valor em real para dólar");
            Console.WriteLine("8. Validar uma senha");
            Console.WriteLine("9. Validar um número de CPF");
            Console.WriteLine("10. Contar a frequência de palavras em um texto");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ExecutarConversorTemperatura();
                    break;

                case 2:
                    ExecutarVerificarPrimo();
                    break;

                case 3:
                    ExecutarCalcularFatorial();
                    break;

                case 4:
                    ExecutarOrdenarArray();
                    break;

                case 5:
                    ExecutarVerificarPalindromo();
                    break;

                case 6:
                    ExecutarCalcularRaizQuadrada();
                    break;

                case 7:
                    ExecutarConversorMoeda();
                    break;

                case 8:
                    ExecutarValidarSenha();
                    break;

                case 9:
                    ExecutarValidarCPF();
                    break;

                case 10:
                    ExecutarContarFrequenciaPalavras();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha de 1 a 10.");
                    break;
            }
        }

        static void ExecutarConversorTemperatura()
        {
            ConversorTemperatura conversor = new ConversorTemperatura();

            Console.WriteLine("Escolha a opção de conversão:");
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Fahrenheit para Celsius");

            int escolha = int.Parse(Console.ReadLine());

            double temperatura;

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperatura = double.Parse(Console.ReadLine());
                    double resultadoFahrenheit = conversor.CelsiusParaFahrenheit(temperatura);
                    Console.WriteLine($"Resultado: {resultadoFahrenheit} Fahrenheit");
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperatura = double.Parse(Console.ReadLine());
                    double resultadoCelsius = conversor.FahrenheitParaCelsius(temperatura);
                    Console.WriteLine($"Resultado: {resultadoCelsius} Celsius");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
                    break;
            }
        }
        static void ExecutarVerificarPrimo()
        {
            Console.Write("Digite um número inteiro para verificar se é primo: ");
            int numero = int.Parse(Console.ReadLine());

            bool resultado = VerificadorDeNumerosPrimos.VerificarPrimo(numero);

            if (resultado)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
        static void ExecutarCalcularFatorial()
        {
            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            try
            {
                long resultadoFatorial = CalculadoraFatorial.CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é {resultadoFatorial}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ExecutarOrdenarArray()
        {
            Console.Write("Digite os números do array separados por espaço: ");
            string input = Console.ReadLine();
            string[] numerosString = input.Split(' ');

            int[] array = new int[numerosString.Length];

            for (int i = 0; i < numerosString.Length; i++)
            {
                array[i] = int.Parse(numerosString[i]);
            }

            OrdenadorDeArray.OrdenarArray(array);

            Console.WriteLine("Array ordenado:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void ExecutarVerificarPalindromo()
        {
            Console.Write("Digite uma palavra para verificar se é um palíndromo: ");
            string palavra = Console.ReadLine();

            bool resultado = VerificadorPalindromo.VerificarPalindromo(palavra);

            if (resultado)
            {
                Console.WriteLine($"{palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palavra} não é um palíndromo.");
            }
        }
        static void ExecutarCalcularRaizQuadrada()
        {
            Console.Write("Digite um número para calcular a raiz quadrada: ");
            double numero = double.Parse(Console.ReadLine());

            try
            {
                double resultadoRaiz = CalculadoraRaizQuadrada.CalcularRaizQuadrada(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é aproximadamente {resultadoRaiz:F4}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ExecutarConversorMoeda()
        {
            Console.Write("Digite o valor em reais: ");
            double valorEmReais = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            try
            {
                double valorEmDolares = ConversorDeMoeda.ConverterRealParaDolar(valorEmReais, cotacaoDolar);
                Console.WriteLine($"O valor em dólares é aproximadamente: ${valorEmDolares:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ExecutarValidarSenha()
        {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            bool senhaValida = ValidadorDeSenha.ValidarSenha(senha);

            if (senhaValida)
            {
                Console.WriteLine("Senha válida.");
            }
            else
            {
                Console.WriteLine("Senha inválida. Certifique-se de que a senha tem pelo menos 8 caracteres, contém pelo menos uma letra maiúscula, uma letra minúscula e um número.");
            }
        }
        static void ExecutarValidarCPF()
        {
            Console.Write("Digite o número de CPF: ");
            string cpf = Console.ReadLine();

            bool cpfValido = ValidadorCPF.ValidarCPF(cpf);

            if (cpfValido)
            {
                Console.WriteLine($"{cpf} é um CPF válido.");
            }
            else
            {
                Console.WriteLine($"{cpf} não é um CPF válido.");
            }
        }
        static void ExecutarContarFrequenciaPalavras()
        {
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            Dictionary<string, int> frequenciaPalavras = ContadorDePalavras.ContarPalavras(texto);

            Console.WriteLine("Frequência das palavras:");
            foreach (var kvp in frequenciaPalavras)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} vezes");
            }
        }
    }
}
