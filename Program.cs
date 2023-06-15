// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/
//Ejercicio 1
/*
Console.WriteLine("Ingrese un numero para invertirlo");
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

/*
//Ejercicio 2 
string ?Stringmenu = "1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Valor absoluto\n6-El cuadrado\n7-Raiz cuadrada\n8-El seno\n9-El coseno\n10-Parte entero de un tipo float";
int opcionMenu = 0;
int numA = 0;
int numB = 0;
int ejecutar = 1;
int resultOperacion = 0;
int resultMenu = 0;
double radianes = 0;
double resultOperacionDouble = 0;
float numFloat = 0;
string ?OperacionTexto = null;




while(ejecutar == 1) {

    Console.WriteLine(Stringmenu);
    Console.WriteLine("Ingrese una opcion");
    opcionMenu = int.TryParse(Console.ReadLine(), out resultMenu) ? resultMenu : -1;

    if(opcionMenu == -1) {
        Console.WriteLine("Ingrese un numero valido");
        return;
    }

    switch(opcionMenu) {

        case 1:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out numB) ? numB : -1;
            if(numA == -1 || numB == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }
            resultOperacion = numA+numB;
            OperacionTexto = "La suma";
        break;
        case 2:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out numB) ? numB : -1;

            if(numA == -1 || numB == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacion = numA-numB;
            OperacionTexto = "La resta";
            
        break;
        case 3:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out numB) ? numB : -1;

            if(numA == -1 || numB == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacion = numA*numB;
            OperacionTexto = "La multiplicacion";
        break;
        case 4:
            Console.WriteLine("Ingresar el primer numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;
            Console.WriteLine("Ingresar el segundo numero");
            numB = int.TryParse(Console.ReadLine(), out numB) ? numB : -1;

            if(numA == -1 || numB == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }
            
            resultOperacion = numA/numB;
            OperacionTexto = "La division";
        break;       
        case 5:
            Console.WriteLine("Ingresar un numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;

            if(numA == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacion = numA;
            if(numA<0) {
                resultOperacion = -1*numA;
            }
            OperacionTexto = null;
        break;
        case 6:
            Console.WriteLine("Ingresar un numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;

            if(numA == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacion = numA*numA;
            OperacionTexto = null;
        break;
        case 7:
            Console.WriteLine("Ingresar un numero");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;

            if(numA == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacionDouble = Math.Sqrt(numA);
            OperacionTexto = null;
        break;
        case 8:
            Console.WriteLine("Ingresar un grado");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;

            if(numA == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            radianes = numA*(Math.PI / 180);
            resultOperacionDouble = Math.Sin(radianes);
            OperacionTexto = null;
        break;
        case 9:
            Console.WriteLine("Ingresar un grado");
            numA = int.TryParse(Console.ReadLine(), out numA) ? numA : -1;

            if(numA == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            radianes = numA*(Math.PI / 180);
            resultOperacionDouble = Math.Cos(radianes);
            OperacionTexto = null;
        break;
        case 10:
            Console.WriteLine("Ingresar un numero flotante");
            numFloat = float.TryParse(Console.ReadLine(), out numFloat) ? numFloat : -1;

            if(numFloat == -1) {
                Console.WriteLine("Ingrese un numero valido");
                return;
            }

            resultOperacion = (int)Math.Floor(numFloat);
            OperacionTexto = null;
        break;
        default:
            Console.WriteLine("Ingrese una opcion valida");
            return;
        
    }

    if(opcionMenu == 7 || opcionMenu == 8 || opcionMenu == 9) {
        Console.WriteLine("Resultado operacion: "+resultOperacionDouble);    
    } else {
        if(OperacionTexto != null ) { //Adaptacion por Ejercicio 4
            Console.WriteLine($"{OperacionTexto} de {numA} y de {numB} es igual a: "+resultOperacion);
        } else {
            Console.WriteLine("Resultado operacion: "+resultOperacion);    
        }
        
    }
    
    Console.WriteLine("Desea realizar otra operacion? si = 1, no = 0");
    ejecutar = int.TryParse(Console.ReadLine(), out ejecutar) ? ejecutar : 0;
}

Console.WriteLine("Ingrese un numero");
int num1 = int.TryParse(Console.ReadLine(), out num1) ? num1: -1;
Console.WriteLine("Ingrese un numero");
int num2 = int.TryParse(Console.ReadLine(), out num2) ? num2: -1;

if(num1 == -1 || num2 == -1) {
    Console.WriteLine("Ingrese un numero valido");
    return;
}

if(num1>num2) {
    Console.WriteLine("El maximo numero es:" + num1);
} 

if(num2>num1) {
    Console.WriteLine("El maximo numero es:" + num2);
} 

if(num1<num2) {
    Console.WriteLine("El minimo numero es:" + num1);
} 

if(num2<num1) {
    Console.WriteLine("El minimo numero es:" + num2);
} */


//Ejercicio 4
Console.WriteLine("Ingrese una cadena");
string ?cadena = Console.ReadLine();


if(cadena != null) {
    Console.WriteLine($"Longitud de texto: {cadena.Length}");
} else {
    Console.WriteLine($"Longitud de texto: 0");
}

Console.WriteLine("Ingrese una segunda cadena");
string ?cadena2 = Console.ReadLine();
Console.WriteLine($"Cadenas concatenadas: {cadena} {cadena2}");

if(cadena2 != null) {//por ej ingresar: Programador Universitario
    var subcadena = cadena2.Substring(12);
    Console.WriteLine("Substring: "+subcadena);//Universitario
}

Console.WriteLine("Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla: ");

if(cadena != null) {

    foreach (char c in cadena) {
        Console.WriteLine(c);
    }
    
    Console.WriteLine("Ingrese una busqueda");
    string ?textoBusqueda = Console.ReadLine();
    //Buscando en cadena
    int indice = cadena.IndexOf(textoBusqueda);
    if(indice >=0) {
        Console.WriteLine("La cadena se encontro a partir del indice : "+indice);
    }

    //convirtiendo a mayuscula
    Console.WriteLine("Convertido a mayuscula: "+cadena.ToUpper());
    //convirtiendo a minuscula
    Console.WriteLine("Convertido a minuscula: "+cadena.ToLower());
    //Ingresar cadena con caracteres para usar split
    Console.WriteLine("Ingresar cadena con caracter para usar split");
    cadena = Console.ReadLine();
    //para que este codigo funcione necesitamos ingresar una cadena con el caracter ,
    Console.WriteLine("recorremos el arreglo que devuelve la funcion split:");
    foreach(string item in cadena.Split(",")){
        Console.WriteLine(item);
    }

    Console.WriteLine("Ingrese una ecuacion, para este caso ingrese una cadena de ecuacion suma");//ej:34+2
    string ?ecuacion = Console.ReadLine();
    int indexOperador = ecuacion.IndexOf('+');
    
    int primerNum = int.TryParse(ecuacion.Substring(0, indexOperador), out primerNum) ? primerNum: 0;
    int segundoNum = int.TryParse(ecuacion.Substring(indexOperador+1), out segundoNum) ? segundoNum: 0;
    int resultado = primerNum+segundoNum;
    Console.WriteLine("Resultado: "+ resultado);

    

    

}

