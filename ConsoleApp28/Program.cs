using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_un_numero_entero
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine(“\t\t\tEJERCICIO 1”);

            //Crear un programa que pida al usuario un numero entero y diga si es par.
            Console.WriteLine("Ingrese un numero entero");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_del_otro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEJERCICIO2");
            //Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo.
            Console.WriteLine("Digite el primer numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num % num2 == 0)
            {
                Console.WriteLine("+num+”es multiplo de “+num2);
             }
            else
            {
                Console.WriteLine("El “+num+”no es multiplo de" + num2);
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEJERCICIO 3");
            // Crear un programa que pida al usuario un numero entero. Si es múltiplo de 10, se lo avisará y pedirá un segundo numero, para decir a continuación si este segundo numero también es múltiplo de 10.
            Console.WriteLine("Digite un numero entero");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 10 == 0)
            {
                Console.WriteLine("Es multiplo de 10");
                Console.WriteLine("Digite el segundo numero");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 % 10 == 0)
                {
                    Console.WriteLine("Tambien es multiplo de 10");
                }
            }
            else
            {
                Console.WriteLine("No es multiplo de 10");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos_numeros_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("\t\t\tEJERCICIO 4");
            //Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrara el resultado de dividir entre el primero y el segundo.
            Console.WriteLine("Digite el primer numero entero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero entero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                r = num / num2;
                Console.WriteLine("El resultado es:" + r);
            }
            else
            {
                Console.WriteLine("Error no se puede dividir entre 0 ");
            }
            Console.ReadKey();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros_cortos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEjercicio 5");
            //Crear un programa que pida al usuario dos números enteros cortos y diga si son iguales o, en caso contrario, cual es el mayor de ellos.
            Console.WriteLine("Digite el primer numero entero corto");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero entero corto");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.WriteLine("Estos numeros son iguale");
            }
            else if (Num1 > Num2)
            {
                Console.WriteLine("El primer numero es mayor!");
            }
            else if (Num1 < Num2)
            {
                Console.WriteLine("El segundo numero es mayor!");
            }
            Console.ReadKey();

        }
    }
}
---------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tres_numero_reales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEJERCICIO 6");
            //Crear un programa que pida al usuario tres números reales y muestre cual es el mayor de los tres.
            Console.WriteLine("Digite el primer numero real");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero real");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero real");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El primer  numero" + num1 + " es mayor");
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El segundo numero" + num2 + " es mayor");
                }

            }
            if (num3 > num1)
            {
                if (num3 > num2)
                {
                    Console.WriteLine("El tercer  numero " + num3 + " es mayor");
                }

            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letras_por_el_teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una constante.
            Console.WriteLine("\t\t\tEjercicio 7");
            Console.WriteLine("Digite una letra del teclado");
            var Letr = Console.ReadLine();
            if (Letr == "a" || Letr == "e" || Letr == "i" || Letr == "o" || Letr == "u")
            {
                Console.WriteLine("Usted acaba de ingresar una vocal: " + Letr);
            }
            else if (Letr == "1" || Letr == "2" || Letr == "3" || Letr == "4" || Letr == "5" || Letr == "6" || Letr == "7" || Letr == "8" || Letr == "9" || Letr == "10" || Letr == "0")
            {
                Console.WriteLine("Usted acaba de ingresar el numero:" + Letr);
            }
            else
            {
                Console.WriteLine("Usted acaba de ingresar una consonate: " + Letr);
            }
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_ingresado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEJERCICIO 8");
            //Crear un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuación, una cifra numérica o algún otro carácter.

            Console.WriteLine("Digite una letra del teclado");
            var Letr = Console.ReadLine();
            if (Letr == "." || Letr == "," || Letr == ":" || Letr == ";" || Letr == "?" || Letr == "!" || Letr == "¡" || Letr == "¿")
            {
                Console.WriteLine("Usted acaba de ingresar un signo de puntuacion: " + Letr);
            }
            else if (Letr == "1" || Letr == "2" || Letr == "3" || Letr == "4" || Letr == "5" || Letr == "6" || Letr == "7" || Letr == "8" || Letr == "9" || Letr == "10" || Letr == "0")
            {
                Console.WriteLine("Usted acaba de ingresar es una cifra numerica:" + Letr);
            }
            else
            {
                Console.WriteLine("Usted acaba de ingresar un caracter diferentre: " + Letr);
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEJERCICIO 9");
            //Crear un programa que use el operador condicional para mostrar el valor absoluto de un numero de la siguiente forma: si el numero es positivo, se mostrara tal cual; si es negativo, se mostrara cambiando el signo.
            Console.WriteLine("Digite un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Usted ha ingresado el numero:" + num);
            }
            else if (num < 0)
            {
                int num2 = Math.Abs(num);
                Console.WriteLine("El numero ingresado ha cambiado:" + num2);
            }
            Console.ReadLine();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usar el operador condicional para calcular el menor de dos números.
            int a, b;
            Console.WriteLine("\t\t\tEJERCICIO 10");

            Console.Write("Escriba un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba otro: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {

                Console.WriteLine("El menor de los dos numeros es:" + a);
            }
            else
            {
                Console.WriteLine("El menor de los dos numeros es:" + b);
            }
            Console.ReadLine();*/
        }
    }
}
