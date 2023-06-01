# Ejercicio 4.

## ¿String es un tipo por valor o un tipo por referencia?

El tipo `string` es un tipo por referencia en c#. 

## ¿Qué secuencias de escape tiene el tipo string?








- `\"` comilla doble en una cadena.
- `\'` comilla simple en una cadena.
- `\\` barra invertida en una cadena.
- `\n` salto de linea.
- `\r` retorno de carro.
- `\t` tabulador en una cadena.
- `\b` retroceso.
- `\f` un avance de página.
## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Al utilizar el carácter @ antes de una cadena de texto cualquier secuencia de escape no tiene efecto sobre el texto, la cadena se interpreta de forma literal y es útil cuando se desea incluir una ruta de archivo por ejemplo:
```csharp 
string filePath = @"C:\Directorio\archivo.txt";
```


Al utilizar el carácter `$` antes de una cadena de texto, se habilita la interpolación de cadenas, lo que permite la inclusión de expresiones dentro de la cadena utilizando la sintaxis `${expresion}`. Por ejemplo:
```csharp 
string nombre = "Julio Altamiranda";

string mensaje = $"Hola, mi nombre es {nombre}.";
```
