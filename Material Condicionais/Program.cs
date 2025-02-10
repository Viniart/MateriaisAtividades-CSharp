// Fundamentos de C#

// Tipos de Dados
// Entrada e Saída
// Estruturas Condicionais

// Estruturas de Repetição
// Vetores e Funções




// REPETICAO
// while - enquanto
int numero = 1;

//// Enquanto numero for menor que 10
while(numero < 10)
{
   Console.WriteLine(numero);
    numero++;
}

//// DO/WHILE
//bool acertou;

//do
//{
//    Console.WriteLine("Qual a idade do SENAI?");
//    string resposta = Console.ReadLine();

//    if (resposta == "80")
//    {
//        Console.WriteLine("Acertou");
//        acertou = true;
//    }
//    else
//    {
//        acertou = false;
//    }

//} while (!acertou);
// while (acertou == false);

// FOR - Para

// int i = 0 (criando uma variavel que tem valor 0)
// Na parte central eu decido quando o for se encerra
// i++ (somando 1 no i)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}