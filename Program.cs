// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/
//Ejercicio 1
/*string ?stringNum = Console.ReadLine();
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
//Ejercicio 2
string ?Stringmenu = "1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir";
int opcionMenu = 0;
int numA;
int numB;
int ejecutar = 1;
int result = 0;
int resultOperacion = 0;
int resultMenu = 0;

while(ejecutar == 1) {
    
    Console.WriteLine(Stringmenu);
    Console.WriteLine("Ingrese una opcion");
    opcionMenu = int.TryParse(Console.ReadLine(), out resultMenu) ? resultMenu : 0;

    switch(opcionMenu) {

        case 1:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            resultOperacion = numA+numB;
            
        break;
        case 2:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            resultOperacion = numA-numB;
            
        break;
        case 3:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            resultOperacion = numA*numB;
            
        break;
        case 4:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out result) ? result : 0;
            resultOperacion = numA/numB;
            
        break;       
    }
    Console.WriteLine("Resultado operacion: "+resultOperacion);
    Console.WriteLine("Desea realizar otra operacion? si = 1, no = 0");
    ejecutar = int.TryParse(Console.ReadLine(), out result) ? result : 0;
}


