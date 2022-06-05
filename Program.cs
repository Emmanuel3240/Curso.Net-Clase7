Console.Clear();
var contador = 0;
var acumulador = 0;
var numero=0;
var mayor = 0;
var menor = 0;
var promedio = 0;
Console.WriteLine("A continuación ingrese 10 números");
do
{
    contador++;
    Console.WriteLine($"Ingrese el {contador}° número y presione ENTER: ");
    numero = int.Parse(Console.ReadLine());
    acumulador = acumulador + numero;
    promedio = acumulador / contador;
    if (contador == 1)
    {
        mayor = numero;
        menor = numero;
    }
    else
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
}
while (contador < 10);

Console.WriteLine($"La suma de todos los números ingresados es: {acumulador}");
Console.WriteLine($"El número mayor ingresado es: {mayor}");
Console.WriteLine($"El número menor ingresado es: {menor}");
Console.WriteLine($"El promedio de todos los números ingresados es: {promedio}");
Console.ReadKey();





