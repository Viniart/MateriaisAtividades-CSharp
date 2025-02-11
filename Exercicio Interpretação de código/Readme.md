# Exercícios de Interpretação de Código - .NET

- **01 - Cálculo de CNPJ -** Dado o script abaixo assinale as estruturas encontradas e o devido trecho que justifique sua existência:
    
    **Exemplo:** 
    
    - [x]  Método
        
        ```jsx
        cnpj.Replace(".", "")
        ```
        
    
    **Exercício completo:**
    
    ```csharp
    using System;
    namespace Validacao
    {
    	/// <summary>
    	/// Realiza a validação do CNPJ
    	/// </summary>
    	public static class ValidaCNPJ
    	{
    		public static bool IsCnpj(string cnpj)
    		{
    			int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
    			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
    			int soma;
    			int resto;
    			string digito;
    			string tempCnpj;
    			cnpj = cnpj.Trim();
    			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
    			if (cnpj.Length != 14)
    			   return false;
    			tempCnpj = cnpj.Substring(0, 12);
    			soma = 0;
    			for(int i=0; i<12; i++)
    			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
    			resto = (soma % 11);
    			if ( resto < 2)
    			   resto = 0;
    			else
    			   resto = 11 - resto;
    			digito = resto.ToString();
    			tempCnpj = tempCnpj + digito;
    			soma = 0;
    			for (int i = 0; i < 13; i++)
    			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
    			resto = (soma % 11);
    			if (resto < 2)
    			    resto = 0;
    			else
    			   resto = 11 - resto;
    			digito = digito + resto.ToString();
    			return cnpj.EndsWith(digito);
    		}
    	}
    }
    ```
    
    Assinale e justifique as estruturas encontradas:
    
    - [ ]  Variáveis
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Constantes
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Métodos
        - [ ]  Argumentos
    - [ ]  Estruturas
        - [ ]  Condicional
            - [ ]  Simples
            - [ ]  Composta
    - [ ]  Laços de repetição
    - [ ]  Operadores lógicos
        - [ ]  E
        - [ ]  OU

- **02 - Sequência Fibonacci -** Dado o script abaixo assinale as estruturas encontradas e o devido trecho que justifique sua existência:
    
    **Exemplo:** 
    
    - [x]  Método
        
        ```c#
        public static void Main (string[] args)
        ```
        
    
    **Exercício completo:**
    
    ```c#
    using System;
    class MainClass {
      public static void Main (string[] args) {
       
    	int numeroAnterior = 0;
    	int numeroAtual = 1;
    	int novoNumero;
    	int fibonacci;
    
       
       for (int i = 0; i <100;  i++ )
    	 {  
    	       fibonacci = numeroAnterior + numeroAtual;
    	       Console.WriteLine  (fibonacci);
    	       numeroAnterior = numeroAtual;
    	       numeroAtual = fibonacci;   
    	  }
     
        
        
      }
    }
    ```
    
    Assinale e justifique as estruturas encontradas:
    
    - [ ]  Variáveis
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Constantes
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Métodos
        - [ ]  Argumentos
    - [ ]  Estruturas
        - [ ]  Condicional
            - [ ]  Simples
            - [ ]  Composta
    - [ ]  Laços de repetição
    - [ ]  Operadores lógicos
        - [ ]  E
        - [ ]  OU

- **03 - Jogo Forca -** Dado o script abaixo assinale as estruturas encontradas e o devido trecho que justifique sua existência:
    
    Exemplo:
    
    - [x]  Método:
    
    ```csharp
    RepetirJogo()
    ```
    
    Código:
    
    ```csharp
    using System;
    
    namespace JogoForca
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                do 
                {
                    Jogar();
                }
                while(RepetirJogo());
            }
    
            private static bool RepetirJogo()
            {
                Console.WriteLine();
                Console.WriteLine("Pressione 'S' para jogar novamente ou qualquer outra tecla para sair.");
                var readKey = Console.ReadKey();
    
                return readKey.KeyChar.ToString().ToUpper() == "S";
            }
    
            private static void Jogar()
            {
                var forca = new Forca();
                while(forca.TentativasRestantes > 0)
                {
                    AtualizarResultados(forca);
    
                    if(!forca.PalavraConluida)
                    {
                        Console.WriteLine("Informe uma nova letra: ");
                        var readKey = Console.ReadKey();
                        forca.TentarNovaLetra(readKey.KeyChar);
                    }
                    else
                    {
                        AtualizarResultados(forca);
                        Console.WriteLine();
                        Console.WriteLine("Fim de jogo, você venceu!");
                        return;
                    }
                }
    
                Console.WriteLine();
                Console.WriteLine("Fim de jogo, você perdeu!");
            }
    
            private static void AtualizarResultados(Forca forca)
            {
                Console.Clear();
                Console.WriteLine($"Tentativas disponíveis: {forca.TentativasDisponiveis}");
                Console.WriteLine($"Tentativas usadas: {forca.TentativasUsadas}");
                Console.WriteLine($"Tentativas restantes: {forca.TentativasRestantes}");
                Console.WriteLine();
                Console.WriteLine($"Categoria: {forca.Categoria}");
                Console.WriteLine($"Letras já utilizadas: {ListarLetrasUsadas(forca)}");
                Console.WriteLine();
                Console.WriteLine($"Adivinhe as letras da palavra:");
                Console.WriteLine(forca.LetrasCorretasDaPalavra);
                Console.WriteLine();
            }
    
            private static string ListarLetrasUsadas(Forca forca)
            {
                string letrasUsadas = string.Empty;
    
                foreach(var letra in forca.LetrasUsadas)
                {
                    letrasUsadas += $"{letra} - ";
                }
    
                return letrasUsadas;
            }
        }
    }
    ```
    
    Assinale e justifique as estruturas encontradas:
    
    - [ ]  Variáveis
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Constantes
        - [ ]  String
        - [ ]  Booleana
        - [ ]  Inteira
        - [ ]  Array/Vetor
    - [ ]  Métodos
        - [ ]  Argumentos
    - [ ]  Estruturas
        - [ ]  Condicional
            - [ ]  Simples
            - [ ]  Composta
    - [ ]  Laços de repetição
    - [ ]  Operadores lógicos
        - [ ]  E
        - [ ]  OU
