//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExemplosFluxograma.Exemplo
//{
//    internal class Exemplos
//    {
//        // tipo nome = valor inicial
//        // NUMEROS
//        // int - inteiros
//        int minhaNota = 9;

//        // double - numeros decimais
//        double salario = 2500.87;

//        // float - numeros decimais (ocupa
//        // menos espaco na memoria)
//        float novoSalario = 3389.76f;

//        // TEXTO
//        string nome = "Vinicio";

//        // char - guarda apenas 1 letra
//        char sexo = 'M';

//        // BOOLEANO
//        // so aceita true ou false
//        bool terminouFaculdade = true;

//        // ENTRADA

//        // Hard Code
//        //int nota1 = 9;
//        //int nota2 = 8;
//        //int nota3 = 10;


//        // Console.ReadLine() - le informacoes do terminal
//        // int.Parse - transforma algo em um numero inteiro
//        Console.WriteLine("Insira a primeira nota:");
//        int nota1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Insira a segunda nota:");
//        int nota2 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Insira a terceira nota:");
//        int nota3 = int.Parse(Console.ReadLine());


//        // PROCESSAMENTO
//        double media = (nota1 + nota2 + nota3) / 3;

//        // Losango - if/else
//        // if - se, else - senao
//        if (media > 6)
//        {
//            // Console.WriteLine - escreve uma linha no terminal
//            Console.WriteLine("APROVADO");
//        }
//        else
//        {
//            Console.WriteLine("REPROVADO");
//        }

//// SAIDA
//// Escreve uma linha no terminal

//// Concatenação - juntar texto com variavel
//Console.WriteLine("A média do aluno é: " + media);

//// Interpolação
//Console.WriteLine($"A média do aluno é: {media}");





//// Declarar uma variável
////int idade;

//// Inicializando uma variável
////int idade = 12;




//// Estruturas Condicionais
//// Simples
//bool sol = true;

//if (sol)
//{
//    Console.WriteLine("Está Ensolarado, vou para a praia!");
//}

//// Composta
//if (sol)
//{
//    Console.WriteLine("Está Ensolarado, vou para a praia!");
//}
//else
//{
//    Console.WriteLine("Vou dormir...");
//}


//// Encadeada
//int minhaIdade = 22;

//if (minhaIdade < 22)
//{
//    Console.WriteLine("É jovem");
//}
//else if (minhaIdade >= 22 && minhaIdade < 55)
//{
//    Console.WriteLine("É adulto");
//}
//else
//{
//    Console.WriteLine("É idoso");
//}
//    }
//}
