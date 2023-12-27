int numPrimo = 2;
bool validacion = true;

Console.WriteLine("Cuantos numeros primos deseas?...");
int n = int.Parse(Console.ReadLine());

int contador = 0;

do
{
    validacion = true;

    for (int i = 2; i < numPrimo; i++)
    {
        if (numPrimo % i == 0)
        {
            //Console.WriteLine("No es un numero primo...");
            validacion = false;
            numPrimo++;
            break;
        }

    }

    if (validacion)
    {
        //Console.WriteLine("Es un numero primo...");
        Console.WriteLine(numPrimo);
        contador++;
        numPrimo++;
    }
} while (contador < n);
