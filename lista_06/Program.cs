/* 
Ex.06 Classificação de Notas
o Objetivo: Aprender a usar múltiplas condições em uma estrutura de 
decisão.
o Descrição: Crie um programa que peça a nota de um aluno e classifique a 
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" 
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
o Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa".
  */
Console.WriteLine("Insira a nota do aluno");
int numero = int.Parse(Console.ReadLine());
if (numero >= 9)
{
    Console.WriteLine("Excelente");
}
else if (numero >= 7)
{
    Console.WriteLine("Boa");
}
else if (numero >= 5)
{
    Console.WriteLine("Regular");
}
else if (numero < 5)
{
    Console.WriteLine("Baixa");
}