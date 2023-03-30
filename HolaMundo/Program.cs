using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}

