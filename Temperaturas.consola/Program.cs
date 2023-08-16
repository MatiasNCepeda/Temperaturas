double celcius;
double fahrenheit;
double reaumur;
int contador=0;
do
{
    Console.Write("ingrese celcius: ");
    while (!double.TryParse(Console.ReadLine(), out celcius))
    {
        Console.WriteLine("error ingrese un numero");
    }
    if (celcius < -50 || celcius > 50 )
    {
        Console.WriteLine("Temperatura no valida");
    }
    else if (celcius==0)
    {
        Console.WriteLine("Fin del ciclo");
    }
    else
    {

        reaumur = FuncionReaumur(celcius);
        fahrenheit = FuncionFahrenheit(celcius);
        Console.WriteLine($"la temperaturas en fahrenheit es {fahrenheit}");
        Console.WriteLine($"la temperaturas en reaumur es {reaumur}");
        contador = contador + 1;
    }
} while (celcius!=0);

Console.WriteLine($"la cantidad de temperaturas es {contador}");
double FuncionFahrenheit(double celcius)
{
    double resultado;
    resultado = 1.8 * celcius + 32;
    return resultado;
}

double FuncionReaumur(double celcius)
{
    double resultado;
    resultado = 0.8 * celcius;
    return resultado;
}

