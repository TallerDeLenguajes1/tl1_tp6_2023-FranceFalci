// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("hola");
string numeroIngresado = Console.ReadLine();

Console.WriteLine(numeroIngresado);

if (int.TryParse(numeroIngresado, out int numeroCasteado) && numeroCasteado>0)
{
    Console.WriteLine("El texto ingresado es un número válido: " + numeroCasteado);


}
else
{
    Console.WriteLine("El texto ingresado no es un número válido.");
}




