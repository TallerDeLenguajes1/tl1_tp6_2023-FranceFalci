// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese un número: ");
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





string invertido = invertirNumero(numeroCasteado);
Console.WriteLine(invertido);


string invertirNumero(int numero)
{
     if(numero<10){
        return Convert.ToString(numero);
     }else{
            int ultimoDigito = numero % 10;
            int numeroSinUltimoDigito = numero / 10;
            return(Convert.ToString(ultimoDigito) + Convert.ToString(invertirNumero(numeroSinUltimoDigito)));

    }
}