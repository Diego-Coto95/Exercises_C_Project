using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipos de datos*/
            //short a = -20;
            //int b = -40000;
            //long c = -1000000000000000;
            //double d = 1489.67;
            //float e = 30.6f;
            //char digito ='a';
            //string digito2 = "Hola mundo";

            //bool exito = false;

            /* Para convertir de string a int*/
            //string numero = "20";
            //int numCobvert = int.Parse(numero);
            //int resultado = numCobvert + 10;

            /* Para convertir de int a string*/
            //int g = 30;
            //string numero = g.ToString();
            /*----------------------------------------------------*/

            /*Primer Programa (Suma normal)*/

            //Console.WriteLine("Ingrese numero 1");
            //string numero1 = Console.ReadLine();
            //Console.WriteLine("El numero ingresado es "+ numero1);
            //Console.WriteLine("Ingrese numero 2");
            //string numero2 = Console.ReadLine();
            //Console.WriteLine("El numero ingresado es " + numero2);
            //int result = int.Parse(numero1) + int.Parse(numero2);
            //Console.WriteLine("La suma de los numeros es: " + result);
            //Console.ReadLine();
            /*----------------------------------------------------*/

            /*Segundo Programan (Area de un triangulo)*/

            //Console.WriteLine("Ingrese base");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese altura");
            //int alt = int.Parse(Console.ReadLine());
            //int result = bas * alt /2;
            //Console.WriteLine("El resultado es: "+ result);
            //Console.ReadLine();
            /*----------------------------------------------------*/

            /*Tercer Programan (Porcentaje)*/

            //Console.WriteLine("Ingrese precio");
            //float price = float.Parse(Console.ReadLine());
            //float desc = price * 0.20f;
            //float total = price - desc;
            //Console.WriteLine("El resultado es: " + total);
            //Console.ReadLine();
            /*----------------------------------------------------*/

            /*Tarea 1 (Ejercicios)*/

            //Console.WriteLine("Ingrese # de semanas");
            //int dias = int.Parse(Console.ReadLine())*7;
            //Console.WriteLine("El numero de dias son: "+dias);
            //Console.ReadLine();

            /*----------------------------------------------------*/

            //Console.WriteLine("Ingrese # de horas del empleado");
            //int sueldo = int.Parse(Console.ReadLine())*20;
            //Console.WriteLine("El resultado es: "+sueldo);
            //Console.ReadLine();
            /*----------------------------------------------------*/

            //Console.WriteLine("Ingrese precio del producto");
            //int precio = int.Parse(Console.ReadLine());
            //float IGV = precio * 0.18f;
            //float total = precio + IGV;
            //Console.WriteLine("IGV: " + total);
            //Console.WriteLine("El total es: " + total);
            //Console.ReadLine();

            /*----------------------------------------------------*/

            /*IF*/

            //int a = 20;
            //int b = 30;

            ////if (a > b)
            ////{
            ////    Console.WriteLine("A es mayor a B");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("B es mayor a A");
            ////}

            //if (a.Equals(b))
            //{
            //    Console.WriteLine("A es igual a B");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}
            //Console.ReadLine();

            /*----------------------------------------------------*/

            /*Cuarto Programa (Calcula edad)*/

            //Console.WriteLine("Ingrese edad");
            //int edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //    Console.WriteLine("La persona es mayor de edad");
            //else
            //    Console.WriteLine("La persona es menor");
            //Console.ReadLine();

            /*----------------------------------------------------*/

            /*Quinto Programa (Calcula descuento)*/

            //Console.WriteLine("Ingrese total de la venta");
            //int precio = int.Parse(Console.ReadLine());
            //float des;
            //float total;

            //if (precio >= 500)
            //{
            //    des = precio * 0.20f;
            //    total = precio - des;
            //    Console.WriteLine("Descuento: " + des);
            //    Console.WriteLine("El total es: " + total);
            //}
            //else
            //    des = precio * 0.10f;
            //    total = precio - des;
            //    Console.WriteLine("Descuento: " + des);
            //    Console.WriteLine("El total es: " + total);

            //Console.ReadLine();

            /*----------------------------------------------------*/
            /*Sexto Programa (Calcula par o impar)*/

            //Console.WriteLine("Ingrese numero");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //    Console.WriteLine("El numero es par");
            //else
            //    Console.WriteLine("El numero es impar");

            //Console.ReadLine();

            /*----------------------------------------------------*/
            /*Septimo Programa (Categoria IF ANIDADO)*/

            //Console.WriteLine("Ingrese nota");
            //char nota = char.Parse(Console.ReadLine());
            //if (nota.Equals('A'))
            //{
            //    Console.WriteLine("El usuario aprobo");
            //}
            //else if (nota.Equals('B'))
            //{
            //    Console.WriteLine("El usuario necesita reforzamiento");
            //}
            //else if (nota.Equals('C'))
            //{
            //    Console.WriteLine("El usuario desaprobo");
            //}
            //else
            //    Console.WriteLine("Error, ingrese un dato valido");

            //Console.ReadLine();
            /*----------------------------------------------------*/
            /*Septimo Programa (Categoria SWITCH)*/

            //Console.WriteLine("Ingrese nota");
            //char nota = char.Parse(Console.ReadLine());

            //switch (nota)
            //{
            //    case 'A': Console.WriteLine("El usuario aprobo"); break;
            //    case 'B': Console.WriteLine("El usuario necesita reforzamiento"); break;
            //    case 'C': Console.WriteLine("El usuario desaprobo"); break;
            //    default:  Console.WriteLine("Error, ingrese un dato valido"); break;
            //}

            //Console.ReadLine();

            /*----------------------------------------------------*/
            /*Septimo Programa (Categoria SWITCH)*/

            //Console.WriteLine("Ingrese numero");
            //int numero = int.Parse(Console.ReadLine());

            //switch (numero)
            //{
            //    case 1: Console.WriteLine("Lunes"); break;
            //    case 2: Console.WriteLine("Martes"); break;
            //    case 3: Console.WriteLine("Miercoles"); break;
            //    case 4: Console.WriteLine("Jueves"); break;
            //    case 5: Console.WriteLine("Viernes"); break;
            //    case 6: Console.WriteLine("Sabado"); break;
            //    case 7: Console.WriteLine("Domingo"); break;
            //    default: Console.WriteLine("Error, ingrese un dato valido"); break;
            //}

            //Console.ReadLine();
            /*----------------------------------------------------*/
            /*Octavo Programa (Categoria SWITCH)*/

            //Console.WriteLine("Ingrese sueldo");
            //int sueldo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese Categoria");
            //char categoria = char.Parse(Console.ReadLine());
            //int total,aumento;
            //switch (categoria)
            //{
            //    case 'A': aumento = 500 ; break;
            //    case 'B': aumento = 300; break;
            //    case 'C': aumento = 100; break;
            //    default: aumento = 10; break;

            //}

            //total = sueldo + aumento;
            //Console.WriteLine("El sueldo total es: "+total);

            //Console.ReadLine();
            /*----------------------------------------------------*/

            /*Tarea2*/
            //Console.WriteLine("Ingrese #");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 5 == 0)
            //    Console.WriteLine("El " + num + " es muliplo de 5.");
            //else
            //    Console.WriteLine("El " + num + " no es muliplo de 5.");
            //Console.ReadLine();

            /*-----------------------*/
            //Console.WriteLine("Ingrese las horas laboradas del trabajador");
            //int horas = int.Parse(Console.ReadLine());
            //int total;
            //if (horas < 30)
            //    Console.WriteLine("El trabajador ganaria: " + horas * 10);
            //else if (horas >= 30)
            //    Console.WriteLine("El trabajador ganaria: " + horas * 20);

            //Console.ReadLine();
            /*-----------------------*/
            //Console.WriteLine("Ingrese primer #");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese segundo #");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese operacion a realizar");
            //char simbolo = char.Parse(Console.ReadLine());

            //switch (simbolo)
            //{
            //    case '+': Console.WriteLine("El resultado es: " + (num1 + num2)); break;
            //    case '-': Console.WriteLine("El resultado es: " + (num1 - num2)); break;
            //    case '*': Console.WriteLine("El resultado es: " + (num1 * num2)); break;
            //    case '/': Console.WriteLine("El resultado es: " + (num1 / num2)); break;
            //    default: Console.WriteLine("Ingrese un simbolo permitido (+, -, *, /)");break;
            //}

            //Console.ReadLine();
            /*----------------------------------------------------*/

            /*Acumuladores*/
            //int c = 21; 
            //c--;
            //c++;
            //c += 10;
            //c -= 10;
            //Console.WriteLine("El valor de C es: " + c);
            //Console.ReadLine();

            /*----------------------------------------------------*/
            /*Estrucuturas repetitivas*/
            //WHILE

            /*
             while(condicion){
                --INSTRUCCIONES 
            }
             */
            //int i = 1;
            //int total = 0;
            //while (i<=5)
            //{
            //    Console.WriteLine("Ingrese # "+i);
            //    int num = int.Parse(Console.ReadLine());
            //    total += num;
            //    i++;
            //}
            //Console.WriteLine("La suma es: "+total);
            //Console.ReadLine();
            /*----------------------------------------------------*/
            /*Tarea 3*/

            //int i = 19;
            //while (i<=37)
            //{
            //    Console.WriteLine(i);
            //    i +=2;
            //}
            //Console.ReadLine();
            /*-----------------------*/

            //float result;
            //int num,i = 1;
            //do
            //{
            //    Console.WriteLine("Ingrese #");
            //    num= int.Parse(Console.ReadLine());
            //    result = num / 2;
            //    Console.WritesLine("Resultado: "+result);
            //    i++;
            //}
            //while (num >= 0 );
            //Console.WriteLine("Finalizado");
            //Console.ReadLine();
            /*-----------------------*/
            //int total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine("El total es: " + total);
            //Console.ReadLine();
            /*-----------------------*/
            /*Arrays*/

            int[] numeros = { 1, 51, 1, 5187, 4, 45, 4, 78, 84, 5 };

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
            /*----------------------------------------------------*/

            /*----------------------------------------------------*/
            /*----------------------------------------------------*/

            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            /*----------------------------------------------------*/
            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
