Console.Clear();

int tabuada, numerador = 0;

Console.Write("Digite o valor da Tabúada..: ");
tabuada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

while (numerador <= 10)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{tabuada} * {numerador}= {tabuada * numerador} ");
    numerador++;
    Console.ResetColor();
}