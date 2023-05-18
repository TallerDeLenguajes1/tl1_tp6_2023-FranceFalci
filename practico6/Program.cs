
float a,b;
Console.WriteLine("Ingrese a:");
bool control= float.TryParse(Console.ReadLine(), out  a);
Console.WriteLine("Ingrese b:");
control= float.TryParse(Console.ReadLine(), out  b);

// Console.WriteLine(a);
// Console.WriteLine(b);

int opcion;
Console.WriteLine("1.sumar 2.restar 3.multiplicar 4.dividir 0.Salir");
control= int.TryParse(Console.ReadLine(), out opcion);
while(opcion != 0){
    float resultado;

    switch(opcion){
        case 1: 
             resultado = suma(a,b); 
            Console.WriteLine(resultado);
            break;
        case 2: 
             resultado = resta(a,b); 
            Console.WriteLine(resultado);

            break;
         case 3: 
             resultado = multiplicacion(a,b); 
            Console.WriteLine(resultado);

            break;
         case 4: 
             resultado = division(a,b); 
            Console.WriteLine(resultado);

            break;
        
    }

    Console.WriteLine("Desea Realizar otra operacion? 1.Si 0.No");
    control= int.TryParse(Console.ReadLine(), out opcion);
    if(opcion == 1){
        Console.WriteLine("1.sumar 2.restar 3.multiplicar 4.dividir 0.Salir");
        control= int.TryParse(Console.ReadLine(), out opcion);
        Console.WriteLine("Ingrese a:");
        control= float.TryParse(Console.ReadLine(), out  a);
        Console.WriteLine("Ingrese b:");
        control= float.TryParse(Console.ReadLine(), out  b);
    }



 

}






// operaciones

float suma (float a, float b){
    return a+b;
}
float resta (float a, float b){
    return a-b;
}
float multiplicacion (float a, float b){
    return a*b;
}
float division (float a, float b){
    return a/b;
}