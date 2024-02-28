using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorLib
{
    public class ListaVuelos
    {
        const int MAX = 100;
        int numVuelos;
        Vuelo[] vuelos = new Vuelo[MAX];
        string rutaVuelos = "vuelos.txt"; //ruta de archivo vuelo.txt

        public int GetNumVuelos(int a) //Número de aviones
        {
            this.numVuelos = vuelos.Length;
            return numVuelos; //Número de aviones
        }
        public Vuelo GetVuelo(int i)
        {
            if (File.Exists(rutaVuelos))
            {
                //Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaVuelos);

                //Verifica si el índice está dentro de los límites del array
                if (i >= 0 && i < lineas.Length)
                {
                    // Procesa la línea correspondiente al índice [i]
                    string linea = lineas[i];
                    Vuelo vuelo = ProcesarLinea(linea); //Asumiendo que ProcesarLinea devuelve un objeto Vuelo
                    return vuelo;
                }
                else
                    return -1; // No se encontró el archivo
            }
        }
        public void AvanzarTodos(int tc)
        {
            Console.Write("¿Cuánto tiempo quiere avanzar? (minutos): ");
            tc = Convert.ToInt32(Console.ReadLine());

        }
        public void MostrarTodos() //muestra todos los vuelos
        {
            using (StreamReader lector = new StreamReader(rutaVuelos))
            {
                // Lee y muestra cada línea del archivo
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Console.WriteLine(linea);
                }
            }
        }
        public int Cargar(string rutaVuelos) //Carga todos los vuelos de .txt
        {
            //Verifica si el archivo existe
            if (File.Exists(rutaVuelos))
            {
                //Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaVuelos);
                return lineas.Length; //El fichero se ha cargado correctamente
            }
            else
                return 0; //El archivo no exista
        }
        public void Guardar(string rutaVuelos) //Guarda todos los vuelos en el fichero
        {
            string[] lineas = new string[MAX];
            for (int i = 0; i < vuelos.Length; i++)
            {
                lineas[i] = $"{vuelos[i].identificador} {vuelos[i].compania} {vuelos[i].origenX} {vuelos[i].origenY} {vuelos[i].destinoX} {vuelos[i].destinoY} {vuelos[i].velocidad} {vuelos[i].posicionX} {vuelos[i].posicionY}";
            }

            // Escribe todas las líneas en el archivo
            File.WriteAllLines(rutaVuelos, lineas);
        }
    }
}
