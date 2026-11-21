using BibliotecaPensiones; //llamada a mi biblioteca
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace subtema6._4
{
    internal class Program
    {
        static void Matricular() {

            Console.WriteLine("DNI:");
            string dni = Console.ReadLine();
            Console.WriteLine("NOMBRES:");
            string nombres = Console.ReadLine();
            Console.WriteLine("CARRERA:");
            string carrera = Console.ReadLine();
            Console.WriteLine("TIENE BECA?(SI/NO):");
            string beca = Console.ReadLine();
            Console.WriteLine("FECHA:");
            string fecha = Console.ReadLine();
           double montobase =  ModuloPensiones.ObtenerMontoBase(carrera);

           double descuento= ModuloPensiones.CalcularDescuentoBeca(montobase,beca);
           
           double total= ModuloPensiones.CalcularTotal(montobase,descuento);
            Console.WriteLine("total:" + total);
            string nuevoregistro= ModuloPensiones.ConstruirRegistroPipe(dni,nombres,carrera,total,fecha);
            ModuloArchivo.GuardarMatricula(nuevoregistro);
            Console.WriteLine("alumnos matriculado!");
          
        }

        static void Main(string[] args)
        {
            int opcion = 0;
                while (opcion !=3) {
                Console.WriteLine("1. matricular");
                Console.WriteLine("2. buscar por dni");
                Console.WriteLine("3. salir");
                try //podria ocurrir el error
                {
                    opcion = int.Parse(Console.ReadLine());//error
                    switch (opcion)
                    {
                        case 1: Matricular();
                            break;

                        case 2:
                            Console.WriteLine("ingrese DNI a buscar: ");
                            string dni =Console.ReadLine();
                            ModuloArchivo.BuscarMatricula(dni);   
                            break;

                        case 3: //salir
                            break;
                    }
                } catch (Exception ex)//en caso el error suceda
                {
                    Console.WriteLine("entrada no valida");
                    opcion = 0;
                }
            }
        }
    }
}
