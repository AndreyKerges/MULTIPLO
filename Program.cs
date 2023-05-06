int num, mult, resultado;


Console.WriteLine("---MULTIPLO---");

Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Avaliar se é múltiplo de: ");
mult = int.Parse(Console.ReadLine()!);

resultado = num / mult;
if (num % mult == 0)
{
    Console.WriteLine($"{num} é múltiplo de {mult}");
}

else 
{
    Console.WriteLine($"{num} não é múltiplo de {mult}");
}