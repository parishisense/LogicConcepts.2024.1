using Shared;


var answer= string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int number = ConsoleExtension.GetInt("Ingrese número entero diferente de cero: ");
    if(number==0)
    {
        continue;
    }
    if (number % 2 == 0)
    {

        Console.WriteLine($"El Número {number},es par");
    }
    else
    {
        Console.WriteLine($"El Número {number},es impar");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over");

