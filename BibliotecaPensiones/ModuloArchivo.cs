using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPensiones
{
    public class ModuloArchivo
    {
        public static void GuardarMatricula(string nuevoregistro)
        {
            StreamWriter escritor = new StreamWriter("matriculas.txt", true);
            escritor.WriteLine(nuevoregistro);
            escritor.Close();//importante
        }
        public static void BuscarMatricula(string dniBuscado)
        {    //4114565| flores diaz| ing. sistemas| 300.00| 13-11-2026
             //4614565| frank diaz  | ing. sistemas| 400.00| 14-11-2026
            // 0          1                2         3      4
            StreamReader registro = new StreamReader("matriculas.txt");
            string linea;
            bool encontrado=false;
            while ((linea= registro.ReadLine())!=null)
            {
                string[] columnas = linea.Split('|');
                if (columnas.Length==5 && columnas[0]==dniBuscado) { 
                    
                    encontrado = true;
                    Console.WriteLine("estudiante encontrado:" + columnas[1]);
                    Console.WriteLine($"carrera: {columnas[2]} fecha:{columnas[4]}, total:{columnas[3]}");
                    break; //romper bucle
                }
            }
            if (encontrado==false)
            {
                Console.WriteLine("estudiante no encontrado;");
            }
            registro.Close(); //importante



        }

    }
}
