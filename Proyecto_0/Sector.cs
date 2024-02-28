using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorLib
{
    public class Sector
    {
        private string Identificador { get; set; }
        private int Capacidad { get; set; }
        private double Coordenada_X { get; set; }
        private double Coordenada_Y { get; set; }
        private double Ancho { get; set; }
        private double Alto { get; set; }


        public Sector(string identificador, int capacidad, double x, double y, double ancho, double alto)
        {
            Identificador = identificador;
            Capacidad = capacidad;
            Coordenada_X = x;
            Coordenada_Y = y;
            Ancho = ancho;
            Alto = alto;
        }

        public bool EstaDentro(double X, double Y)
        {
            return (X >= Coordenada_X) && (X <= Coordenada_X + Ancho) && (Y >= Coordenada_Y) && (Y <= Coordenada_Y + Alto);
        }

        public int NumVuelosDentro(ListaVuelos lv)
        {

        }

        public void Mostrar()
        {

        }

        public int Cargar(string fichero)
        {
            if ()
            {
                Sector nuevo_Sector = new Sector();
                string[] leer_fichero = File.ReadAllLines("sector.txt");
                Console.WriteLine("Fichero de sector leído correctamente");
                return 0;
            }
            //poner return's
        }
    }
}
