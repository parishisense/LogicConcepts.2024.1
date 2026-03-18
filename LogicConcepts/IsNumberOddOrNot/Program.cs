var numberString = string.Empty;
do
{
    Console.Write("Ingrese Número entero o la palabra 'Salir' para salir:");
    numberString = Console.ReadLine(); // "10"
    if(numberString!.ToLower()== "salir")
    {
        continue;
    };
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))  // 10
    {
        if (numberInt % 2 == 0)
        {

            Console.WriteLine($"El Número {numberInt},es par");
        }
        else
        {
            Console.WriteLine($"El Número {numberInt},es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor {numberString} no es un número entero");
    };
   
}while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");

