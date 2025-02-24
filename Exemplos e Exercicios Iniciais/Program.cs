﻿/*
 * 1 ----
 * Faça um programa que o usuário informe o salário recebido e o total gasto. 
 * Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
 * não ultrapasse o valor do salário e “Orçamento estourado” se 
 * o valor gasto ultrapassar o valor do salário.
 * 
 * */

double salario, totalGasto;

Console.WriteLine("Informe o salário: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gasto: ");
totalGasto = double.Parse(Console.ReadLine());

if(salario > totalGasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}

/*
 * 2------
 * Desenvolva um programa que recebe do usuário, 
 * o placar de um jogo de futebol (os gols de cada time) 
 * e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
 * 
 * */

/*
 * 3------
 * Escreva	 um	 programa que leia	 as	 medidas	 dos	 lados	 de	 um	 triângulo	 
 * e	escreva	se	ele	é	Equilátero,	Isósceles	ou	Escaleno.	
 * Sendo	que:	
− Triângulo	Equilátero:	possui	os	3	lados	iguais.	
− Triângulo	Isóscele:	possui	2	lados	iguais.	
− Triângulo	Escaleno:	possui	3	lados	diferentes.
 * 
 * */


/*
 * 4 - Escreva	 um	 programa	 que	 verifique	 a	 validade	 de	 uma	 senha	 fornecida pelo	 usuário.	 
 * A	 senha	 válida	 é	 o	 número	 1234.	Devem	 ser	impressas	 as	seguintes	 mensagens:	
ACESSO	PERMITIDO	caso	a	senha	seja	válida.	
ACESSO	NEGADO	caso	a	senha	seja	inválida
 * 
 * */

/*
 * 5 - As	maçãs custam R$ 0,30 cada se forem compradas	menos do que uma dúzia, 
 * e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o
 * número de maçãs compradas, 
 * calcule e escreva o valor	total	da	compra.
 * 
 * */

int quantidadeMacas = int.Parse(Console.ReadLine());
double totalCompra;

if (quantidadeMacas < 12)
{
    totalCompra = quantidadeMacas * 0.30;
}
else
{
    totalCompra = quantidadeMacas * 0.25;
}

Console.WriteLine(totalCompra);

/*
 * 6 -Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. 
 * Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, 
 * ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão 
 * utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, 
 * e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, 
 * começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
 * 
 * */


