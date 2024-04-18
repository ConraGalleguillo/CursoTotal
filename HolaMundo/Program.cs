using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Runtime.InteropServices;

namespace HolaMundo
{
    //internal class Program
    //{
    //static void Main(string[] args)
    //{
    //Console.WriteLine("1");
    //Console.WriteLine("2");
    //Console.WriteLine("3");
    //Console.WriteLine("4");
    //Console.WriteLine("5");
    //Console.WriteLine("6");
    //Console.ReadKey();

    //-----------------------------------------------------------

    //int numeroLibros, librosNinos, librosMatematicas;

    //double promedioFinal = 9.8;

    //int numeroLibros = 500;
    //float promedioExamenes = 8.5f;
    //Console.WriteLine("El predio de la camisa es: {0} y su color es: {1}", numeroLibros, promedioExamenes);

    //Console.Write(54534 % 34324); Console.WriteLine(" Hola como te va");
    //Console.ReadLine();

    //------------------------------------------------------------------------------------------------------------

    //string entrada;
    //int num1 = 5, num2, resultado;
    //Console.Write("Introduce num para sumarlo: ");
    ////Se le asigna a la variable de tipo string "entrada"
    //entrada = Console.ReadLine();

    ////Convertimos la cadena a tipo int
    //num2 = Convert.ToInt32(entrada);
    ////num2 = Int32.Parse(entrada);

    //resultado = num1 + num2;

    ////Resultado
    //Console.WriteLine("El resultado es: {0}", resultado);

    //---------------------------------------------------------

    //int num1 = 5, num2, resultado;
    //Console.Write("Introduce num para sumarlo: ");

    //num2 = Convert.ToInt32(Console.ReadLine());

    //resultado = num1 + num2;

    ////Resultado
    //Console.WriteLine("El resultado es: {0}", resultado);

    //----------------------------------------------------------

    //double altura, ancho, area, perimetro;
    //Console.Write("Dame la altura: ");
    //altura = Convert.ToDouble(Console.ReadLine());

    //Console.Write("Dame el ancho: ");
    //ancho = Convert.ToDouble(Console.ReadLine());

    //area = altura * ancho;

    //perimetro = 2 * (altura + ancho);
    //Console.WriteLine("El area es: {0}, y el perimetro es: {1}", area, perimetro);

    //---------------------------------------------------------------------------------

    //double A, B, C;
    //Console.WriteLine("Dame el lado A: ");
    //A = Convert.ToDouble(Console.ReadLine());

    //Console.WriteLine("Dame el lado B: ");
    //B = Convert.ToDouble(Console.ReadLine());

    //Console.WriteLine("Dame el lado C: ");
    //C = Convert.ToDouble(Console.ReadLine());

    //double Perimetro = (A + B + C);
    //Console.WriteLine("El perimetro es de: {0}", Perimetro);

    //--------------------------------------------------------

    //double celsius;
    //Console.Write("Introduce los grados celsius: ");
    //celsius = Convert.ToDouble(Console.ReadLine());

    //double farenheit = (celsius * 9 / 5 + 32);
    //Console.WriteLine("La temperatura en Farenheit es de: {0}", farenheit);

    //---------------------------------------------------------------------
    //double numero;
    //Console.Write("Dame el número: ");
    //numero = Convert.ToDouble(Console.ReadLine());

    //if (numero > 0)
    //    Console.WriteLine("El número es positivo");
    //if (numero < 0)
    //    Console.WriteLine("El número es negativo");

    //----------------------------------------------------------------------

    //byte edad;

    //Console.Write("¿Qué edad tienes?: ");
    //edad = Convert.ToByte(Console.ReadLine());

    //if (edad >= 18)
    //    Console.WriteLine("Eres mayor de edad");
    //else
    //    Console.WriteLine("Eres menor de edad");

    //-----------------------------------------------------------------------

    ////Variables
    //decimal num1, num2, resultado = 0;
    //byte opcion;

    ////Mostramos el menú
    //Console.WriteLine("1. Suma");
    //Console.WriteLine("2. Resta");
    //Console.WriteLine("3. Multiplicación");
    //Console.WriteLine("4. División");

    ////Pedimos al usuario que escoja una opción
    //Console.Write("Elegí una opción: ");
    //opcion = Convert.ToByte(Console.ReadLine());

    ////Pedimos el primer número
    //Console.Write("Dame el primer número: ");
    //num1 = Convert.ToDecimal(Console.ReadLine());

    ////Pedimos el segundo número
    //Console.Write("Dame el segundo número: ");
    //num2 = Convert.ToDecimal(Console.ReadLine());

    ////Suma
    //if (opcion == 1)
    //    resultado = num1 + num2;
    ////Resta
    //if (opcion == 2)
    //    resultado = num1 - num2;
    ////Multiplicación
    //if (opcion == 3)
    //    resultado = num1 * num2;
    ////División
    //if (opcion == 4)
    //    if (num2 != 0)
    //        resultado = num1 / num2;
    //    else
    //        Console.WriteLine("No se puede dividir entre 0");

    ////Mostramos el Resultado
    //Console.WriteLine("El resultado es: {0}", resultado);

    //--------------------------------------------------------------------------

    //byte opcion;
    //Console.Write("Cuantos años tenés?: ");
    //opcion = Convert.ToByte(Console.ReadLine());
    //if (opcion == 21)
    //    Console.WriteLine("En el culo te la hundo");
    //else
    //        if (opcion >= 18)
    //            Console.WriteLine("Sos mayor de edad");
    //        else
    //            if (opcion >= 89)
    //                Console.WriteLine("Sos una vieja de mierda");
    //            else
    //                Console.WriteLine("No sos tan vieja chota");

    //---------------------------------------------------------------------------

    ////Variables
    //decimal num1, num2, resultado = 0;
    //byte opcion;

    ////Mostramos el menú
    //Console.WriteLine("1. Suma");
    //Console.WriteLine("2. Resta");
    //Console.WriteLine("3. Multiplicación");
    //Console.WriteLine("4. División");

    ////Pedimos al usuario que escoja una opción
    //Console.Write("Elegí una opción: ");
    //opcion = Convert.ToByte(Console.ReadLine());

    ////Pedimos el primer número
    //Console.Write("Dame el primer número: ");
    //num1 = Convert.ToDecimal(Console.ReadLine());

    ////Pedimos el segundo número
    //Console.Write("Dame el segundo número: ");
    //num2 = Convert.ToDecimal(Console.ReadLine());

    ////Suma
    //if (opcion == 1)
    //    resultado = num1 + num2;
    //else
    //    if (opcion == 2)
    //        resultado = num1 - num2;
    //    else
    //        if (opcion == 3)
    //            resultado = num1 * num2;
    //        else
    //            if(opcion == 4)
    //                if (num2 != 0)
    //                    resultado = num1 / num2;
    //                else
    //                    Console.WriteLine("No se puede dividir entre 0");

    ////Mostramos el Resultado
    //Console.WriteLine("El resultado es: {0}", resultado);

    //------------------------------------------------------------------------------

    //// Uso de !
    //bool bateria;
    //Console.Write("Hay bateria?: ");
    //bateria = Convert.ToBoolean(Console.ReadLine());

    //if (!(bateria == true))
    //    Console.WriteLine("Conecta el celular");
    //else
    //    Console.WriteLine("No conectes el celular");

    //------------------------------------------------------------------------------

    ////Uso de &&
    //bool p, q;
    //q = true;
    //p = true;
    //Console.WriteLine(p && q);

    //bool w, o;
    //w = true;
    //o = false;
    //Console.WriteLine(w && o);


    ////Ej de Licencia de Conducir
    //byte edad;
    //Console.Write("Cuantos años tienes?: ");
    //edad = Convert.ToByte(Console.ReadLine());

    //bool licencia;
    //Console.Write("Tienes licencia?: ");
    //licencia = Convert.ToBoolean(Console.ReadLine());

    //if (edad >= 18 && licencia == true)
    //    Console.WriteLine("Puedes conducir");
    //else
    //    Console.WriteLine("No puedes conducir");

    //-------------------------------------------------------------------------------

    ////Uso del ||
    //bool p, q;
    //p = true;
    //q = false;
    //Console.WriteLine(p || q);


    ////Ej de Beca
    //float promsecundario, examen;

    //Console.Write("Promedio final del secundario: ");
    //promsecundario = Convert.ToSingle(Console.ReadLine());

    //Console.Write("Nota del exámen: ");
    //examen = Convert.ToSingle(Console.ReadLine());

    //if (promsecundario >= 9.5 || examen >= 7.5)
    //    Console.WriteLine("Beca");
    //else
    //    Console.WriteLine("No Beca");

    //-----------------------------------------------------------------------------------------------------------------------------

    ////Combinación && || en ejemplo de propulsor
    //float energia;
    //bool propizq, propder;

    //Console.Write("Indroduce la energía: ");
    //energia = Convert.ToSingle(Console.ReadLine());

    //Console.Write("El prop izq funciona bien?: ");
    //propizq = Convert.ToBoolean(Console.ReadLine());

    //Console.Write("El prop der funciona bien?: ");
    //propder = Convert.ToBoolean(Console.ReadLine());

    //if (((((propizq) && (propder)) == true) && (energia >= 75)) || ((((propder) || (propizq)) == true) && (energia == 100)))
    //    Console.WriteLine("Podés despegar");
    //else
    //    Console.WriteLine("No podés despegar");

    //------------------------------------------------------------------------------------------------------------------------------

    ////Uso de Switch
    //string color;
    //Console.Write("Ingresa el RGB para ver su código: ");
    //color = Console.ReadLine();

    //switch (color)
    //{
    //    case "Red":
    //    case "red":
    //    case "RED":
    //        Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
    //        break;
    //    case "Green":
    //        Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
    //        break;
    //    case "Blue":
    //        Console.WriteLine("El código RGB para {0} es: 0, 0, 255", color);
    //        break;
    //    default:
    //        Console.WriteLine("No hay registro para {0}", color);
    //        break;

    //------------------------------------------------------------------------------------------------------------------------------

    //Variables
    //decimal num1, num2, resultado = 0;
    //byte opcion;

    //Mostramos el menú
    //Console.WriteLine("1. Suma");
    //Console.WriteLine("2. Resta");
    //Console.WriteLine("3. Multiplicación");
    //Console.WriteLine("4. División");

    //Pedimos al usuario que escoja una opción
    //Console.Write("Elegí una opción: ");
    //opcion = Convert.ToByte(Console.ReadLine());

    //Pedimos el primer número
    //Console.Write("Dame el primer número: ");
    //num1 = Convert.ToDecimal(Console.ReadLine());

    //Pedimos el segundo número
    //Console.Write("Dame el segundo número: ");
    //num2 = Convert.ToDecimal(Console.ReadLine());

    //Suma
    //switch (opcion)
    //{
    //    case 1:
    //        Console.WriteLine(num1 + num2);
    //        break;
    //    case 2:
    //        Console.WriteLine(num1 - num2);
    //        break;
    //    case 3:
    //        Console.WriteLine(num1 * num2);
    //        break;
    //    case 4:
    //        if (num2 != 0)
    //            Console.WriteLine(num1 / num2);
    //        else
    //            Console.WriteLine("No es posible dividir entre cero");
    //        break;
    //    default:
    //        Console.WriteLine("Ingresa una opción valida: ");
    //        break;
    //}
    //Mostramos el Resultado
    //Console.WriteLine("El resultado es: {0}", resultado);

    //----------------------------------------------------------------------------------------------------------------------------

    ////TAREA#3
    //byte mes;

    //Console.Write("Ingrese un número de mes: ");
    //mes = Convert.ToByte(Console.ReadLine());

    //switch (mes) 
    //{
    //    case 1:
    //        Console.WriteLine("Enero");
    //        break;
    //    case 2:
    //        Console.WriteLine("Febrero");
    //        break;
    //    case 3:
    //        Console.WriteLine("Marzo");
    //        break;
    //    case 4:
    //        Console.WriteLine("Abril");
    //        break;
    //    case 5:
    //        Console.WriteLine("Mayo");
    //        break;
    //    case 6:
    //        Console.WriteLine("Junio");
    //        break;
    //    case 7:
    //        Console.WriteLine("Julio");
    //        break;
    //    case 8:
    //        Console.WriteLine("Agosto");
    //        break;
    //    case 9:
    //        Console.WriteLine("Septiembre");
    //        break;
    //    case 10:
    //        Console.WriteLine("Octubre");
    //        break;
    //    case 11:
    //        Console.WriteLine("Noviembre");
    //        break;
    //    case 12:
    //        Console.WriteLine("Diciembre");
    //        break;
    //    default:
    //        Console.WriteLine("Ingrese un número apropiado");
    //        break;

    //}
    //-----
    //long num;
    //long resto;

    //Console.Write("Ingrese un número: ");
    //num = Convert.ToInt32(Console.ReadLine());
    //resto = num % 2;

    //if (resto == 0)
    //    Console.WriteLine("El número es par");
    //else
    //    Console.WriteLine("El número es impar");
    //-----
    //long tiempo;        

    //Console.Write("Ingrese cuanto tiempo desea estar (en minutos)(mín. 60 minutos): ");
    //tiempo = Convert.ToInt64(Console.ReadLine());

    //if (tiempo >= 60 && tiempo < 120)
    //    Console.WriteLine("Debe pagar $5");
    //else
    //    if (tiempo == 120)
    //    Console.WriteLine("Debe pagar $15");
    //    else
    //        if (tiempo > 120)
    //        Console.WriteLine("Debe pagar $40");
    //-------------------------------------------------------------------------------------------------------------------------
    //SECCIÓN 4
    //-------------------------------------------------------------------------------------------------------------------------

    ////Operando con incremento
    //int i;

    //i = 10;

    //Console.WriteLine("Valor inicial del operando {0}", i);

    //Console.WriteLine("Valor con incremento del operando {0}", i);

    ////Operando con decremento

    //Console.WriteLine("Valor con decremento del operando {0}", --i);

    //-------------------------------------------------------------------------------------------------------------------------


    //double c1, c2, c3, promedio;

    //Console.Write("Calificación del primer alumno: ");
    //c1 = Convert.ToDouble(Console.ReadLine());

    //Console.Write("Calificación del segundo alumno: ");
    //c2 = Convert.ToDouble(Console.ReadLine());

    //Console.Write("Calificación del tercer alumno: ");
    //c3 = Convert.ToDouble(Console.ReadLine());

    //promedio = ((c1 + c2 + c3) / 3);
    //Console.WriteLine("El promedio es de: {0}", promedio);

    //---------------------------------------------------------------------------------------------------------------------------

    //Variable de bucle (o de control)
    //int i;

    //for ( i = 2; i <= 10; i++) //inicializador; condicion; itinerador
    //{
    //    //código a repetirse
    //    Console.WriteLine(i);
    //}

    //Inicializador (Instruccion de asignación o declaración o inicialización de una variable de control)
    //for (i = 3, Console.WriteLine ("Valor de la variable inicial: {0}", i); i <= 10; i++, Console.WriteLine("Valor de salida: {0}", i)) // o += en iterador(asignacion compuesta)
    //{
    //   Console.WriteLine(i);
    //}

    //---------------------------------------------------------------------------------------------------------------------------

    //Uso de contador
    //int i;
    //int contador = 0;

    //for (i = 0; i <= 20; i+= 2) 
    //{
    //    contador++;
    //    Console.WriteLine("Número del ciclo número {0}, {1}", i, contador);

    //}

    //Console.WriteLine("La vuelta de ciclo es: {0}", contador);

    //---------------------------------------------------------------------------------------------------------------------------

    ////Uso de acumulador

    //int i;
    //int acumulador = 0;
    //int precio;

    //for (i = 0; i <= 5; i++)
    //{
    //    Console.Write("Ingresa el precio del producto; ");
    //    precio= Convert.ToInt32(Console.ReadLine());

    //    acumulador += precio;

    //}

    //Console.WriteLine("El total es: {0}", acumulador);

    //----------------------------------------------------------------------------------------------------------------------------

    ///*Ejercicio con for*/

    //byte i, numAlumnos;
    //double calificacion, sumaCali = 0, promedio;

    //Console.Write("Ingrese el número de alumnos: ");
    //numAlumnos = Convert.ToByte(Console.ReadLine());

    //for (i = 1; i <= numAlumnos; i += 1)
    //{
    //    Console.Write("Ingresa la calificacion: ");
    //    calificacion = Convert.ToDouble(Console.ReadLine());

    //    sumaCali += calificacion;
    //}

    //promedio = sumaCali / numAlumnos;

    //Console.WriteLine("El promedio del curso es de: {0}", promedio);

    //------------------------------------------------------------------------------------------------------------------------------

    //// Ejercicio con for - Factorial

    //ulong factorial = 1, i, numero;

    //Console.Write("Ingresa el número para calcular su factorial: ");
    //numero = Convert.ToUInt64(Console.ReadLine());

    //for (i = numero; i >= 1; i -= 1)
    //{
    //    factorial = factorial * i;
    //}

    //Console.WriteLine("El factorial de {0}, es {1}", numero, factorial);

    //------------------------------------------------------------------------------------------------------------------------------

    //byte numero = 1;

    //while (numero <=10)
    //{
    //    Console.WriteLine(numero);
    //    numero += 1;
    //}

    //Ejercicio de contraseñas

    //string contraseña1, contraseña2 = "";

    //Console.Write("Escribe tu contraseña: ");
    //contraseña1 = Console.ReadLine();

    //while (contraseña1 != contraseña2)
    //{
    //    Console.Write("Confirma tu contraseña: ");
    //    contraseña2 = Console.ReadLine();
    //}

    //Console.WriteLine("Contraseña Guardada");

    //-------------------------------------------------------------------------------------------------------------------------------

    ////Do-While

    //int i = 15;

    //do
    //{
    //    Console.WriteLine(i);
    //    i++;
    //}
    //while (i <= 10);

    //--------------------------------------------------------------------------------------------------------------------------------

    ////Ejercicio con do

    //decimal num1, num2, resultado = 0;
    //byte opcion;
    //decimal i;

    //do
    //{
    //    Console.WriteLine("1. Suma");
    //    Console.WriteLine("2. Resta");
    //    Console.WriteLine("3. Multiplicación");
    //    Console.WriteLine("4. División");
    //    Console.WriteLine("5. Factorial");

    //    //Pedimos una opción
    //    Console.Write("Escoge una opción: ");
    //    opcion = Convert.ToByte(Console.ReadLine());
    //}
    //while ((opcion < 1) || (opcion > 5));

    //Console.Write("Dame el primer número: ");
    //num1 = Convert.ToDecimal(Console.ReadLine());

    //if (opcion < 5)
    //{
    //    Console.Write("Dame el segundo número: ");
    //    num2 = Convert.ToDecimal(Console.ReadLine());
    //}
    //else
    //{
    //    num2 = 0;
    //}
    ////Hacer la operación según la opción elegida
    //switch (opcion)
    //{
    //    case 1:
    //        resultado = num1 + num2;
    //        break;
    //    case 2:
    //        resultado = num2 - num1;
    //        break;
    //    case 3:
    //        resultado = num1 * num2;
    //        break;
    //    case 4:
    //        if (num2 != 0)
    //        {
    //            resultado = num1 / num2;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Divisor no válido");
    //        }
    //        break;
    //    case 5:
    //        resultado = 1;
    //        for (i = num1; i >= 1; i--)
    //        {
    //            resultado = resultado * i;
    //        }
    //        break;
    //}

    //Console.WriteLine("El resultado es: {0}", resultado);

    //-----------------------------------------------------------------------------------------------------------------

    ////Tablas matemáticas con for anidados

    //int i = 1;//Variable se encarga del bucle exterior
    //int j = 1; //Variable se encarga del bucle interior
    //int resultado = 0; //Guardar el valor de la multiplicación 


    //for (i = 1; i <=10; i++) //Buclke exterior
    //{
    //    Console.WriteLine("Tabla del {0}", i);

    //    for (j = 1; j <=10; j++) //Bucle interior
    //    {
    //        resultado = i * j;

    //        Console.WriteLine(" {0} * {1} = {2}", i, j, resultado);
    //    }
    //}

    //Console.ReadKey();

    //-----------------------------------------------------------------------------------------------------------------

    //int i;            
    //int numero;
    //int exponente, numMuestra = 1;
    //double resultado = 1, ResultadoNeg;           

    //Console.Write("Ingrese la base: ");
    //numero = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Ingrese el exponente: ");
    //exponente = Convert.ToInt32(Console.ReadLine());

    //if (exponente < 0)
    //{
    //    numMuestra = exponente;
    //    exponente *= -1;

    //    for (i = 1; i <= exponente; i++)
    //    {
    //        resultado *= numero;
    //    }

    //    Console.Write(resultado);

    //    ResultadoNeg = (1/resultado);

    //    Console.WriteLine("{0} ^ {1} = {2}", numero, numMuestra, ResultadoNeg);

    //}
    //else
    //{
    //    for (i = 1; i <= exponente; i++)
    //    {
    //        resultado *= numero;
    //    }                

    //    Console.WriteLine("{0} ^ {1} = {2}", numero, exponente, resultado);
    //}

    //--------------------------------------------------------------------------------------------------------------------

    ////Números primos
    //int numero, divisor, numDivisores = 0;

    //for (numero = 2; numero <= 100; numero++)
    //{
    //    for (divisor = 1; divisor <= numero; divisor++)
    //    {
    //        if (numero % divisor == 0)
    //        {
    //            numDivisores = numDivisores + 1;
    //        }
    //    }

    //    if (numDivisores <= 2)
    //    {
    //        Console.WriteLine(numero);
    //    }

    //    numDivisores = 0;
    //}

    //--------------------------------------------------------------------------------------------------------------------
    //SECCIÓN 5
    //--------------------------------------------------------------------------------------------------------------------

    //decimal num1, num2, resultado = 0;
    //byte opcion;
    //decimal i;
    //decimal num1Ar, num2Ar;

    //do
    //{
    //    Console.WriteLine("1. Suma");
    //    Console.WriteLine("2. Resta");
    //    Console.WriteLine("3. Multiplicación");
    //    Console.WriteLine("4. División");
    //    Console.WriteLine("5. Factorial");

    //    //Pedimos una opción
    //    Console.Write("Escoge una opción: ");
    //    opcion = Convert.ToByte(Console.ReadLine());
    //}
    //while ((opcion < 1) || (opcion > 5));


    //Console.Write("Dame el primer número: ");
    //num1 = Convert.ToDecimal(Console.ReadLine());

    //if (opcion < 5)
    //{
    //    Console.Write("Dame el segundo número: ");
    //    num2 = Convert.ToDecimal(Console.ReadLine());
    //}
    //else
    //{
    //    num2 = 0;
    //}
    //Hacer la operación según la opción elegida
    //switch (opcion)
    //{
    //    case 1:
    //        Suma();
    //        break;
    //    case 2:
    //        resultado = Restar();
    //        Console.WriteLine("El resultado es: {0}", resultado);
    //        break;
    //    case 3:
    //        num1Ar = IngresarNumero("Ingresa el primer número: ");
    //        num2Ar = IngresarNumero("Ingresa el segundo número: ");

    //        resultado = Multiplicar(num1Ar, num2Ar);

    //        Console.WriteLine("El resultado es: {0}", resultado);                   
    //        break;           
    //    case 4:
    //        num1Ar = IngresarNumero("Ingresa el primer número: ");
    //        num2Ar = IngresarNumero("Ingresa el segundo número: ");

    //        resultado = Dividir(num1Ar, num2Ar);

    //        Console.WriteLine("El resultado es: {0}", resultado);
    //        break;

    //}
    //    case 5:
    //        resultado = 1;
    //        for (i = num1; i >= 1; i--)
    //        {
    //            resultado = resultado * i;
    //        }
    //        break;
    //}

    //Console.WriteLine("El resultado es: {0}", resultado);

    //---------------------------------------------------------------------------------------------------------------------------------
    //SECCIÓN 5 - PASAR POR VALOR
    //---------------------------------------------------------------------------------------------------------------------------------

    //    byte numAr;
    //    string saludoAr;
    //    int numPrimoAr;

    //    Prueba(out numAr, out saludoAr, out numPrimoAr);

    //    Console.WriteLine(numAr);
    //    Console.WriteLine(saludoAr);
    //    Console.WriteLine(numPrimoAr);

    //----------------------------------------------------------------------------------------------------------------------------------

    //Función VAR - Variables locales con asignacion implícita de tipos

    //(string nombre, byte edad, long numero, int dirPostal) persona1 = ("Luis", 50, 5554664522848, 526846); //Campos
    //var persona2 = (nombre: "Luis",edad: 50,numero: 5554664522848,dirPostal: 526846);
    //Console.WriteLine(persona2);

    //Items
    //Console.WriteLine(persona1.edad);



    //static void Prueba(out byte numPa, out string saludoPa, out int numPrimoPa)
    //{
    //    numPa = 20;
    //    saludoPa = "Hola Mundo";
    //    numPrimoPa = 7;
    //}
    //--------------------------------------------------------------------------------------------------------------------
    //SECCIÓN 5
    //--------------------------------------------------------------------------------------------------------------------

    // [modificador] [tipo] [identificador] [parámetros]
    //static void Nombre()
    //{
    //    //Instrucciones            
    //}

    /*
     * 1. Métodos sin parámetros ni tipo
     * 2. Métodos con parámetros
     * 3. Métodos que devuelven un tipo
     * 4. Métodos con´parámetros y que devuelven u ntipo
     */

    //static void Suma()
    //{
    //    decimal num1, num2, resultado = 0;

    //    Console.Write("Dame el primer número: ");
    //    num1 = Convert.ToDecimal(Console.ReadLine());

    //    Console.Write("Dame el segundo número: ");
    //    num2 = Convert.ToDecimal(Console.ReadLine());

    //    resultado = num1 + num2;

    //    Console.WriteLine("El resultado es: {0}", resultado);
    //}

    //static decimal Restar()
    //{
    //    decimal num1, num2, resultado = 0;

    //    Console.Write("Dame el primer número: ");
    //    num1 = Convert.ToDecimal(Console.ReadLine());

    //    Console.Write("Dame el segundo número: ");
    //    num2 = Convert.ToDecimal(Console.ReadLine());

    //    resultado = num1 - num2;

    //    return resultado;
    //}

    //static decimal Multiplicar(decimal num1Pa, decimal num2Pa)
    //{
    //    decimal resultado;

    //    resultado = num1Pa * num2Pa;

    //    return resultado;

    //    //Console.WriteLine("El resultado es: {0}", resultado);
    //}

    //static decimal Dividir(decimal num1Pa, decimal num2Pa)
    //{
    //    decimal resultado = 0;

    //    if (num2Pa != 0)
    //    {
    //        resultado = num1Pa / num2Pa;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Divisor no válido");
    //    }

    //    return resultado;
    //}   

    //static decimal IngresarNumero(string peticion)
    //{
    //    decimal numero;
    //    Console.Write(peticion);
    //    numero = Convert.ToDecimal(Console.ReadLine());

    //    return numero;
    //}

    //static void Main(string[] args)
    //{
    //    double grados = 0, resultadoFinal;


    //    resultadoFinal = Radianes(grados);

    //    Console.WriteLine("El equivalente es de {0} rads", resultadoFinal);

    //}

    //static double Radianes(double grados)
    //{

    //    double resultado;
    //    Console.Write("Dame el ángulo en grados: ");
    //    grados = Convert.ToDouble(Console.ReadLine());

    //    resultado = (grados * Math.PI) / 180;

    //    return resultado;
    //}
    //---------------------------------------------------------------------------------------------------------------------------------

    //MI EJ

    //----------------------------------------------------------------------------------------------------------------------------------
    //static void Main(string[] args)
    //{
    //    double opcion;

    //    Console.WriteLine("1. Cuadrado");
    //    Console.WriteLine("2. Triangulo");
    //    Console.WriteLine("3. Circulo");

    //    Console.Write("Elija una figura para calcular: ");
    //    opcion = Convert.ToDouble(Console.ReadLine());

    //    switch(opcion)
    //    {
    //        case 1:
    //            {
    //                double resultado; 
    //                resultado = Cuadrado();
    //                Console.WriteLine("El área es de {0} cm2", resultado);
    //                break;
    //            }
    //        case 2:
    //            {
    //                break;
    //            }
    //        case 3:
    //            {
    //                break;
    //            }
    //        default:
    //            {
    //                Console.WriteLine("Número no válido.");
    //                break;
    //            }

    //    }


    //}
    //static double Cuadrado()
    //{
    //    double baseCu, resultado;
    //    Console.Write("Escriba la base del cuadrado en cm: ");
    //    baseCu = Convert.ToDouble(Console.ReadLine());
    //    resultado = baseCu * baseCu;
    //    return resultado;

    //}
    ////static double Triangulo()
    //{

    //}
    ////static double Circulo()
    //{

    //}
    //----------------------------------------------------------------------------

    //EJ BIEN HECHO

    //----------------------------------------------------------------------------

    //static void Main(string[] args)
    //{
    //    //Variables
    //    double radioAr, baseAr, alturaAr, ladoAr, area;
    //    byte opcion;

    //    //Mostramos las opciones
    //    Console.WriteLine("1. Círculo");
    //    Console.WriteLine("2. Triangulo");
    //    Console.WriteLine("3. Cuadrado");

    //    //Preguntamos
    //    Console.Write("Escoge una opción y calcularé su área: ");
    //    opcion = Convert.ToByte(Console.ReadLine());

    //    switch (opcion)
    //    {
    //        case 1:
    //            Console.Write("Dame el valor del radio de tu círculo: ");
    //            radioAr = Convert.ToDouble(Console.ReadLine());

    //            //Invocamos al método
    //            area = Circulo(radioAr);

    //            //Mostramos el resultado
    //            Console.WriteLine("El área es: {0}", area);
    //            break;
    //        case 2:
    //            //Pedimos los valores de base y altura
    //            Console.Write("Dame el valor de la base de tu triangulo: ");
    //            baseAr = Convert.ToDouble(Console.ReadLine());

    //            Console.Write("Dame el valor de la altura de tu triangulo: ");
    //            alturaAr = Convert.ToDouble(Console.ReadLine());

    //            //Invocamos al método
    //            area = Triangulo(baseAr, alturaAr);

    //            //Mostramos el resultado
    //            Console.WriteLine("El área es: {0}", area);
    //            break;
    //        case 3:
    //            Console.Write("Dame el valor de uno de los lados de tu cuadrado: ");
    //            ladoAr = Convert.ToDouble(Console.ReadLine());

    //            area = Cuadrado(ladoAr);

    //            //Mostramos el resultado
    //            Console.WriteLine("El área es: {0}", area);
    //            break;
    //    }
    //}

    ////Método que calcula el área de un círculo
    //static double Circulo(double radioPa)
    //{
    //    double area;

    //    //Calcula el área
    //    area = Math.PI * (radioPa * radioPa);

    //    //Regresamos el valor de área
    //    return area;
    //}

    ////Método que calcula el área de un triangulo
    //static double Triangulo(double basePa, double alturaPa)
    //{
    //    double area;

    //    //Calcula el área
    //    area = (basePa * alturaPa) / 2;

    //    //Regresamos el valor de área
    //    return area;
    //}

    ////Método que calcula el área de un cuadrado
    //static double Cuadrado(double ladoPa)
    //{
    //    double area;

    //    //Calculamos el área
    //    area = ladoPa * ladoPa;

    //    //Regresamos el valor del área
    //    return area;
    //}
    //----------------------------------------------------------------------------------------------------------

    //SECCION 6

    //----------------------------------------------------------------------------------------------------------

    //static void Main(string[] args)
    //{
    //Array - (Elementros de la matriz (mismo tipo))

    //byte i, numAlumnos;
    //double calificacion, sumaCali = 0, promedio;

    //Console.Write("Ingrese el número de alumnos: ");
    //numAlumnos = Convert.ToByte(Console.ReadLine());

    //for (i = 1; i <= numAlumnos; i += 1)
    //{
    //    Console.Write("Ingresa la calificacion: ");
    //    calificacion = Convert.ToDouble(Console.ReadLine());

    //    sumaCali += calificacion;
    //}

    //promedio = sumaCali / numAlumnos;

    //Console.WriteLine("El promedio del curso es de: {0}", promedio);


    ////Declaración de matrices: tipo[] nombre = new tipo[tamaño];
    //double[] clasificaciones = new double[4] { 9, 10, 7.4, 6 };


    //string[] nombres = new string[3]; 

    //nombres[0] = "Sandra";
    //nombres[1] = "Pedro";
    //nombres[2] = "Carmen";

    //byte i; //Variable de control del ciclo

    //for (i = 0; i <= 2 ; i++)
    //{
    //    Console.WriteLine(nombres[i]);
    //}

    //_--------------------------------------------------------------------------------------
    ////Ej matrices unidimensionales

    ////Variables
    //byte i, numAlumnos;
    //double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

    ////Pedimos el número de alumnos
    //Console.Write("Ingrese el número de alumnos: ");
    //numAlumnos = Convert.ToByte(Console.ReadLine());

    ////Creación de la matriz
    //double[] calificaciones = new double[numAlumnos];

    ////For para pedir calificaciones
    //for (i = 0; i < numAlumnos; i++)
    //{
    //    //Pedimos la califiación
    //    Console.Write("Ingresa la califiación: ");
    //    calificaciones[i] = Convert.ToDouble(Console.ReadLine());


    //Acumulamos las califiaciones
    //sumaCalif += calificaciones[i];
    //}

    ////Calculamos el promedio
    //promedio = sumaCalif / numAlumnos;

    ////Calculamos la calificación mínima
    //for (i = 0; i < numAlumnos; i++)
    //{
    //    if (calificaciones[i] < califMin)
    //    {
    //        califMin = calificaciones[i];
    //    }
    //}

    ////Calculamos la califiación máxima
    //for (i = 0; i < numAlumnos; i++)
    //{
    //    if (calificaciones[i] > califMax)
    //    {
    //        califMax = calificaciones[i];
    //    }
    //}

    ////Mostramos los resultados
    //Console.WriteLine("El promedio es: {0}", promedio);
    //Console.WriteLine("La califiación mínima es: {0}", califMin);
    //Console.WriteLine("La califiación máxima es: {0}", califMax);

    //---------------------------------------------------------------------------------------------------
    //Multidimensional

    ////tipo[,] nombre = new tipo [filas, columnas]
    //double[,] ventas = new double[4,3];

    ////Declaración matriz de 3 dimensiones
    //double[,,] ventasAño = new double[4,3,3];

    //double[,] ventas = new double[4, 3]/*<=opcional*/ { { 100, 120, 205 }, { 115, 196, 300 }, { 157, 172, 245 }, { 130, 180, 281 } };
    //Console.WriteLine(ventas[3, 2]);

    //int[,,] matriz3D = new int[2, 2, 3] { { {1,2,3}, {4,5,6} }, { {7,8,9}, {10,11,12} } };

    //---------------------------------------------------------------------------------------------------------------------------------------

    //int i; //Variable de control de ciclo exterior
    //int j; //Variable de control de ciclo interior 

    //double[,] ventas = new double[4, 3]/*<=opcional*/ { { 100, 120, 205 }, 
    //                                                    { 115, 196, 300 }, 
    //                                                    { 157, 172, 245 }, 
    //                                                    { 130, 180, 281 } };

    //for (i = 0; i < 4; i++)
    //{
    //    Console.WriteLine("Fila {0}", i);
    //    for (j = 0; j < 3; j++)
    //    {
    //        Console.WriteLine(ventas[i, j]);
    //    }
    //}

    //-------------------------------------------------------------------------------------------------------------------------------

    //Ej de multidimensional
    ////Variables
    //byte i, j, numAlumnos, salones;
    //double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

    ////Pedimos el número de salones
    //Console.Write("Ingrese el número de salones: ");
    //salones = Convert.ToByte(Console.ReadLine());

    ////Pedimos el número de alumnos
    //Console.Write("Ingrese el número de alumnos por salón: ");
    //numAlumnos = Convert.ToByte(Console.ReadLine());

    ////Creación de la matriz
    //double[,] calificaciones = new double[salones, numAlumnos];

    ////For para pedir calificaciones
    //for (i = 0; i < salones; i++)
    //{
    //    Console.WriteLine("Salón {0}", i);
    //    for (j = 0; j < numAlumnos; j++)
    //    {
    //        //Pedimos la califiación
    //        Console.Write("Ingresa la calificación del alumno {0}: ", j);
    //        calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());

    //        //Acumulamos las califiaciones
    //        sumaCalif += calificaciones[i, j];
    //    }
    //}

    ////Calculamos el promedio
    //promedio = sumaCalif / (salones * numAlumnos);

    ////Calculamos la calificación mínima
    //for (i = 0; i < salones; i++)
    //{
    //    for (j = 0; j < numAlumnos; j++)
    //    {
    //        if (calificaciones[i, j] < califMin)
    //        {
    //            califMin = calificaciones[i, j];
    //        }
    //    }
    //}

    ////Calculamos la califiación máxima
    //for (i = 0; i < salones; i++)
    //{
    //    for (j = 0; j < numAlumnos; j++)
    //    {

    //        if (calificaciones[i, j] > califMax)
    //        {
    //            califMax = calificaciones[i, j];
    //        }
    //    }
    //}

    ////Mostramos los resultados
    //Console.WriteLine("El promedio es: {0}", promedio);
    //Console.WriteLine("La califiación mínima es: {0}", califMin);
    //Console.WriteLine("La califiación máxima es: {0}", califMax);

    //-------------------------------------------------------------------------------------------------------------------------------

    //jagged
    //tipo [][] nombre = new tipo [filas][];

    //double[][] ventas = new double[4][];

    //ventas[0] = new double[3]/*numero opcional*/ {155, 100, 170};
    //ventas[1] = new double[2]                    {205, 120};
    //ventas[2] = new double[4]                    {115, 190, 104, 130};
    //ventas[3] = new double[3]                    {163, 218, 125};

    //o

    //double[][] ventas =
    //{
    //    new double[] {155, 100, 170},
    //    new double[] {205, 120},
    //    new double[] {115, 190, 104, 130},
    //    new double[] {163, 218, 125}

    //};

    //------------------------------------------------------------------------------------------------------------------------------

    //double[][] ventas =
    //{
    //    new double[] {155, 100, 170},
    //    new double[] {205, 120},
    //    new double[] {115, 190, 104, 130},
    //    new double[] {163, 218, 125}
    //};

    ////Mostramos cuantos elementos tiene la matriz unidimesnional
    //Console.WriteLine(ventas[1].Length);
    //Console.WriteLine(ventas[1][0]);

    //------------------------------------------------------------------------------------------------------------------------------

    //Ejercicio for con matrices escalonadas

    //int i, j;

    //double[][] ventas =
    //{
    //    new double[] {155, 100, 170},
    //    new double[] {205, 120},
    //    new double[] {115, 190, 104, 130},
    //    new double[] {163, 218, 125}
    //};

    //for (i = 0; i < ventas.Length; i++)
    //{
    //    Console.WriteLine("Elementos: {0}", i);
    //    for (j = 0; j < ventas[i].Length; j++)
    //    {
    //        Console.WriteLine(ventas[i][j]);
    //    }
    //}

    //------------------------------------------------------------------------------------------------------------------------------

    ////Variables
    //byte i, j, numAlumnos, salones;
    //double sumaCalif = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;

    ////Pedimos el número de salones
    //Console.Write("Ingrese el número de salones: ");
    //salones = Convert.ToByte(Console.ReadLine());

    ////Creación de la matriz
    //double[][] calificaciones = new double[salones][];

    //// Pedimos el número de alumnos por salón
    //for (i = 0; i < salones; i++)
    //{
    //    Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
    //    numAlumnos = Convert.ToByte(Console.ReadLine());

    //    //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
    //    sumaAlumnos += numAlumnos;

    //    //Instanciamos las matrices internas (alumnos en cada salón)
    //    calificaciones[i] = new double[numAlumnos];
    //}

    ////Pedimos las calificaciones de los alumnos de cada salón
    //for (i = 0; i < salones; i++)
    //{
    //    Console.WriteLine("Salón {0}", i);
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        //Pedimos la califiación
    //        Console.Write("Ingresa la calificación del alumno {0}: ", j);
    //        calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

    //        //Acumulamos las califiaciones
    //        sumaCalif += calificaciones[i][j];
    //    }
    //}

    ////Calculamos el promedio
    //promedio = sumaCalif / sumaAlumnos;

    ////Calculamos la calificación mínima
    //for (i = 0; i < salones; i++)
    //{
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        if (calificaciones[i][j] < califMin)
    //        {
    //            califMin = calificaciones[i][j];
    //        }
    //    }
    //}

    ////Calculamos la califiación máxima
    //for (i = 0; i < salones; i++)
    //{
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {

    //        if (calificaciones[i][j] > califMax)
    //        {
    //            califMax = calificaciones[i][j];
    //        }
    //    }
    //}


    ////Mostramos las calificaciones de todos los alumnos de la escuela
    //for (i = 0; i < salones; i++)
    //{
    //    Console.WriteLine("Salón {0}", i);
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
    //    }
    //}

    ////Mostramos los resultados
    //Console.WriteLine("El promedio es: {0}", promedio);
    //Console.WriteLine("La califiación mínima es: {0}", califMin);
    //Console.WriteLine("La califiación máxima es: {0}", califMax);

    ////------------------------------------------------------------------------------------------------------------------------------

    ////GetLength
    //int i; //Variable de control de ciclo exterior
    //int j; //Variable de control de ciclo interior 

    //double[,] ventas = new double[4, 3]/*<=opcional*/ { { 100, 120, 205 },
    //                                                    { 115, 196, 300 },
    //                                                    { 157, 172, 245 },
    //                                                    { 130, 180, 281 } };

    ////Mostramos los valores
    //for (i = 0; i < ventas.GetLength(0); i++)
    //{
    //    Console.WriteLine("Fila {0}", i);
    //    for (j = 0; j < ventas.GetLength(1); j++)
    //    {
    //        Console.WriteLine(ventas[i, j]);
    //    }
    //}

    //------------------------------------------------------------------------------------------------------------------------------
    //EJ SECCION 6

    ////Variables
    //byte i, j, numAlumnos, salones;
    //double sumaCalif = 0, sumaCalifSalon, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

    ////Pedimos el número de salones
    //Console.Write("Ingrese el número de salones: ");
    //salones = Convert.ToByte(Console.ReadLine());

    ////Creación de la matriz
    //double[][] calificaciones = new double[salones][];

    ////Espacio en blanco
    //Console.WriteLine();

    //// Pedimos el número de alumnos por salón
    //for (i = 0; i < salones; i++)
    //{
    //    Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
    //    numAlumnos = Convert.ToByte(Console.ReadLine());

    //    //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
    //    totalAlumnos += numAlumnos;

    //    //Instanciamos las matrices internas (alumnos en cada salón)
    //    calificaciones[i] = new double[numAlumnos];
    //}

    ////Espacio en blanco
    //Console.WriteLine();

    ////Declaramos matrices unidimensionales para almacenar datos por salón
    //double[] califMinSalon = new double[salones];
    //double[] califMaxSalon = new double[salones];
    //double[] promedioSalon = new double[salones];

    ////Pedimos las calificaciones de los alumnos de cada salón
    //for (i = 0; i < salones; i++)
    //{
    //    /*Los valores de calMax, calMin y sumaCalifSalon se tienen que reiniciar a un valor de cero en cada vuelta del ciclo, para que puedan ser comparados nuevamente en cada salón, o de lo contrario se quedaran con los últimos valores que acumularon o encontaron */
    //    sumaCalifSalon = 0;
    //    califMax = 0;
    //    califMin = 10;

    //    //Mostramos el salón en el que estamos
    //    Console.WriteLine("Salón {0}", i);
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        //Pedimos la calificación
    //        Console.Write("Ingresa la calificación del alumno {0}: ", j);
    //        calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

    //        //Acumulamos las calificaciones de toda la escuela
    //        sumaCalif += calificaciones[i][j];

    //        //Acumulamos las calificaciones por salón
    //        sumaCalifSalon += calificaciones[i][j];

    //        //Encontramos la calificación mínima en cada salón
    //        if (calificaciones[i][j] < califMin)
    //        {
    //            califMin = calificaciones[i][j];
    //        }
    //        //Asignamos la calificación más baja encontrada, en la casilla correspondiente al salón
    //        califMinSalon[i] = califMin;

    //        //Encontramos la calificación máxima en cada salón
    //        if (calificaciones[i][j] > califMax)
    //        {
    //            califMax = calificaciones[i][j];
    //        }
    //        //Asignamos la calificación más alta encontrada, en la casilla correspondiente al salón
    //        califMaxSalon[i] = califMax;
    //    }
    //    //Calculamos el promedio de cada salón
    //    promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
    //}

    ////Calculamos el promedio de toda la escuela
    //promedio = sumaCalif / totalAlumnos;

    ///*El cálculo de las calificaciones mínima y máxima para toda la escuela se tiene que volver a hacer, usando otras instrucciones de iteración, porque el reinicio de los valores en las variables causaria conflicto*/

    ////Calculamos la calificación mínima y máxima para toda la escuela en un mismo "for"
    //for (i = 0; i < salones; i++)
    //{
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        // Calificación mínima
    //        if (calificaciones[i][j] < califMin)
    //        {
    //            califMin = calificaciones[i][j];
    //        }
    //        // Calificación máxima
    //        if (calificaciones[i][j] > califMax)
    //        {
    //            califMax = calificaciones[i][j];
    //        }
    //    }
    //}
    ////Espacio en blanco
    //Console.WriteLine();
    //Console.WriteLine();

    ////Titulo para indicar que estamos mostrando información
    //Console.WriteLine("¡DATOS DE LA ESCUELA!");

    ////Espacio en blanco
    //Console.WriteLine();


    ////Mostramos las calificaciones de todos los alumnos de la escuela
    //for (i = 0; i < salones; i++)
    //{
    //    Console.WriteLine("Salón {0}", i);
    //    for (j = 0; j < calificaciones[i].Length; j++)
    //    {
    //        Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
    //    }
    //}

    ////Espacio en blanco
    //Console.WriteLine();

    ////Mostramos los resultados de cada salón
    //for (i = 0; i < salones; i++)
    //{
    //    Console.WriteLine("INFORMACIÓN DEL SALÓN {0}: ", i);
    //    Console.WriteLine("Calificación máxima: {0}, calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
    //    Console.WriteLine("Promedio: {0}", promedioSalon[i]);
    //}

    ////Espacio en blanco
    //Console.WriteLine();

    ////Mostramos los resultados para toda la escuela
    //Console.WriteLine("El promedio de toda la escuela es: {0}", promedio);
    //Console.WriteLine("La calificación más baja de la escuela es: {0}", califMin);
    //Console.WriteLine("La calificación más alta de la escuela es: {0}", califMax);          
    //}

    //}
    //-----------------------------------------------------------------------------------------------------------------------
    //SECCIÓN 7
    //-----------------------------------------------------------------------------------------------------------------------

    //Instancia de una clase == Objeto

    ////Declaración de un campo
    //int numero;



    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    ////Variable local
    //bool acelerar;

    ////Instanciando a la clase auto
    ///*tipo.*/
    //Automovil /*referencia del objeto*/ automovil1 = /*creación del objeto*/ new Automovil();

    //////Mostrando el campo privado
    ////Console.WriteLine("El color es: {0}", automovil1.Color);

    //automovil1.Combustible = "Diesel";
    ////Console.WriteLine("El combustible es: {0}", automovil1.Combustible);

    //Console.WriteLine(automovil1.ToString());

    //-----------------------------------------------------------------------------------------------------------------------
    //// Sobrecarga del método

    //string nombreYApellido;

    //Nombres nombres = new Nombres();

    //nombreYApellido = nombres.Concatenar("Leticia","Guzmán","Morinico");

    //Console.WriteLine(nombreYApellido);

    //-----------------------------------------------------------------------------------------------------------------------

    ////Instanciando clase Random

    //Random random = new Random();

    //Console.WriteLine(random.Next(20, 25));
    //    }
    //}

    ////[modificador de acceso] [class] [identificador]
    //public class Automovil
    //{
    //    //Campos
    //    //color, puertas, combustible,  motor, año, num serie
    //    private string color = "rojo", modelo = "Sentra", combustible, año = "2011", numPuertas;       
    //    private int ccMotor = 1500;

    //    //Ejemplos para campos inicializdos con el constructor

    //    private string asientos, colorTablero;
    //    private bool camaraTrasera;

    //    //Constructor
    //    public Automovil()
    //    {
    //        asientos = "Piel";
    //        colorTablero = "Café";
    //        camaraTrasera = false;
    //    }

    //    //Métodos
    //    //acelerar, frenar, velocidades, seguros, luces
    //    public bool Acelerar()
    //    {
    //        bool acelerar = true;
    //        Console.WriteLine("Acelerar");

    //        return acelerar;
    //    }

    //    public void Velocidades(ref byte velocidadPa)
    //    {
    //        velocidadPa++;
    //        Console.WriteLine("Cambio de velocidad");
    //    }

    //     //acceso - tipo - nombre
    //     public string Color
    //    {
    //        //descriptor de acceso get
    //        get { return color; }

    //        //o

    //        //get => color; (cuerpos de expresión)
    //    }

    //    public string Combustible
    //    {
    //        //un descriptor de acceso set
    //        set { combustible = value;}

    //        //o

    //        //set => combustible = value; (cuerpos de expresión)

    //        //descriptor de acceso get
    //        get { return combustible; }          
    //    }

    //    //Invalidando el método ToString
    //    public override string ToString()
    //    {
    //        string mensaje = "El color es: " + color + "\nAsientos: " + asientos;

    //        return mensaje;

    //        //o

    //        //return "El color es: " + color;
    //    }

    //}

    ////Ejercicio Random
    //class Nombres
    //{
    //    //Metodo
    //    public string Concatenar(string nombrePa, string apellidoPa)
    //    {
    //        string nombreApellido;

    //        nombreApellido = nombrePa + " " + apellidoPa;

    //        return nombreApellido;
    //    }

    //    public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
    //    {
    //        string nombreApellido;

    //        nombreApellido = nombrePa + " " + apellidoPa + " " + apellido2Pa;

    //        return nombreApellido;
    //    }

    //-----------------------------------------------------------------------------------------------------------------------

    ////Ej clases
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Variables locales
    //        string nombreAr, apellidoAr, nip;

    //        Console.WriteLine("Bienvenido a Monsters Inc.\n");
    //        Console.WriteLine("Ingrese los siguientes campos que se le solicitan: \n");

    //        Console.Write("Nombre: ");
    //        nombreAr = Console.ReadLine();
    //        Console.Write("Apellido: ");
    //        apellidoAr = Console.ReadLine();
    //        Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
    //        nip = Console.ReadLine();

    //        //Instanciamos a la clase Empleado
    //        Empleado empleado1 = new Empleado(nombreAr, apellidoAr);

    //        empleado1.Nip = nip;

    //        //Mostrar la información del objeto
    //        Console.WriteLine(empleado1.ToString());
    //    }
    //}

    //class Empleado
    //{
    //    //Campos
    //    private string nombre, apellido, id, locker, banco, nip;

    //    //Constructor
    //    public Empleado(string nombrePa, string apellidoPa)
    //    {
    //        nombre = nombrePa;
    //        apellido = apellidoPa;

    //        //Llamando a los métodos para generar los números aleatorios
    //        id = GenerarID();
    //        locker = GenerarLocker();
    //        banco = AsignaBanco();
    //    }

    //    //Instaciamos a Random
    //    Random random = new Random();

    //    //Propiedades
    //    public string Nip
    //    {
    //        set => nip = value;
    //    }

    //    //Métodos
    //    private string GenerarID()
    //    {
    //        //Variables
    //        int i, numero;
    //        string id = "";

    //        for (i = 0; i < 10; i++)
    //        {
    //            numero = random.Next(10);

    //            id += numero.ToString();
    //        }
    //        return id;
    //    }

    //    private string GenerarLocker()
    //    {
    //        //Variables
    //        int i, numero;
    //        string locker = "";

    //        for (i = 0; i < 2; i++)
    //        {
    //            numero = random.Next(10);

    //            locker += numero.ToString();
    //        }
    //        return locker;
    //    }

    //    private string AsignaBanco()
    //    {
    //        //Variables
    //        int asignarBanco;
    //        string banco = "";

    //        asignarBanco = random.Next(1, 3);

    //        switch (asignarBanco)
    //        {
    //            case 1:
    //                banco = "Santander";
    //                break;
    //            case 2:
    //                banco = "BBVA";
    //                break;
    //        }
    //        return banco;
    //    }

    //    public override string ToString()
    //    {
    //        string mensaje = "";

    //        mensaje = "Empleado: " + nombre + " " + apellido + "\nNúmero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

    //        return mensaje;
    //    }
    //}

    //-----------------------------------------------------------------------------------------------------------------------

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Variables
    //        double montoAr, saldoInicialAr;
    //        int opcion;
    //        string nombreAr, apellidosAr, direccionAr, rfcAr;

    //        //Aviso de nueva cuenta
    //        Console.Write("Está a punto de crear una cuenta nueva, por favor presione cualquier tecla para continuar: ");
    //        Console.ReadKey();

    //        Console.WriteLine("\nIngrese la información que se le solicita a continuación: ");

    //        Console.Write("\nNombre: ");
    //        nombreAr = Console.ReadLine();

    //        Console.Write("Apellidos: ");
    //        apellidosAr = Console.ReadLine();

    //        Console.Write("Dirección: ");
    //        direccionAr = Console.ReadLine();

    //        Console.Write("RFC: ");
    //        rfcAr = Console.ReadLine();

    //        Console.Write("Ingrese su deposito inicial: $");
    //        saldoInicialAr = Convert.ToDouble(Console.ReadLine());

    //        //Instanciamos a la clase
    //        CuentaBancaria cliente1 = new CuentaBancaria(nombreAr, apellidosAr, saldoInicialAr, direccionAr, rfcAr);

    //        //Mensaje de creación de cuenta
    //        Console.WriteLine("Felicidades, su cuenta ha sido creada con exito, presione  cualquier tecla para continuar");
    //        Console.ReadKey();

    //        //Menú
    //        do
    //        {
    //            Console.WriteLine("\n1. Deposito");
    //            Console.WriteLine("2. Retiro");
    //            Console.WriteLine("3. Consultar Saldo");
    //            Console.WriteLine("4. Mostrar Información de la cuenta");
    //            Console.WriteLine("5. Salir");

    //            Console.Write("\nElija una opción: ");
    //            opcion = Convert.ToInt32(Console.ReadLine());

    //            switch (opcion)
    //            {
    //                case 1:
    //                    Console.Write("Ingrese el monto a depositar: $");
    //                    montoAr = Convert.ToDouble(Console.ReadLine());

    //                    cliente1.Deposito(montoAr);
    //                    break;
    //                case 2:
    //                    Console.Write("Ingrese el monto a retirar: $");
    //                    montoAr = Convert.ToDouble(Console.ReadLine());

    //                    cliente1.Retiro(montoAr);
    //                    break;
    //                case 3:
    //                    cliente1.ConsultaSaldo();
    //                    break;
    //                case 4:
    //                    Console.WriteLine(cliente1.ToString());
    //                    break;
    //            }


    //        } while (opcion >= 1 && opcion <= 4);
    //    }
    //}

    //class CuentaBancaria
    //{
    //    //Campos
    //    private string nombre, apellidos, direccion, rfc;
    //    private double saldo;

    //    //Constructor
    //    public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
    //    {
    //        nombre = nombrePa;
    //        apellidos = apellidosPa;
    //        saldo = saldoPa;
    //        direccion = direccionPa;
    //        rfc = rfcPa;
    //    }

    //    //Métodos
    //    public double Deposito(double montoPa)
    //    {
    //        saldo += montoPa;
    //        return saldo;
    //    }

    //    public double Retiro(double montoPa)
    //    {
    //        if (saldo >= montoPa)
    //        {
    //            saldo -= montoPa;
    //        }
    //        else
    //        {
    //            Console.WriteLine("¡Saldo insuficiente!");
    //        }
    //        return saldo;
    //    }

    //    public void ConsultaSaldo()
    //    {
    //        Console.WriteLine("Su saldo es: ${0}", saldo);
    //    }

    //    public override string ToString()
    //    {
    //        string mensaje;
    //        mensaje = "\nTitular: " + nombre + " " + apellidos + "\nRFC:" + rfc + "\nDirección: " + direccion + "\nSaldo: $" + saldo;

    //        return mensaje;
    //    }
    //}

    //-----------------------------------------------------------------------------------------------------------------------

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //object numEntero = 16;
    //object cadena = "Hola";
    //object flotante = 3.1415;

    //object[] numero = new object[2];

    //numero[0] = 2;
    //numero[1] = "Luis";

    //object objeto;
    //objeto = "Hola";

    ////Ejemplo de genéricos
    //EjemploGenerico<string> generico1 = new EjemploGenerico<string>();
    //EjemploGenerico<int> generico2 = new EjemploGenerico<int>();

    //-------------------------------------------------------------------------------------------------------------------------------

    //        //Variables locales
    //        Alumno valorElemento;

    //        //instanciando la clase
    //        GuardaObjetos<Alumno> objeto1 = new GuardaObjetos<Alumno>(3);

    //        //Instanciamos la clase "Alumno"
    //        Alumno alumno1 = new Alumno(8.5);
    //        Alumno alumno2 = new Alumno(10);
    //        Alumno alumno3 = new Alumno(6.8);

    //        ////Agregar objetos
    //        objeto1.AgregarElementos(alumno1);
    //        objeto1.AgregarElementos(alumno2);
    //        objeto1.AgregarElementos(alumno3);

    //        //Obtener elemento
    //        valorElemento = objeto1.ObtenerElemento(1);
    //        Console.WriteLine(valorElemento.Calificacion);
    //    }

    // }
    //class GuardaObjetos<T>
    //{
    //    //Campos
    //    private int i = 0;
    //    private T[] matrizElementos;

    //    //Constructor
    //    public GuardaObjetos(int elementoPa)
    //    {
    //        matrizElementos = new T[elementoPa];
    //    }

    //    //Métodos
    //    public void AgregarElementos(T elementoPa)
    //    {
    //        matrizElementos[i] = elementoPa;
    //        i++;
    //    }

    //    public T ObtenerElemento(int elementoPa)
    //    {
    //        return matrizElementos[elementoPa];
    //    }
    //}

    //class Alumno
    //{
    //    //Campo
    //    double calificacion;

    //    //Constructor
    //    public Alumno(double calificacionPa)
    //    {
    //        calificacion = calificacionPa;
    //    }

    //    public double Calificacion
    //    {
    //        get => calificacion;
    //    }
    //}

    //----------------------------------------------------------------------------------------------------------

    //List - Stack - Queue
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    ////Variables necesarias
    //string elem;
    //int opcion;

    ////Instancia de List
    //List<string> Personas = new List<string>();

    ////Agregamos objetos en la List
    //Personas.Add("Hugo");
    //Personas.Add("Miguel");
    //Personas.Add("Diana");
    //Personas.Add("Erick");

    //do
    //{
    //    Console.WriteLine("1. Agregar elemento");
    //    Console.WriteLine("2. Salir");
    //    opcion = Convert.ToInt32(Console.ReadLine());

    //    if (opcion == 1)
    //    {
    //        Console.Write("Ingresa el elemento a agregar en la lista: ");
    //        elem = Console.ReadLine();

    //        Personas.Add(elem);
    //    }
    //}
    //while (opcion == 1);

    //Console.WriteLine("\nLos elementos de la List son: \n");

    ////Instuccion "foreach" para recorrer una colección
    //foreach (string elemento in Personas)
    //{
    //    Console.WriteLine(elemento);
    //}
    ////Equivalente en for
    //for (int i = 0; i < Personas.Count; i++)
    //{
    //    Console.WriteLine(Personas[i]);
    //}

    ////Insertamos un elemento en la list
    //Personas.Insert(2, "Victor");
    //Personas.RemoveAt(4);

    //Console.WriteLine();
    //foreach (string elemento in Personas)
    //{
    //    Console.WriteLine(elemento);
    //}

    //elem = "Diana";

    //Console.WriteLine();
    //Console.WriteLine(Personas.IndexOf(elem));

    ////Ejercicio List -----------------------

    ////Variables necesarias
    //int opcion, indice;
    //string alumno;

    ////Instancia de List
    //List<string> Alumnos = new List<string>();

    //do
    //{
    //    Console.Clear();

    //    Console.WriteLine("1. Agregar estudiante");
    //    Console.WriteLine("2. Eliminar estudiante");
    //    Console.WriteLine("3. Mostrar estudiantes");
    //    Console.WriteLine("4. Buscar por nombre");

    //    //Escoger opción
    //    Console.Write("Escoge una opción: ");
    //    opcion = Convert.ToInt32(Console.ReadLine());

    //    Console.Clear();

    //    switch (opcion)
    //    {
    //        case 1:
    //            Console.Write("Ingresa el nombre del alumno: ");
    //            alumno = Console.ReadLine();

    //            Alumnos.Add(alumno);
    //            break;
    //        case 2:
    //            Console.Write("Ingrese el número del estudiante que quiera eliminar: ");
    //            indice = Convert.ToInt32(Console.ReadLine());

    //            indice--; //Reducimos en 1 a índice, porque el usuario no sabe que el índice empieza en cero, por lo tanto, si se ingresa 1, en realidad será 0.

    //            if (indice >= Alumnos.Count() || indice < 0)
    //            {
    //                Console.WriteLine("El Alumno no existe");
    //            }
    //            else
    //            {
    //                string alumnoElim = Alumnos[indice];
    //                Alumnos.RemoveAt(indice); //Quitamos al alumno de la List
    //                Console.WriteLine("{0} se ha eliminado correctamente", alumnoElim);
    //            }
    //            Console.Write("\nPresione cualquier tecla para regresar al menú ");
    //            Console.ReadKey();
    //            break;
    //        case 3:
    //            int i = 1; //Nos sirve para mostrar el indice de los alumnos

    //            foreach (string estudiante in Alumnos)
    //            {
    //                Console.WriteLine("{0}. {1}", i++, estudiante);
    //            }
    //            Console.Write("\nPresione cualquier tecla para regresar al menú ");
    //            Console.ReadKey();
    //            break;
    //        case 4:
    //            string encontrarAlum;
    //            int j; //número de lista

    //            Console.Write("Ingrese el nombre del estudiante a buscar: ");
    //            alumno = Console.ReadLine();

    //            //Verificar si el elemento(alumno) está o no en la List
    //            if (Alumnos.IndexOf(alumno) >= 0)
    //            {
    //                encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)]; //Alumnos[3]
    //                j = Alumnos.IndexOf(alumno) + 1;

    //                Console.WriteLine("El estudiante {0} se encuentra en el número de lista {1}", encontrarAlum, j);
    //            }
    //            else
    //            {
    //                Console.WriteLine("El estudiante {0} no se encuentra en el sistema", alumno);
    //            }
    //            Console.Write("\nPresione cualquier tecla para regresar al menú ");
    //            Console.ReadKey();
    //            break;
    //    }

    //} while (opcion >= 1 && opcion <= 4);

    ////Stack

    //Stack<double> miPila = new Stack<double>();

    ////Insertar objetos al principio del Stack
    //miPila.Push(5.9);
    //miPila.Push(8.9);
    //miPila.Push(9.9);
    //miPila.Push(6.1);
    //miPila.Push(4.7);

    //int i = 0;

    ////Mostrar la infor del Stack
    //foreach (double elemento in miPila)
    //{
    //    Console.WriteLine("{0}. {1}", i++, elemento);
    //}

    ////Queue
    //Queue<char> miFila = new Queue<char>();

    ////Agregando objetos al Queue
    //miFila.Enqueue('a');
    //miFila.Enqueue('b');
    //miFila.Enqueue('c');
    //miFila.Enqueue('d');

    //int i = 0;

    ////Recorriendo la Queue
    //foreach(char elemento in miFila)
    //{
    //    Console.WriteLine("{0}. {1}", i++, elemento);
    //}

    ////Agregando nuevo elemento (Enqueue)
    //Console.WriteLine("\nDespués de agregar a (e):\n");
    //miFila.Enqueue('e');

    //foreach (char elemento in miFila)
    //{
    //    Console.WriteLine("{0}. {1}", i++, elemento);
    //}

    ////Eliminando objeto (ObjElim)
    //Console.WriteLine("\nDespués de eliminar a ():\n");
    //miFila.Dequeue();

    //foreach (char elemento in miFila)
    //{
    //    Console.WriteLine("{0}. {1}", i++, elemento);
    //}

    //----------------------------------------------------------------------------------------------------

    ////Dictionary, se compone de un "key-value pair"
    //Dictionary<string, int> empleados = new Dictionary<string, int>();

    //empleados.Add("Hugo", 36);
    //empleados.Add("Erica", 20);

    //foreach (KeyValuePair<string, int> elemento in empleados)
    //{
    //    Console.WriteLine("Key = {0} \nValue = {1}\n", elemento.Key, elemento.Value);
    //}

    ////Uso de Item - coleccion[key] = value;
    //empleados["Miguel"] = 45; //Con add: empleados.Add("Miguel", 45);

    ////Después de agregar un elemento con Item[]
    //Console.WriteLine("\nDespués de agregar un elemento Item\n");

    //foreach (KeyValuePair<string, int> elemento in empleados)
    //{
    //    Console.WriteLine("Key = {0} \nValue = {1}\n", elemento.Key, elemento.Value);
    //}

    ////Comprobando que Item[] reemplaza la "key"
    //Console.WriteLine("\nComprobando que Item[] reemplaza la (key)\n");

    //empleados["Hugo"] = 19;

    //foreach (KeyValuePair<string, int> elemento in empleados)
    //{
    //    Console.WriteLine("Key = {0} \nValue = {1}\n", elemento.Key, elemento.Value);
    //}

    ////Usando el "get" de la propiedad Item[]
    //Console.WriteLine("\nLa edad de Erica es: {0}\n", empleados["Erica"]);

    ////Quitar elementos
    //Console.WriteLine("\nDespués de remover un elemento\n");
    //empleados.Remove("Erica");

    //foreach (KeyValuePair<string, int> elemento in empleados)
    //{
    //    Console.WriteLine("Key = {0} \nValue = {1}\n", elemento.Key, elemento.Value);
    //}

    //Console.WriteLine();

    //if (empleados.ContainsKey("Erica"))
    //{
    //    Console.WriteLine("La key está");
    //}
    //else
    //{
    //    Console.WriteLine("La key no está");
    //}

    //Console.WriteLine();

    //if (empleados.ContainsValue(45))
    //{
    //    Console.WriteLine("Exite");
    //}
    //else
    //{
    //    Console.WriteLine("No existe");
    //}

    //Ejercicio Dictionary ------------------------------------------

    ////Variables necesarias
    //int opcion;
    //string nombre;
    //long numero;

    ////Instanciamos a la colección
    //Dictionary<string, long> contactos = new Dictionary<string, long>();

    //do
    //{
    //    Console.Clear();

    //    //Menú
    //    Console.WriteLine("1. Agregar contacto");
    //    Console.WriteLine("2. Buscar contacto");
    //    Console.WriteLine("3. Eliminar contacto");
    //    Console.WriteLine("4. Mostrar contactos");

    //    Console.Write("\nEscoge una opción: ");
    //    opcion = Convert.ToInt32(Console.ReadLine());

    //    Console.Clear();

    //    switch (opcion)
    //    {
    //        case 1:
    //            Console.Write("Nombre: ");
    //            nombre = Console.ReadLine();

    //            Console.Write("Número: ");
    //            numero = Convert.ToInt64(Console.ReadLine());

    //            contactos.Add(nombre, numero);
    //            Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

    //            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //            Console.ReadKey();
    //            break;
    //        case 2:
    //            Console.Write("Buscar contacto por nombre: ");
    //            nombre = Console.ReadLine();

    //            if (contactos.ContainsKey(nombre))
    //            {
    //                Console.WriteLine("\n¡Contacto encontrado!");

    //                Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

    //                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //                Console.ReadKey();
    //            }
    //            else
    //            {
    //                Console.WriteLine("\n¡El contacto no existe!");

    //                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //                Console.ReadKey();
    //            }
    //            break;
    //        case 3:
    //            Console.Write("Contacto a eliminar: ");
    //            nombre = Console.ReadLine();

    //            if (contactos.ContainsKey(nombre))
    //            {
    //                contactos.Remove(nombre);

    //                Console.WriteLine("\n({0}) ha sido eliminado con exito", nombre);

    //                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //                Console.ReadKey();
    //            }
    //            else
    //            {
    //                Console.WriteLine("\n¡El contacto no existe!");

    //                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //                Console.ReadKey();
    //            }
    //            break;
    //        case 4:
    //            Console.WriteLine("Contactos en tu agenda: \n");

    //            foreach (KeyValuePair<string, long> elemento in contactos)
    //            {
    //                Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
    //            }

    //            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
    //            Console.ReadKey();
    //            break;
    //    }

    //} while (opcion >= 1 && opcion <= 4);

    //-------------------------------------------------------------------------------------------------------------------------------

    ////Cadenas

    ////Instanciando a String por medio del alias "string"
    //string cadena1 = "";

    ////
    //char[] caracteres = { 'H', 'o', 'l', 'a'};
    ////Creando
    //String cadenaDeCaracteres = new string(caracteres);

    ////Imprimiendo la instancia
    //Console.WriteLine(cadenaDeCaracteres);

    ////Join
    //string[] nombres = { "Juan", "María", "Carlos" };

    //string nombresConcatenados = string.Join(", ", nombres);

    //Console.WriteLine("Nombres concatenados: \n{0}", nombresConcatenados);

    ////Split
    //string frase = "Hola, ¿cómo estás?";

    //string[] palabras = frase.Split(' ');

    //Console.WriteLine("Palabras divididas:");

    //foreach (var elemento in palabras)
    //{
    //    Console.WriteLine(elemento);
    //}

    //------------------------------------------------------------------------------------------------------------------------------------
    ////Contains - EndsWith - StartsWith - IndexOf - LastIndexOf
    //string palabra = "I’m a GitHub Software Developer with 3 years of backend-focused, professional experience in the full-stack .NET field (C# and VB.NET), including desktop (WinForms and WPF), ASP.NET Core RESTful APIs, and Blazor WebAssembly. Other technologies I’m familiar with are Angular, Svelte and Node.js for JS/TS-related frontend and backend development, and app containerization and deployment with Docker, Docker Hub and GitHub Actions.";

    //string caracterBuscado = "GitHub";

    //int primerAparicion = palabra.IndexOf(caracterBuscado);

    //Console.WriteLine("La primera aparición del caracter ({0}), es en la posición ({1}).", caracterBuscado, primerAparicion);

    //---------------------------------------------------------------------------------------------------------------------------------------
    ////StringBuilder
    //StringBuilder numeros = new StringBuilder();

    //for (int i = 0; i <= 100; i++)
    //{
    //    numeros.Append(i);
    //    numeros.Append(", ");
    //}
    //Console.WriteLine(numeros.ToString());
    //---------------------------------------------------------------------------------------------------------------------------------------

    //----------------------------------------------------------------------------------------------------------------------------------
    ////Compare

    ////Entero negativo (Primera cadena < Segunda cadena)
    ////Cero (Primera cadena == Segunda cadena)
    ////Entero Positivo (Primera cadena > Segunda cadena)

    //string cadena1 = "z";
    //string cadena2 = "ö";

    //int ordenar;

    //ordenar = String.Compare(cadena1, cadena2, new CultureInfo("sv-SE"), CompareOptions.None);

    //switch (ordenar)
    //{
    //    case -1:
    //        Console.WriteLine("({0}) es menor que ({1}), según el criterio de ordenación", cadena1, cadena2);
    //        break;
    //    case 0:
    //        Console.WriteLine("({0}) es igual que ({1}), según el criterio de ordenación", cadena1, cadena2);
    //        break;
    //    case 1:
    //        Console.WriteLine("({0}) es mayor que ({1}), según el criterio de ordenación", cadena1, cadena2);
    //        break;
    //}
    //----------------------------------------------------------------------------------------------------------------------------------
    ////String.PadLeft y String.PadRight

    //string texto = "hello";
    //string resultado = texto.PadRight(10);
    //// resultado será "hello     " (5 caracteres + 5 espacios en blanco)

    //string texto = "hello";
    //string resultado = texto.PadLeft(10);
    //// resultado será "     hello" (6 espacios en blanco + 5 caracteres)

    //string texto = "hello";
    //string resultado = texto.PadRight(10, '#');           
    //Console.WriteLine(resultado);
    //// resultado será "hello#####" (5 caracteres + 5 sharps)

    //----------------------------------------------------------------------------------------------------------------------------------
    //Cadena de escape 

    //----------------------------------------------------------------------------------------------------------------------------------
    //Cadena de formato

    ////Formato compuesto
    //int numero1 = 5, numero2 = 10;

    //Console.WriteLine("El primer valor es: {0}, y el segundo valor es: {1}", numero1, numero2);

    //string cadena1;

    //cadena1 = String.Format("El valor es {0}", numero1);
    //Console.WriteLine(cadena1);


    ////Interpolación de cadenas
    ////Carácter de cadena interpolada ($)
    //int numero1 = 5, numero2 = 10;

    //Console.WriteLine($"El primer valor es: {numero1}, y el segundo valor es: {numero2}");

    ////{expresionDeInterpolación, alineación: cadenaDeFormato}
    //int sueldo = 3500;
    //double gastos = 215.432;

    //Console.WriteLine($"Mi sueldo es de {sueldo:C5}");
    //Console.WriteLine($"Mi gasto es de {gastos:F1}");

    ////formato personalizado           
    //var fecha = 02122001;
    //Console.WriteLine($"La fecha es {fecha:##-##-####}");

    ////DateTime
    //DateTime fechaHora = new DateTime(2001, 9, 11, 15, 23, 15);//año, mes, día, hora, minuto, segundo
    //DateTime fecha = new DateTime( 2001, 12, 02);

    //Console.WriteLine(fechaHora);

    //var cadenaFechaHora = fechaHora.ToString("f");

    //Console.WriteLine(cadenaFechaHora);




    //// Declarando un objeto DateTime
    //DateTime fechaHora = new DateTime(2002, 1, 5, 13, 54, 10);
    //Console.WriteLine($"El valor del objeto DateTime es: {fechaHora}");

    //// Convirtiendo el objeto DateTime en una cadena
    ////Especificadores que requieren modificacion: ("d", "f", "F", "g", "h", "H", "K", "m", "M", "s", "t", "y", "z", ":" 0 "/")
    //string cadenaFechaHora = fechaHora.ToString("ddd dd \"feliz\" MMMM \\de yyyy h:m:s tt");

    //// Imprimiendo la representación en cadena del objeto DateTime según la referencia cultural actual(es-MX)
    //Console.WriteLine($"La presentación en cadena es: (cadenaFechaHora)");




    //// (es - AR)
    //string cadenaFechaHora;
    //DateTime dateTimeFechaHora;

    //// Pedimos al usuario la fecha/hora y la guardamos en una cadena
    //Console.Write("Ingrese la fecha y hora deseada: ");
    //cadenaFechaHora = Console.ReadLine();

    ////Convertimos la cadena en un objeto DateTime
    //dateTimeFechaHora = DateTime.Parse(cadenaFechaHora);
    ////Mostramos a la cadena como un objeto DateTime
    //Console.WriteLine(dateTimeFechaHora);

    //    }

    //}

    ////Ej Generador de contraseñas
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /* De entre 8-20 caracteres
    //         * Van a contener al menos una letra minúscula
    //         * Una letra mayúscula
    //         * Un número
    //         * Y un carácter especial de entre seis posibles opciones
    //         */

    //        //Variables necesarias
    //        string nombreUsuario, opcion, contraseña;

    //        //Un título para el programa
    //        Console.WriteLine("\tRegistro\n\n");

    //        //Pedimos el nombre de usuario
    //        Console.Write("Ingrese un nombre de usuario: ");
    //        nombreUsuario = Console.ReadLine();

    //        //Preguntamos si se desea hacer uso del generador de contraseñas o escribir una nosotros mismos
    //        Console.Write("¿Desea que le generemos una contraseña segura? (si/no): ");
    //        opcion = Console.ReadLine();

    //        opcion = opcion.ToLower(); //Convertimos a minúscula la respuesta del usuario (en caso de que use mayúsculas o una combinación de ambas)

    //        //Seguimos una de las dos posibles rutas
    //        switch (opcion)
    //        {
    //            case "si":
    //                //Instanciamos a la clase Contraseña para poder hacer uso de ella
    //                Contraseña contraseñal = new Contraseña();

    //                //Llamamos a su método "GenerarContraseña" y le asignamos lo que devuelve a nuestra variable local "contraseña'
    //                contraseña = contraseñal.GenerarContraseña();

    //                Console.WriteLine($"Esta es la contraseña que generamos para ti, guárdala en un lugar seguro: {contraseña}");

    //                Console.Write("\nPresiona cualquier tecla para terminar tu registro ");
    //                Console.ReadKey();
    //                Console.Clear();

    //                //Mostramos un resumen de los datos
    //                Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tusuario: {nombreUsuario}\n\tcontraseña: {contraseña}");

    //            break;

    //            case "no":

    //            break;
    //        }
    //    }
    //}

    ////Creamos una clase específicamente para manejar los campos y métodos que van a generar la contraseña
    //class Contraseña 
    //{
    //    //CAMPOS
    //    //4 colecciones de caracteres para escoger y generar la contraseña
    //    string numeros = "0123456789";
    //    string letrasMin = "qwertyuiopñlkjhgfdsazxcvbnm";
    //    string letrasMay = "QWERTYUIOPÑLKJHGFDSAZXCVBNM";
    //    string caractEspecial = "|°¬!\"#$%&/()=?¡*¨]\\[_:;,.-{}´+¿'<>^`~";

    //    //Contadores para verificar el número de caracteres de cada grupo
    //    int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

    //    //Método para generar la contraseña
    //    public string GenerarContraseña()
    //    {
    //        //Aquí guardaremos la contraseña
    //        string contraseñaGenerada = "";

    //        //Instaciamons a la clse Random para usarla más adelante
    //        Random random = new Random();

    //        //Declaramos una variable que guarda el tamaño que tendrá la contraseña, generamos un número aleatorio para determinar una longitud de entre 8 y 20 caracteres y se lo asignamos a la variable
    //        int longitudContraseña = random.Next(15, 31);

    //        //Variables que van a determinar el número de caracteres que se usarán de cada grupo. Basandose en un porcentaje de la longitud de la contraseña
    //        double numTener = longitudContraseña * .15; //E1 15% de los carácteres serán números
    //        double minTener = longitudContraseña * .35;
    //        double mayTener = longitudContraseña * .35;
    //        double espTener = longitudContraseña * .15;

    //        //Variable de tipo char que va a almacenar a cada uno de los caracteres que van a conformar a la contraseña
    //        char caracterEscogido;

    //        //Usamos una iteración while para ir colocando un carácter (de los 4 del grupo) hasta que completemos la longitud que se estableció anteriormente
    //        while(contraseñaGenerada.Length < longitudContraseña)
    //        {
    //            //Volvemos a usar un número aleatorio, esta vez para seleccionar uno de los 4 grupos de string que tenemos
    //            switch(random.Next(0, 4))
    //            {
    //                case 0:
    //                    //Si los caracteres numéricos que contiene la contraseña son menos a los que debe contener, entonces ingresa al bloque de código y los genera.
    //                    if (numContiene < numTener)
    //                    {
    //                        /* A "caracterEscogido" se le va a asignar un carácter aleatorio de los contenidos en el string "numeros", basándose en el índice y apoyándose de la propiedad "Lenght". Ejem:
    //                           caracterEscogido = numeros[random.Next(10)] //porque son diez elementos
    //                           caracterEscogido = numeros [3] //Tomaría el cuarto carácter*/
    //                        caracterEscogido = numeros[random.Next(numeros.Length)];
    //                        //Se le acumula el carácter escogido por Random a la contraseña generada
    //                        contraseñaGenerada += caracterEscogido;
    //                        //Se aumenta en 1 los caracteres numericos que contiene la contraseña
    //                        numContiene++;
    //                    }
    //                break;
    //                case 1:
    //                    if (numContiene < numTener)
    //                    {                         
    //                        caracterEscogido = letrasMin[random.Next(letrasMin.Length)];

    //                        contraseñaGenerada += caracterEscogido;

    //                        numContiene++;
    //                    }
    //                break;
    //                case 2:
    //                    caracterEscogido = letrasMay[random.Next(letrasMay.Length)];

    //                    contraseñaGenerada += caracterEscogido;

    //                    numContiene++;
    //                break;
    //                case 3:
    //                    caracterEscogido = caractEspecial[random.Next(caractEspecial.Length)];

    //                    contraseñaGenerada += caracterEscogido;

    //                    numContiene++;
    //                break;
    //            }
    //        }
    //        return contraseñaGenerada;
    //    }

    //    public string VerificarContraseña()
    //    {

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //// Variables
    //bool repetir = true; //Se encarga de repetir el menú hasta que nosotros decidamos salir del programa
    //string opcion;

    //// Creamos una instancia de la clase Biblioteca
    //Biblioteca biblioteca1 = new Biblioteca();

    //do
    //{
    //    Console.WriteLine("\nBiblioteca\n");
    //    Console.WriteLine("1. Agregar libro");
    //    Console.WriteLine("2. Mostrar todos los libros");
    //    Console.WriteLine("3. Búsqueda exacta de un libro");
    //    Console.WriteLine("4. Búsqueda parcial de un libro");
    //    Console.WriteLine("5. Eliminar un libro");
    //    Console.WriteLine("6. Salir");

    //    Console.Write("\nIngresar una opción: ");
    //    opcion = Console.ReadLine();

    //    switch (opcion)
    //    {
    //        case "1": // Agregar un nuevo libro
    //            biblioteca1.AgregarLibro();
    //            break;

    //        case "2":  // Mostrar una lista de los libros
    //            biblioteca1.MostrarLibros();
    //            break;

    //        case "3":  // Búsqueda exacta
    //            biblioteca1.BuscarLibro();
    //            break;

    //        case "4": // Búsqueda parcial de un libro
    //            biblioteca1.BusquedaParcial();
    //            break;

    //        case "5":  // Eliminar libro
    //            biblioteca1.EliminarLibro();
    //            break;
    //        case "6":  // Finalizar el programa
    //            repetir = false; //El bucle se repite mientras "repetir == true", por lo tanto, esta instrucción nos sacará del programa
    //            break;
    //        default:
    //            Console.WriteLine("\n¡Opción invalida, intenta de nuevo!\n");
    //            break;
    //    }


    //} while (repetir);

    //        //-----------------------------------------------------------------------------------------------------

    //        //EJERCICIO CON TYPE
    //        //Variables de tipo "Type"
    //        Type tipoDatoStruct = typeof(Libro);
    //        Type tipoDatoClass = typeof(Biblioteca);

    //        // Mostrando el Namespace del tipo
    //        Console.WriteLine(tipoDatoStruct.Namespace);

    //        // "FieldInfo", "MethodInfo" y "PropertyInfo"
    //        FieldInfo[] camposDatoStruct;

    //        // Asignando la devolución del método "GetFie1ds" (una matriz con información de los campos) a nuestra matriz "camposDatoStruct"
    //        camposDatoStruct = tipoDatoStruct.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

    //        // Recorriendo a la matriz "camposDatoStruct" para mostrar a los campos de "Libro"
    //        Console.WriteLine("Campos del tipo: \n");
    //        foreach(FieldInfo elemento in camposDatoStruct)
    //        {
    //            Console.WriteLine(elemento.Name);
    //        }

    //        //Mostrando información de la clase "Biblioteca"
    //        Console.WriteLine("\n----------------\n");
    //        Console.WriteLine($"E1 nombre completo del tipo es: {tipoDatoClass.FullName}");
    //        Console.WriteLine(tipoDatoClass.FullName);

    //        // Matrices donde se guardará la información devuelta por los métodos "GetProperties" y "GetMethods"
    //        MethodInfo[] metodosDatoClass; // Para los métodos
    //        PropertyInfo[] propiedadesDatoClass; // Para las propiedades

    //        // Usamos a "GetProperties" para obtener la información de las propiedades de nuestra clase, y almacenamos su devolución en la matriz "propiedadesDatoC1ass"
    //        propiedadesDatoClass = tipoDatoClass.GetProperties();

    //        // Usamos a "GetMethods" para obtener la información de los métodos de nuestra clase, y almacenamos su devolución en la matriz "metodosDatoC1ass"
    //        metodosDatoClass = tipoDatoClass.GetMethods();

    //        // Recorriendo a la matriz "propiedadesDatoC1ass" para mostrar a las propiedades de "Biblioteca"
    //        Console.WriteLine("Propiedades del tipo:\n");
    //        foreach (PropertyInfo elemento in propiedadesDatoClass)
    //        {
    //            Console.WriteLine(elemento);

    //        }

    //        // Recorriendo a la matriz "metodosDatoC1ass" para mostrar a los métodos de " Biblioteca"
    //        Console.WriteLine("Métodos del tipo:\n");
    //        foreach (MethodInfo elemento in metodosDatoClass)
    //        {
    //            Console.WriteLine(elemento);
    //        }           
    //    }
    //}

    //class Biblioteca
    //{
    //    Libro[] libros; //Declaramos una matriz de tipo struct "Libro"
    //    int cantidadLibros = 0; //No existen libros al inicio del programa
    //    string buscarLibro;
    //    bool libroEncontrado;
    //    int posicionLibroEliminar;

    //    public Libro[] Libros { get => libros; set => libros = value; }
    //    public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
    //    public string BuscarLibro1 { get => buscarLibro; set => buscarLibro = value; }
    //    public bool LibroEncontrado { get => libroEncontrado; set => libroEncontrado = value; }
    //    public int PosicionLibroEliminar { get => posicionLibroEliminar; set => posicionLibroEliminar = value; }


    //    //Constructor
    //    public Biblioteca()
    //    {
    //        libros = new Libro[1000];
    //    }

    //    public void AgregarLibro()
    //    {
    //        if (cantidadLibros < libros.Length) //Verificar si podemos ingresar un nuevo libro
    //        {
    //            Console.Clear();
    //            Console.WriteLine($"Ingresar información para el libro {cantidadLibros + 1}\n"); // Decimos +1 para mostrar un indice que el usuario entienda

    //            Console.Write(" Ingresa el nombre del libro: ");
    //            libros[cantidadLibros].Titulo = Console.ReadLine();
    //            Console.Write(" Ingresa el Autor: ");
    //            libros[cantidadLibros].Autor = Console.ReadLine();
    //            Console.Write(" Ingresa el año: ");
    //            libros[cantidadLibros].Año = Console.ReadLine();

    //            cantidadLibros++; // Aumentamos la cantidad de libros existentes

    //            Console.Clear();
    //            Console.WriteLine("Libro agregado correctamente!\n");
    //        }
    //        else
    //        {
    //            //En caso de que no se pueda agregar un nuevo libro
    //            Console.WriteLine("No se puede ingresar un nuevo libro. Intenta eliminar uno ya existente");
    //        }
    //    }

    //    public void MostrarLibros()
    //    {
    //        Console.Clear();
    //        if (cantidadLibros == 0)
    //        {
    //            //Si no existe ningún libro, mostramos el sig mensaje
    //            Console.WriteLine("Biblioteca vacía");
    //        }
    //        else
    //        {
    //            for (int i = 0; i < cantidadLibros; i++) // Si existe al menos uno, mostramos su información
    //            {
    //                Console.WriteLine($"{i + 1}.- Título: {libros[i].Titulo}, Autor: {libros[i].Autor}, Año: {libros[i].Año}");
    //            }
    //            Console.Write("Presiona cualquier tecla para continuar...");
    //            Console.ReadKey();
    //        }
    //    }

    //    public void BuscarLibro()
    //    {
    //        Console.Clear();
    //        Console.Write("Ingresa el nombre exacto del libro para buscarlo: ");
    //        buscarLibro = Console.ReadLine();
    //        libroEncontrado = false; // Inicializamos a1 campo en "false" para indicar que a1 iniciar el recorrido por la matriz no hemos encontrado un libro

    //        for (int i = 0; i < cantidadLibros; i++)
    //        {
    //            if (libros[i].Titulo.Equals(buscarLibro))
    //            {
    //                Console.WriteLine($"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" se encuentra disponible en la biblioteca en el índice: {i + 1}");
    //                libroEncontrado = true; //Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
    //            }
    //        }
    //        if (!libroEncontrado)  //Lo mismo que colocar if(1ibroEncontrado == false)
    //        {
    //            Console.WriteLine("Libro no encontrado\n");
    //        }
    //    }

    //    public void BusquedaParcial()
    //    {
    //        Console.Clear();

    //        Console.Write("Ingresa al menos una parte del título o del nombre del autor de un libro para buscarlo: ");
    //        buscarLibro = Console.ReadLine().ToLower();

    //        libroEncontrado = false; //Inicializamos la variable en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

    //        for (int i = 0; i < cantidadLibros; i++)
    //        {
    //            if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
    //            {
    //                Console.WriteLine($"La palabra \"{buscarLibro}\" fue encontrada en el libro: \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" en el índice: {i + 1}");
    //                libroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
    //            }
    //        }
    //        if (!libroEncontrado) // Lo mismo que colocar if(encontrar == false)
    //        {
    //            Console.WriteLine("¡No se encontraron coincidencias!\n");
    //        }
    //    }

    //    public void EliminarLibro()
    //    {
    //        Console.Clear();

    //        if (cantidadLibros == 0)
    //        {
    //            Console.WriteLine("La biblioteca está vacía, no hay nada que eliminar");
    //        }
    //        else
    //        {
    //            Console.Write($"Ingrese el número de libros que desea eliminar (Del 1 al {cantidadLibros}): ");
    //            posicionLibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1; // Decimos que es -1 para que el índice ingresado por el usuario coincida con el índice real de matriz

    //            //Verificamos que el número ingresado sea válido
    //            if (posicionLibroEliminar >= 0 && posicionLibroEliminar < cantidadLibros)
    //            {
    //                Console.Write($"El libro que seas eliminar es: \"{libros[posicionLibroEliminar].Titulo}\"? (Sí/No): ");
    //                string opcion = Console.ReadLine().ToLower();

    //                if (opcion == "si")
    //                {
    //                    //Variables para mostrar un mensaje de cúal fue el libro eliminado
    //                    string tituloEliminado = libros[posicionLibroEliminar].Titulo;
    //                    string autorEliminado = libros[posicionLibroEliminar].Autor;

    //                    for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
    //                    {
    //                        libros[i] = libros[i + 1];
    //                    }
    //                    cantidadLibros--; //Reducimos la cantidad de libros en uno, por el que acabamos de eliminar

    //                    // Le mostramos a1 usuario el libro que se eliminó
    //                    Console.WriteLine($"\nE1 libro \"{tituloEliminado}\" del autor(a): \"{autorEliminado}\" fue eliminado!");
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("El número de libro no fue encontrado");
    //            }
    //        }
    //    }
    //}

    //struct Libro
    //{
    //    //Campos
    //    string titulo;
    //    string autor;
    //    string año;

    //    // Propiedades
    //    public string Titulo { get => titulo; set => titulo = value; }
    //    public string Autor { get => autor; set => autor = value; }
    //    public string Año { get => año; set => año = value; }
    //}



    //----------------------------------------------------------------------------------------------------------------------------------
    //ENUM


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Semana diadePago = Semana.Viernes;

    //        ////Ejemplo de uso en una estructura de control
    //        //if (diadePago == Semana.Viernes)
    //        //{
    //        //    double sueldoSemana1 = 3500;
    //        //    Console.WriteLine($"Hoy es día de pago, recibes ${sueldoSemana1}");
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Lo sentimos, hoy no es día de pago");
    //        //}

    //        //-------------------------------------------------------------------------------------------------------------------------------
    //        ////Clase "Type"

    //        //Type tipoDatoEntero;

    //        ////Operador "typeof"

    //        //tipoDatoEntero = typeof(int);

    //        ////Usando propiedades
    //        //Console.WriteLine(tipoDatoEntero.Name);

    //        ////VOLVER A VER EL EJERCICIO DE LA BIBLIOTECA EL USO DE TYPE

    //        //------------------------------------------------------------------------------------------------------------------------

    //        // Declaramos una variable de tipo "Type" y le asignamos nuestra enumeración
    //        Type tipoEnumeracion = typeof(Continentes);

    //        //Matriz para almacenar la devolución de "GetValues"
    //        Continentes[] constantesContinentes;

    //        // Le asignamos la devolución del método "GetValues" a nuestra matriz "constantesContinentes"
    //        constantesContinentes = (Continentes[])Enum.GetValues(tipoEnumeracion);

    //        //Recorremos a la matriz
    //        foreach (Continentes elemento in constantesContinentes)
    //        {
    //            Console.WriteLine(elemento);
    //        }


    //        ////PARSE

    //        //string cadenaAConvertir;

    //        //Console.Write("Ingresa una opcion: ");
    //        //cadenaAConvertir = Console.ReadLine();

    //        //------------------------------------------------------

    //        //    int a = 10, b = 2;
    //        //    // Variable que va a guardar la opción del menú
    //        //    OpcionesMenu opcion;

    //        //    Console.WriteLine("1. Suma");
    //        //    Console.WriteLine("2. Resta");
    //        //    Console.WriteLine("3. Multiplicación");
    //        //    Console.WriteLine("4. División");

    //        //    Console.Write("Elige una opción: ");
    //        //    opcion = (OpcionesMenu)Enum.Parse(typeof(OpcionesMenu), Console.ReadLine());

    //        //    switch (opcion)
    //        //    {
    //        //        case OpcionesMenu.Suma:
    //        //            Console.WriteLine($"{a} + {b} = {a + b}");
    //        //            break;
    //        //        case OpcionesMenu.Resta:
    //        //            Console.WriteLine($"{a} - {b} = {a - b}");
    //        //            break;
    //        //        case OpcionesMenu.Multiplicacion:
    //        //            Console.WriteLine($"{a} * {b} = {a * b}");
    //        //            break;
    //        //        case OpcionesMenu.Division:
    //        //            Console.WriteLine($"{a} / {b} = {a / b}");
    //        //            break;

    //        //    }
    //    }

    //    enum Continentes : byte
    //    {
    //        Africa = 1,
    //        America,
    //        Asia,
    //        Europa,
    //        Oceania
    //    }

    //    //enum OpcionesMenu
    //    //{
    //    //    Suma = 1,
    //    //    Resta,
    //    //    Multiplicacion,
    //    //    Division
    //    //}
    //}

    //-----------------------------------------------------------------------------------------------
    //JUEGO DE ROL - SECCION 10
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Variables
    //        string nombreJugador1, nombreJugador2;
    //        int primerTurno;

    //        //Pedimos el nombre del jugador 1
    //        Console.Write("Jugador 1, escoge tu nombre: ");
    //        nombreJugador1 = Console.ReadLine();

    //        // Creamos al primer jugador y enviamos su nombre y salud inicial
    //        Jugador jugador1 = new Jugador(nombreJugador1, 1000);

    //        //Le preguntamos al primer jugador el personaje y arma que va a usar
    //        jugador1.EscogerPersonaje();
    //        jugador1.EscogerArma();

    //        //Pedimos el nombre del jugador 2
    //        Console.Write("Jugador 2, escoge tu nombre: ");
    //        nombreJugador2 = Console.ReadLine();

    //        // Creamos al segundo jugador y enviamos su nombre y salud inicial
    //        Jugador jugador2 = new Jugador(nombreJugador2, 1000);

    //        // Le preguntamos al segundo jugador el personaje y arma que va a usar
    //        jugador2.EscogerPersonaje();
    //        jugador2.EscogerArma();

    //        // Invocamos a "TirarDados" y guardamos el valor random devuelto en la variable "primerTurno"
    //        primerTurno = Batalla.TirarDados();

    //        // Determinamos cuál jugador empezará primero
    //        if (primerTurno == 1)
    //        {
    //            // El jugador 1 empieza primero
    //            Console.WriteLine($"{jugador1.Nombre} empieza primero!\n");

    //            // Enviamos primero al jugador1 para que él realice el primer ataque
    //            Batalla.SimularBatalla(jugador1, jugador2);
    //        }
    //        else
    //        {
    //            // El jugador 2 empieza primero
    //            Console.WriteLine($"{jugador2.Nombre} empieza primero!\n");

    //            // Enviamos primero al jugador2 para que él realice el primer ataque
    //            Batalla.SimularBatalla(jugador2, jugador1);
    //        }

    //    } //Fin Main

    //} //Fin class program

    //enum TipoPersonaje
    //{
    //    Escudero,
    //    Arquero,
    //    Caballero
    //}

    //enum TipoArma
    //{
    //    Espada,
    //    Arco,
    //    Martillo
    //}

    //class Jugador
    //{
    //    // Campos
    //    string nombre;
    //    int salud;
    //    int ataque;
    //    int defensa;
    //    TipoPersonaje personajeEscogido;
    //    TipoArma armaEquipada;

    //    //Instanciamos a "Random" para poder hacer uso de ella
    //    Random random = new Random();

    //    //Propiedades
    //    public string Nombre { get => nombre; set => nombre = value; }
    //    public int Salud { get => salud; set => salud = value; }
    //    public int Ataque { get => ataque; set => ataque = value; }
    //    public int Defensa { get => defensa; set => defensa = value; }
    //    internal TipoPersonaje PersonajeEscogido { get => personajeEscogido; set => personajeEscogido = value; }
    //    internal TipoArma ArmaEquipada { get => armaEquipada; set => armaEquipada = value; }

    //    // Constructor
    //    public Jugador(string nombrePa, int saludPa)
    //    {
    //        nombre = nombrePa;
    //        salud = saludPa;
    //    }

    //    // Método que permite al usuario escoger uno de los 3 personajes del enum "TipoPersonaje"
    //    public void EscogerPersonaje()
    //    {
    //        //Guarda el valor de la opción escogida
    //        int opcion;

    //        Console.Clear();

    //        // Mientras "opcion" no sea 1,2 o 3, se le seguirá pidiendo al usuario que ingrese una opción
    //        do
    //        {
    //            Console.WriteLine("1. Escudero");
    //            Console.WriteLine("2. Arquero");
    //            Console.WriteLine("3. Caballero");

    //            Console.Write($"\n{Nombre}, escoge un personaje: ");
    //            opcion = Convert.ToInt32(Console.ReadLine());

    //            Console.Clear();

    //            switch (opcion)
    //            {
    //                //Le asignamos al campo "PersonajeEscogido"
    //                case 1:
    //                    PersonajeEscogido = TipoPersonaje.Escudero;
    //                    ResumenPersonajeEscogido();
    //                    break;
    //                case 2:
    //                    PersonajeEscogido = TipoPersonaje.Arquero;
    //                    ResumenPersonajeEscogido();
    //                    break;
    //                case 3:
    //                    PersonajeEscogido = TipoPersonaje.Caballero;
    //                    ResumenPersonajeEscogido();
    //                    break;
    //                default:
    //                    Console.WriteLine("Opción inválida. Intenta de nuevo");
    //                    break;
    //            }

    //        } while (opcion < 1 || opcion > 3);
    //    }

    //    public void ResumenPersonajeEscogido()
    //    {
    //        // Mostramos un resumen del personaje que escogió el jugador
    //        Console.WriteLine($"{Nombre}, ahora eres \"{PersonajeEscogido}\"");

    //        Console.Write("\nPresiona cualquier tecla para continuar...");
    //        Console.ReadKey();

    //        Console.Clear();
    //    }

    //    // Método para que el usuario escoja el arma que usará
    //    public void EscogerArma()
    //    {
    //        //Guarda el valor de la opción escogida
    //        int opcion;

    //        Console.Clear();

    //        // Mientras "opcion" no sea 1,2 o 3, se le seguirá pidiendo al usuario que ingrese una opción
    //        do
    //        {
    //            Console.WriteLine("1. Espada (Ataque: 130, Defensa: 40)");
    //            Console.WriteLine("2. Arco (Ataque: 140, Defensa: 30)");
    //            Console.WriteLine("3. Martillo (Ataque: 150, Defensa: 20)");

    //            Console.Write($"\n{Nombre}, elige un arma: ");
    //            opcion = Convert.ToInt32(Console.ReadLine());

    //            Console.Clear();

    //            switch (opcion)
    //            {
    //                case 1:
    //                    ArmaEquipada = TipoArma.Espada;
    //                    ValoresAtaqueDefensaArma();
    //                    ResumenArmaEscogida();
    //                    break;
    //                case 2:
    //                    ArmaEquipada = TipoArma.Arco;
    //                    ValoresAtaqueDefensaArma();
    //                    ResumenArmaEscogida();
    //                    break;
    //                case 3:
    //                    ArmaEquipada = TipoArma.Martillo;
    //                    ValoresAtaqueDefensaArma();
    //                    ResumenArmaEscogida();
    //                    break;
    //                default:
    //                    Console.WriteLine("Opción inválida. Intenta de nuevo");
    //                    break;
    //            }
    //        } while (opcion < 1 || opcion > 3);
    //    }

    //    // Método para asignar valores de ataque y defensa al jugador dependiendo del arma que equipen
    //    public void ValoresAtaqueDefensaArma()
    //    {
    //        switch (ArmaEquipada)
    //        {
    //            case TipoArma.Espada:
    //                Ataque = 130;
    //                Defensa = 40;
    //                break;
    //            case TipoArma.Arco:
    //                Ataque = 140;
    //                Defensa = 30;
    //                break;
    //            case TipoArma.Martillo:
    //                Ataque = 150;
    //                Defensa = 20;
    //                break;
    //        }
    //    }

    //    public void ResumenArmaEscogida()
    //    {
    //        Console.WriteLine($"{Nombre}, escogiste \"{ArmaEquipada}\"\nCon un nivel de ataque de [{Ataque}] y una defensa de [{Defensa}]");

    //        Console.Write("\nPresiona cualquier tecla para continuar...");
    //        Console.ReadKey();
    //        Console.Clear();
    //    }

    //    // Método para mostrar un mensaje cuando el jugador decida atacar
    //    public void Atacar()
    //    {
    //        Console.WriteLine($"\n¡{PersonajeEscogido} {Nombre} ataca con su {ArmaEquipada}!\n");
    //    }

    //    // Método para mostrar un mensaje cuando el jugador decida defender
    //    public void Defender()
    //    {
    //        Console.WriteLine($"\n¡{PersonajeEscogido} {Nombre} se defiende con su {ArmaEquipada}!\n");
    //    }

    //    // Método para preguntarle al usuario si desea atacar o defender
    //    public void EscogerAtacarDefender()
    //    {
    //        //Guarda el valor de la opción escogida
    //        int opcion;

    //        // Mientras "opcion" no sea 1 o 2, se le seguirá pidiendo al usuario que ingrese una opción
    //        do
    //        {
    //            Console.WriteLine("1. Atacar");
    //            Console.WriteLine("2. Defender");

    //            Console.Write($"\n[{PersonajeEscogido} {Nombre}], elige una acción: ");
    //            opcion = Convert.ToInt32(Console.ReadLine());

    //            switch (opcion)
    //            {
    //                case 1:
    //                    Atacar();
    //                    break;
    //                case 2:
    //                    Defender();
    //                    break;
    //                default:
    //                    Console.WriteLine("Opción inválida. Intenta de nuevo");
    //                    break;
    //            }

    //        } while (opcion < 1 || opcion > 2);
    //    }

    //    // Método que nos muestra un resumen de los jugadores
    //    public void ResumenJugador()
    //    {
    //        Console.WriteLine($"[{PersonajeEscogido} {Nombre}] Salud: {Salud} / [{ArmaEquipada}] Ataque: {Ataque}, Defensa: {Defensa}");
    //    }


    //    // Método encargado de calcular el daño que un personaje inflinge sobre otro en función de los valores de ataque y defensa de su arma
    //    public void CalcularDaño(int ataqueOtroJugadorPa)
    //    {
    //        //Variable para recibir el valor aleatorio de ataque sorpresa
    //        int ataqueSorpresa;

    //        // Le asignamos un valor de ataque aleatorio usando Next
    //        ataqueSorpresa = random.Next(-15, 16);

    //        int dañoRecibido;
    //        dañoRecibido = ataqueOtroJugadorPa - Defensa + ataqueSorpresa;

    //        //Reducimos la vida del jugador
    //        Salud -= dañoRecibido;
    //    }

    //} //Fin class Jugador

    //class Batalla
    //{
    //    // Campos
    //    static Random random = new Random();

    //    // Método que determina cuál jugador empezará primero
    //    public static int TirarDados()
    //    {
    //        Console.Write("Presiona cualquier tecla para tirar los dados y determinar quién comienza...");
    //        Console.ReadKey();
    //        Console.Clear();

    //        //Variable que guarda el valor de los dados
    //        int primerTurno;

    //        //Le asignamos a "primerTurno" uno de dos posibles valores (1 o 2) así sabremos qué jugador empezará primero
    //        primerTurno = random.Next(1, 3);
    //        return primerTurno;
    //    }

    //    public static void SimularBatalla(Jugador jugador1Pa, Jugador jugador2Pa)
    //    {
    //        // Variable encargada de controlar las rondas de los jugadores
    //        int ronda = 1;

    //        // Mensaje inicial
    //        Console.WriteLine("¡La batalla ha comenzado!\n");
    //        Console.WriteLine($"RONDA {ronda}\n");

    //        // Mostramos un resumen de cada jugador
    //        jugador1Pa.ResumenJugador();
    //        jugador2Pa.ResumenJugador();

    //        // Primera ronda del jugador 1
    //        Console.WriteLine($"\n{jugador1Pa.PersonajeEscogido} {jugador1Pa.Nombre}, empieza a atacar!");
    //        Console.Write($"Presiona Enter para usar tu {jugador1Pa.ArmaEquipada}...");
    //        Console.ReadKey();
    //        jugador1Pa.Atacar();

    //        //Calculamos el daño que el jugador 1 acaba de hacerle al jugador 2
    //        jugador2Pa.CalcularDaño(jugador1Pa.Ataque);

    //        // Primera ronda del jugador 2
    //        // Le preguntamos qué desea hacer
    //        jugador2Pa.EscogerAtacarDefender();

    //        // Calculamos el daño que el jugador 2 acaba de hacerle al jugador 1
    //        jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

    //        // Seguimos haciendo lo mismo por otras 4 rondas más
    //        for (ronda = 2; ronda <= 5; ronda++)
    //        {
    //            // Mostramos la ronda que se está jugando
    //            Console.WriteLine($"RONDA {ronda}\n");

    //            // Mostramos un resumen de cada jugador
    //            jugador1Pa.ResumenJugador();
    //            jugador2Pa.ResumenJugador();

    //            // Le preguntamos al jugador 1 qué desea hacer
    //            jugador1Pa.EscogerAtacarDefender();
    //            //Calculamos el daño que el jugador 1 acaba de hacerle al jugador 2
    //            jugador2Pa.CalcularDaño(jugador1Pa.Ataque);

    //            // Le preguntamos al jugador 2 qué desea hacer
    //            jugador2Pa.EscogerAtacarDefender();
    //            //Calculamos el daño que el jugador 2 acaba de hacerle al jugador 1
    //            jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

    //            // Espacio en blanco para después de cada ronda
    //            Console.WriteLine();
    //        }

    //        // Mensaje dando por terminada la batalla
    //        Console.WriteLine("\n¡La batalla ha terminado!\n");

    //        // Mostramos por última vez las estadísticas de cada jugador
    //        jugador1Pa.ResumenJugador();
    //        jugador2Pa.ResumenJugador();

    //        // Determinamos quién ganó la batalla basándonos en su nivel de salud final
    //        if (jugador1Pa.Salud > jugador2Pa.Salud)
    //        {
    //            // Si el jugador 1 terminó con más vida que el jugador 2
    //            Console.WriteLine($"\n¡{jugador1Pa.Nombre} ha ganado la batalla!");
    //        }
    //        else
    //        {
    //            // Si el jugador 2 terminó con más vida que el jugador 1
    //            Console.WriteLine($"\n¡{jugador2Pa.Nombre} ha ganado la batalla!");
    //        }
    //    }

    //}

    //---------------------------------------------------------------------------------------------------------------------------------
    //SECCION 11 - Flujos o Streams

    class Program
    {
        static void Main(string[] args)
        {
            //// Creamos un flujo/stream para trabajar con la memoria RAM
            //MemoryStream ms1 = new MemoryStream(0);

            //// Mostramos la capacidad, longitud y posición del puntero del stream
            //InformacionStream(ms1);

            ////// Mostramos la capacidad de nuestro flujo/stream
            ////Console.WriteLine($"La capacidad del stream es de: {ms1.Capacity} bytes");

            ////// Mostramos la longitud de nuestro flujo/stream
            ////Console.WriteLine($"La longitud del stream es de: {ms1.Length} bytes");

            ////// Mostramos la posición de puntero en el flujo/stream con respecto al inicio
            ////Console.WriteLine($"La posición del puntero en el stream es: {ms1.Position} \n");

            //// Le pedimos a1 usuario una cadena para guardar en el stream
            //Console.Write("Ingresa un texto para guardarlo en el stream: ");
            //string cadena1 = Console.ReadLine();

            //// Matriz de bytes para guardar a la cadena convertida
            //byte[] matrizCadenaByte;

            //// Codificar : string -> secuencia de bytes
            //// Descodificar : secuencia de bytes -> string

            //// Codificamos a cadenal para obtener una secuencia de bytes
            //matrizCadenaByte = Encoding.UTF8.GetBytes(cadena1);

            //// Escribiendo datos en el flujo
            //ms1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            //// Mostramos la capacidad, longitud y posición del puntero del stream
            //InformacionStream(ms1);

            //// Creamos una nueva matriz de bytes para que guarde la codificación de una cadena
            //byte[] nuevaMatrizCadenaByte = Encoding.UTF8.GetBytes("llena");

            //// Escribimos la nueva cadena ya codificada en el flujo
            //ms1.Write(nuevaMatrizCadenaByte, 0, nuevaMatrizCadenaByte.Length);

            //// Indicamos que ya fue escrita la segunda cadena
            //Console.WriteLine("Después de escribir la segunda cadena..");

            //// Mostramos la capacidad, longitud y posición del puntero del stream
            //InformacionStream(ms1);

            ////Cambiamos la posición del puntero
            //ms1.Seek(5, SeekOrigin.Begin); //== ms1.Seek(1, SeekOrigin.Current); //== ms1.Seek(1, SeekOrigin.End);

            //--------------------------
            ////Metodo READ

            //// Creamos un flujo/stream para trabajar con la memoria RAM
            //MemoryStream ms1 = new MemoryStream(0);

            //// Mostramos la capacidad, longitud y posición del puntero del stream
            //InformacionStream(ms1);

            //// Matriz de bytes para guardar a la cadena convertida
            //byte[] matrizCadenaByte;

            //// Codificamos a cadenal para obtener una secuencia de bytes
            //matrizCadenaByte = Encoding.UTF8.GetBytes("Hola a todos");

            //// Escribiendo datos en el flujo
            //ms1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            ////Mensaje para separar el antes y despues del write
            //Console.WriteLine("Después de escribir la segunda cadena..");

            //// Mostramos la capacidad, longitud y posición del puntero del stream
            //InformacionStream(ms1);

            //// Búfer para almacenar los bytes leídos por Read
            //byte[] buferBytesLeidos = new byte[100];

            //ms1.Seek(0, SeekOrigin.Begin); // Mover el puntero a1 inicio del flujo

            ////Leemos el contenido de nuestro flujo usando el método Read
            //int bytesLeidos = ms1.Read(buferBytesLeidos, 0, (int)ms1.Length);

            //// Mostramos cuántos bytes fueron leídos por Read
            //Console.WriteLine($"Bytes leídos del stream: {bytesLeidos}");

            //// Descodificamos la matriz de bytes leida para convertirla en un string
            //string cadenaDescodificada = Encoding.UTF8.GetString(buferBytesLeidos);

            //// Mostramos la cadena descodificada
            //Console.WriteLine(cadenaDescodificada);

            ////Cerramos el flujo
            //ms1.Close();

            //------------------------------------------------------------------------------
            //    //Ej MemoryStream

            //    // Variables necesarias
            //    int opcion;
            //    bool repetir = true;
            //    string mensajeParaCifrar, contraseñaMensaje, mensajeCifrado;

            //    //Creamos un flujo/stream en la memoria RAM
            //    MemoryStream memoryStream1 = new MemoryStream();
            //    contraseñaMensaje = Console.ReadLine();

            //    // Pedimos la cadena que va a ser guardada en el flujo
            //    Console.Write("Ingresa el mensaje que quiyes cifrar: ");
            //    mensajeParaCifrar = Console.ReadLine();

            //    // Pedimos una contraseña para proteger el mensaje cifrado
            //    Console.Write("Ingresa una contraseña para proteger el mensaje: ");
            //    contraseñaMensaje = Console.ReadLine();

            //    // Enviamos la cadena dada por el usuario para cifrarla
            //    mensajeCifrado = CifrarMensaje(mensajeParaCifrar);

            //    // Declaramos una matriz de bytes y le asignamos la codificación del mensaje ya cifrado para obtener una secuencia de bytes
            //    byte[] matrizCadenaByte = Encoding.UTF8.GetBytes(mensajeCifrado);

            //    // Escribimos el mensaje cifrado en el flujo
            //    memoryStream1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            //    // Mensaje para separar el antes y después del write
            //    Console.WriteLine("E1 mensaje está protegido, presiona cualquier tecla para continuar...");
            //    Console.ReadKey();

            //    // Empezamos a leer el string (cifrado) almacenado en el memorystream

            //    // Búfer para almacenar los bytes leídos por Read
            //    byte[] buferBytesLeidos = new byte[100];

            //    // Mover el puntero a1 inicio del flujo
            //    memoryStream1.Seek(0, SeekOrigin.Begin);

            //    // Leemos el contenido de nuestro flujo usando el método Read
            //    memoryStream1.Read(buferBytesLeidos, 0, (int)memoryStream1.Length);

            //    // Descodificamos la matriz de bytes leida para convertirla en un string
            //    string cadenaDescodificadaCifrada = Encoding.UTF8.GetString(buferBytesLeidos);

            //    //Mostramos el menú
            //    do
            //    {
            //        // Limpiamos la consola
            //        Console.Clear();
            //        Console.WriteLine("1.Mostrar mensaje");
            //        Console.WriteLine("2.Descifrar mensaje");
            //        Console.WriteLine("3.Me rindo");


            //        Console.Write("Escoje una opción: ");
            //        opcion = Convert.ToInt32(Console.ReadLine());

            //        switch (opcion)
            //        {
            //            case 1:
            //                //Mostramos la cadena descodificada pero todavía cifrada
            //                Console.WriteLine($"Mensaje: \"{cadenaDescodificadaCifrada}\"");

            //                // Mensaje de espera
            //                Console.WriteLine("Presiona cualquier tecla para continuar...");
            //                Console.ReadKey();
            //                break;
            //            case 2:

            //                Console.Write("Ingresa la contraseña para descrifrar el mensaje: ");
            //                string posibleContraseña = Console.ReadLine();

            //                if (posibleContraseña == contraseñaMensaje)
            //                {
            //                    // Mandamos la cadena codificada al método "DescifrarMensaje" para ser descifrada, y la devoluciön la guardamos en una varible local
            //                    string mensajeDescifrado = DescifrarMensaje(cadenaDescodificadaCifrada);

            //                    // Mostramos la cadena descodificada y ya descifrada
            //                    Console.WriteLine($"Mensaje: \"{mensajeDescifrado}\"");

            //                    //Mensaje de espera
            //                    Console.WriteLine("Presiona cualquier tecla para continuar...");
            //                    Console.ReadKey();

            //                    //Cerramos el flujo
            //                    memoryStream1.Close();

            //                    //Finalizamos el programa
            //                    repetir = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Contraseña incorrecta. Intena de nuevo");
            //                    // Mensaje de espera
            //                    Console.WriteLine("Presiona cualquier tecla para continuar...");
            //                    Console.ReadKey();
            //                }
            //                break;
            //            case 3:
            //                // Finalizamos el programa
            //                repetir = false;
            //                break;
            //        } 
            //    } while (repetir);

            //} 

            //static string CifrarMensaje(string mensajeCifrarPa)
            //{
            //    // Variable que va a guardar el mensaje cifrado
            //    string mensajeCifrado;

            //    // Le asignamos el mensaje original a nuestra variable local vacía
            //    mensajeCifrado = mensajeCifrarPa;

            //    mensajeCifrado = mensajeCifrado.Replace('a', '1');
            //    mensajeCifrado = mensajeCifrado.Replace('e', '2');
            //    mensajeCifrado = mensajeCifrado.Replace('i', '3');
            //    mensajeCifrado = mensajeCifrado.Replace('o', '4');
            //    mensajeCifrado = mensajeCifrado.Replace('u', '5');

            //    // Devolvemos el mensaje ya cifrado
            //    return mensajeCifrado;
            //}

            //static string DescifrarMensaje(string mensajeCifradoPa)
            //{
            //    // Variable que va a guardar el mensaje cifrado
            //    string mensajeDescifrado;

            //    // Le asignamos el mensaje original a nuestra variable local vacía
            //    mensajeDescifrado = mensajeCifradoPa;

            //    mensajeDescifrado = mensajeDescifrado.Replace('1', 'a');
            //    mensajeDescifrado = mensajeDescifrado.Replace('2', 'e');
            //    mensajeDescifrado = mensajeDescifrado.Replace('3', 'i');
            //    mensajeDescifrado = mensajeDescifrado.Replace('4', 'o');
            //    mensajeDescifrado = mensajeDescifrado.Replace('5', 'u');

            //    // Devolvemos el mensaje ya descifrado
            //    return mensajeDescifrado;
            //}

            //static void InformacionStream(MemoryStream ms1Pa)
            //{
            //    Console.WriteLine($"\nCapacidad: {ms1Pa.Capacity}");

            //    // Mostramos la longitud de nuestro flujo/stream
            //    Console.WriteLine($"La longitud del stream es de: {ms1Pa.Length} bytes");

            //    // Mostramos la posición de puntero en el flujo/stream con respecto al inicio
            //    Console.WriteLine($"La posición del puntero en el stream es: {ms1Pa.Position} \n");

            //--------------------------------------------------------------------------------------------------
            // FileStream

            ////Creando un flujo de archivo
            //FileStream fs = new FileStream("Mi primer archivo.txt", FileMode.Create);

            //// Cadena para guardar la informaciön que sera escrita en el archivo txt
            //string textoParaArchivo = "Texto de prueba para el archivo";

            //// Matriz de bytes para almacenar la cadena
            //byte[] bufferCadenaABytes;

            //// Codificamos la cadena
            //bufferCadenaABytes = Encoding.UTF8.GetBytes(textoParaArchivo);

            //// Escribimos a la cadena codificada en nuestro archivo de texto
            //fs.Write(bufferCadenaABytes, 0, bufferCadenaABytes.Length);

            //------------------------

            ////Abriendo un flujo de archivo
            //FileStream fs = new FileStream("Contraseña.txt", FileMode.Open);

            ////Buffer para almacenar los bytes contenidos en el archivo
            //byte[] bufferLeerDatosArchivo = new byte[1024];

            //// Leemos los bytes que contiene el archivo
            //fs.Read(bufferLeerDatosArchivo, 0, bufferLeerDatosArchivo.Length);

            //string cadenaDescodificada = Encoding.UTF8.GetString(bufferLeerDatosArchivo);

            //// Mostramos la cadena descodificada (la informaciön del archivo)
            //Console.WriteLine($"Informaciön obtenida del archivo: \"{cadenaDescodificada}\"");

            //----------------------------
            //Clase "File"

            //// Creamos un objeto FileStream y el archivo
            //FileStream fs = File.Create("Archivo con File.txt");

            //// Codificamos una cadena para escribirla en el archivo
            //byte[] bufer = Encoding.UTF8.GetBytes("Prueba de texto");

            //// Escribimos en eI archivo
            //fs.Write(bufer, 0, (int)bufer.Length);

            ////Cerramos el flujo de Create
            //fs.Close();



            //////Escribimos en el archivo
            ////File.WriteAllText("Archivo con File.txt", "Prueba de que se creo un archivo");

            ////Excribimos/anexamos texto a nuestro archivo
            //File.AppendAllText("Archivo con File.txt", "Texto Anexado");

            //--------
            ////StreamWriter

            //// Instanciamos a SW le mandamos el archivo a su constructor
            //StreamWriter sw = new StreamWriter("Archivo con file.txt");

            //// Usamos a Write para escribir texto en el archivo
            //sw.Write("Texto de prueba con StreamWriter", true);

            //// Cerramos el flujo
            //sw.Close();

            ////--------
            ////StreamReader

            //string contraseñaArchivo;

            //using (StreamReader sr = new StreamReader("Contraseña.txt"))
            //{
            //    contraseñaArchivo = sr.ReadLine();
            //}
            //// Instanciamos a SW para crear un flujo y poder leer el contenido del archivo (en el using)


            //// Variable para almacenar la contraseäa y Asignamos la devoluciön de ReadLine a nuestro string (en el using)


            //// Mostramos la informaciön del archivo
            //Console.WriteLine($"Contraseña: {contraseñaArchivo}");

            ////Exists
            //if (File.Exists("Contraseña.txt"))
            //{
            //    Console.WriteLine("Archivo encontrado");
            //}

            ////Copy
            //string origenArchivo = "Contraseña.txt";
            //string destinoArchivo = "C:\\Users\\cogal\\Desktop\\Contraseña.txt";

            //File.Copy(origenArchivo, destinoArchivo, false);

            ////Move

            //string origenArchivo1 = "Prueba.txt";
            //string destinoArchivo1 = "C:\\Users\\cogal\\Desktop\\Prueba.txt";

            //File.Move(origenArchivo1, destinoArchivo1);

            ////Delete

            //File.Delete(destinoArchivo1);

            //---------------------------------------------------

            ////Clase Directory y DirectoryInfo

            ////Creamos nuestro primer directorio
            //DirectoryInfo directoryInfo = Directory.CreateDirectory("Mi cuarta carpeta");

            //// Mostramos informaciön del directorio creado, a través del objeto Directorylnfo y sus propiedades
            //Console.WriteLine($"Nombre: {directoryInfo.Name}");
            //Console.WriteLine($"Ruta absoluta: {directoryInfo.FullName}");
            //Console.WriteLine($"Fecha de creación: {directoryInfo.CreationTime}");

            ////Exists y Move
            //string origenDirectorio = @"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug\Mi segunda carpeta\Mi tercera carpeta";
            //string destinoDirectorio = @"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug\Mi tercera carpeta";

            //if (Directory.Exists(origenDirectorio))
            //{
            //    Directory.Move(origenDirectorio, destinoDirectorio);
            //}
            //else
            //{
            //    Console.WriteLine("E1 directorio de destino ya existe");
            //}

            ////Delete

            //string directorio = @"C: \Users\cogal\Desktop\Carpeta en el escritorio";

            //if (Directory.Exists(directorio))
            //{
            //    Directory.Delete(directorio);
            //}
            //else
            //{
            //    Console.WriteLine("Directorio no encontrado");
            //}

            //GetFiles

            //// Matriz para almacenar los nombres de archivos
            //string[] nombresArchivos;
            //int indice = 1;

            //// Buscamos archivos en la ruta del proyecto y asignamos la devoluciön a la matriz de string
            //nombresArchivos = Directory.GetFiles(@"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug");

            //// Recorremos a la matriz y mostramos sus elementos
            //foreach (string elemento in nombresArchivos)
            //{
            //    Console.WriteLine($"{indice++}.- {Path.GetFileName(elemento)}");  
            //}

            ////GetDirectories

            //// Matriz para almacenar los nombres de archivos
            //string[] nombresSubDirectorios;
            //int indice = 1;

            //// Buscamos archivos en la ruta del proyecto y asignamos la devoluciön a la matriz de string
            //nombresSubDirectorios = Directory.GetDirectories(@"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug");

            //// Recorremos a la matriz y mostramos sus elementos
            //foreach (string elemento in nombresSubDirectorios)
            //{
            //    Console.WriteLine($"{indice++}.- {Path.GetFileName(elemento)}");
            //}


            ////Método GetDirectoryName

            //// Cadena con la ruta completaY
            //string rutaInicial = @"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug\HolaMundo.pdb";

            //// El método quita el ültimo elemento de la ruta y Io almacena en la variable string
            //string rutaSinUltimoElemento = Path.GetDirectoryName(rutaInicial);

            //// Mostramos la cadena devuelta por el método
            //Console.WriteLine(rutaSinUltimoElemento);

            ////Método GetFileSystemEntries

            //// Cadena con la ruta
            //string ruta = @"C:\Users\cogal\Desktop\Prueba";

            //// Llamamos al método y Ie asignamos Ia devoluciön a una matriz de string
            //string[] archivosDirectorios = Directory.GetFileSystemEntries(ruta, "Subcarpeta1");

            //// Recorremos la matriz y mostramos sus elementos
            //foreach (string elemento in archivosDirectorios)
            //{
            //    Console.WriteLine(elemento);
            //}

            ////GetExtension - Clase Path

            //// Cadena con la ruta
            //string ruta = @"C:\Users\cogal\Desktop\Prueba\archivo.txt";

            //// Llamamos al método y le asignamos la extensiön al string
            //string extension = Path.GetExtension(ruta);

            //// Mostramos la extensiön
            //Console.WriteLine($"La extensiön del archivo es: {extension}");

            ////Combine - Clase Path

            //// String que contiene el nombre de la ruta base
            //string rutaBase = @"C:\Users\cogal\source\repos\HolaMundo\HolaMundo\bin\Debug";

            //// String para almacenar la cadena ya concatenada
            //string rutaComp1eta;

            //// Pedimos el nombre del directorio que queremos crear
            //Console.Write("lngresa el nombre del directorio a crear:");
            //string nombreDirectorio = Console.ReadLine();

            //// Concatenamos los nombres
            //rutaComp1eta = Path.Combine(rutaBase, nombreDirectorio);

            //// Creamos el directorio y le mostramos al usuario la ruta donde fue creado
            //Directory.CreateDirectory(rutaComp1eta);
            //Console.WriteLine($"E1 directorio se creö en: {rutaComp1eta}");

            ////Copiar un directorio

        //    string origenDirectorio = @""; // Ruta de origen del directorio
        //    string destinoDirectorio = @""; // Ruta de destino del directorio

        //    // Llamamos al método "CopiarDirectorio" y le enviamos el origen y destino como argumentos
        //    CopiarDirectorio(origenDirectorio, destinoDirectorio);
        //}

        //static public void CopiarDirectorio(string origenDirectorioPa, string destinoDirectorioPa)
        //{
        //    // Verificar si el directorio de destino no existe, crearlo si es necesario
        //    if (!Directory.Exists(destinoDirectorioPa))
        //    {
        //        Directory.CreateDirectory(destinoDirectorioPa);
        //    }

        //    // Matriz para guardar las rutas completas de los archivos del directorio de origen
        //    string[] archivos = Directory.GetFiles(origenDirectorioPa);

        //    // Copiar archivos desde el directorio de origen al directorio de destino
        //    foreach (string archivoRutaOrigen in archivos)
        //    {
        //        // Asignamos el nombre del archivo (matriz) y su extensión a la variable "nombre"
        //        string nombreArchivo = Path.GetFileName(archivoRutaOrigen);

        //        // Concatenamos la ruta de destino con el nombre de cada archivo que obtuvimos de la matriz
        //        string rutaCompletaArchivoDestino = Path.Combine(destinoDirectorioPa, nombreArchivo);

        //        // Copiamos el archivo de la ruta original en la nueva ruta
        //        File.Copy(archivoRutaOrigen, rutaCompletaArchivoDestino);
        //    }

        //    // Matriz para los nombres de los directorios
        //    string[] subdirectorios = Directory.GetDirectories(origenDirectorioPa);

        //    // Recorrer y copiar subdirectorios de manera recursiva
        //    foreach (string subdirectorioRutaOrigen in subdirectorios)
        //    {
        //        // Obtenemos el nombre de cada directorio contenido en la matriz y se lo asignamos a la variable "nombreSubdirectorio"
        //        string nombreSubdirectorio = Path.GetFileName(subdirectorioRutaOrigen);

        //        // Concatenamos la ruta de destino con el nombre de cada directorio que obtuvimos de la matriz
        //        string rutaCompletaSubdirectorioDestino = Path.Combine(destinoDirectorioPa, nombreSubdirectorio);

        //        // Llamada recursiva para copiar el subdirectorio y sus contenidos.
        //        // Ahora el nombre completo del subdirectorio será el parámetro "OrigenDirectorioPa"
        //        // Y "rutaCompletaSubdirectorio" será el parámetro "destinoDirectorioPa"
        //        CopiarDirectorio(subdirectorioRutaOrigen, rutaCompletaSubdirectorioDestino);
        //    }
        }
    }
}





