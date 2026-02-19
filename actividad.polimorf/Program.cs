using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace actividad.polimorf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona obje = new persona();
            obje.imprimirDatos();

            Console.WriteLine("   carro  ");

            carro objeto = new carro();
            objeto.imprimirDatos();
            
            Console.ReadKey();
        }

        class persona
        {

            public string nombre;
            public int edad;
            public double peso;
            public int añonacimiento;
            public int dia;
            public int mes;
            public persona()
            {
            }

            public void leerDatos()
            {
                Console.WriteLine("Ingrese el nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa tu peso:");
                peso = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa año de nacimiento:");
                añonacimiento = Convert.ToInt32(Console.ReadLine());
                
            }
            public void signoZodiacal()
            {
                Console.Write("Día: ");
                int dia = int.Parse(Console.ReadLine());

                Console.Write("Mes (1-12): ");
                int mes = int.Parse(Console.ReadLine());

                string signo = "";

                if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
                    signo = "Aries";
                else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
                    signo = "Tauro";
                else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
                    signo = "Géminis";
                else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
                    signo = "Cáncer";
                else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
                    signo = "Leo";
                else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
                    signo = "Virgo";
                else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
                    signo = "Libra";
                else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
                    signo = "Escorpio";
                else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
                    signo = "Sagitario";
                else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
                    signo = "Capricornio";
                else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
                    signo = "Acuario";
                else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
                    signo = "Piscis";

                Console.WriteLine("Tu signo es: " + signo);

            }

            public void imprimirDatos()
            {
                leerDatos();
                signoZodiacal();
                Console.WriteLine($"Hola {nombre}, tienes {edad} años y tu peso es de {peso} kg");
            }
        }

        class carro
        {
            public int modelo;
            public int matricula;
            public string tipo;
            public string marca;

            public carro()
            {

            }

            public void leerDatos()
            {
                Console.WriteLine("Ingrsa el modelo:");
                modelo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la matricula");
                matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo:");
                tipo = Console.ReadLine();

                Console.WriteLine("Ingres la marca:");
                marca = Console.ReadLine();
            }

            public string numeroPasajeros()
            {
                if (tipo == "sedan")
                    return "5 personas";
                else if (tipo == "suv")
                    return "7 personas";
                else if (tipo == "deportivo")
                    return "2 personas";
                else
                    return "Tipo no válido";
                
            }



           
            public void imprimirDatos()
            {
                leerDatos();
                string nnumero = numeroPasajeros();
                Console.WriteLine(nnumero);
                Console.WriteLine($"El carro es un {marca} del año {modelo}, con matricula {matricula} y es de tipo {tipo}");

            }


        }
            
        

    }
}
