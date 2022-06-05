Console.Clear();
var acumulador = 0;
int[] numero = new int[10];
var mayor = 0;
var menor = 0;
var promedio = 0;
Console.WriteLine("A continuación ingrese 10 números");
for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese el {i+1}° número: ");
    numero[i] = int.Parse(Console.ReadLine());
    acumulador += numero[i];
    if (i == 0)
    {
        mayor = numero[i];
        menor = numero[i];
    }
    else
    {
        if (numero[i] > mayor)
        {
            mayor = numero[i];
        }
        if (numero[i] < menor)
        {
            menor = numero[i];
        }
    }
}
promedio = acumulador / 10;
Console.WriteLine($"La suma de todos los números ingresados es: {acumulador}");
Console.WriteLine($"El número mayor ingresado es: {mayor}");
Console.WriteLine($"El número menor ingresado es: {menor}");
Console.WriteLine($"El promedio de todos los números ingresados es: {promedio}");
Console.ReadKey();





