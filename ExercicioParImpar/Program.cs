int numInicial, numFinal;
Console.Write("Digite um numero inicial: ");
numInicial = int.Parse(Console.ReadLine());
Console.Write("Digite um numero final: ");
numFinal = int.Parse(Console.ReadLine());
numInicial++;

do
{
    if (numInicial < numFinal)
    {
        if (numInicial % 2 == 0)
        {
            Console.WriteLine($"Valor par: {numInicial}");
        }
        else
        {
            Console.WriteLine($"Valor impar: {numInicial}");
        }
    }
    else if (numInicial > numFinal)
    {
        Console.WriteLine("Numero final nao pode ser menor ou igual");
    }
    numInicial++;
} while (numInicial <= numFinal - 1);
