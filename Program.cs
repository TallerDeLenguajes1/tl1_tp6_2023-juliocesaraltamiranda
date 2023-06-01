// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/
//Ejercicio 1
/*Console.WriteLine("Ingrese un numero para invertirlo");
string ?stringNum = Console.ReadLine();
int num = 0;
bool ok = int.TryParse(stringNum, out num);

if(ok) {

    if(num>0) {

        int cociente = num / 10;
        int resto = num % 10;
        string ?numInvertido = null;
        numInvertido = resto.ToString();

        while(cociente!=0) {
            resto = cociente % 10;
            cociente = cociente/10;
            numInvertido = numInvertido+resto.ToString();
        }

        Console.WriteLine("numInvertido: "+numInvertido);
    } else {
        Console.WriteLine("El numero debe ser mayor a cero");
    }

} else {
    Console.WriteLine("Hubo un problema en la conversion del numero: "+stringNum);
}
*/

//Ejercicio 4
Console.WriteLine("Ingrese una cadena");
string ?cadena = Console.ReadLine();

if(cadena != null) {
    Console.WriteLine($"Longitud de texto: {cadena.Length}");
} else {
    Console.WriteLine($"Longitud de texto: 0");
}

Console.WriteLine("Ingrese un segunda cadena");
string ?cadena2 = Console.ReadLine();
Console.WriteLine($"Cadenas concatenadas: {cadena} {cadena2}");

if(cadena2 != null) {//por ej ingresar: Programador Universitario
    var subcadena = cadena2.Substring(12);
    Console.WriteLine("Substring: "+subcadena);//Universitario
}

