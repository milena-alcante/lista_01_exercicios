/* 
Ex. 09 Dia da Semana (usando if-else)
o Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
o Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba 
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", 
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de 
erro.
o Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. 
Digite um número de 1 a 7."
  */
Console.WriteLine("Insira um número de 1 a 7");
int Dia = int.Parse(Console.ReadLine());


if (Dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (Dia == 2)
{
    Console.WriteLine("Segunda-feira.");
}
else if (Dia == 3)
{
    Console.WriteLine("Terça-feira.");
}
else if (Dia == 4)
{
    Console.WriteLine("Quarta-feira.");
}
else if (Dia == 5)
{
    Console.WriteLine("Quinta-feira.");
}
else if (Dia == 6)
{
    Console.WriteLine("Sexta-feira.");
}
else if (Dia == 7)
{
    Console.WriteLine("Sábado.");
}
else
{
    Console.WriteLine("Dia invalido.");
}