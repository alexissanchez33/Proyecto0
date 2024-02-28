using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorLib
{
    public class Vuelo
    {
        string identificador;
        string compania;
        double origenX;
        double origenY;
        double destinoX;
        double destinoY;
        double posicionX;
        double posicionY;
        double velocidad;

        public Vuelo(string identificador, string compania, double origenX, double origenY, double destinoX, double destinoY, double velocidad, double posicionX, double posicionY)
        {
            this.identificador = identificador;
            this.compania = compania;
            this.origenX = origenX;
            this.origenY = origenY;
            this.destinoX = destinoX;
            this.destinoY = destinoY;
            this.velocidad = velocidad;
            this.posicionX = posicionX;
            this.posicionY = posicionY;

        }


        public void SimularVuelo(int minutos)
        {
            double horas = minutos / 60.0;                                                          // Calcula las horas a partir de los minutos proporcionados
            double distanciaX = destinoX - origenX;                                                 // Calcula la diferencia en las coordenadas X y Y entre el origen y el destino
            double distanciaY = destinoY - origenY;
            double distanciaTotal = Math.Sqrt(distanciaX * distanciaX + distanciaY * distanciaY);   // Calcula la distancia total entre el origen y el destino utilizando el teorema de Pitágoras
            double distanciaRecorrida = horas * velocidad;
            double proporcion = distanciaRecorrida / distanciaTotal;                                // Calcula la proporción de la distancia recorrida con respecto a la distancia total

            if (proporcion >= 1.0)                                                                  // Si la proporción es mayor o igual a 1, el avión ha alcanzado su destino
            {
                posicionX = destinoX;
                posicionY = destinoY;
            }
            else
            {
                posicionX = origenX + distanciaX * proporcion;                                      // Calcula las nuevas coordenadas del avión
                posicionY = origenY + distanciaY * proporcion;
            }

        }
        public (double, double) ObtenerPosicion()
        {
            return (Math.Truncate(posicionX), Math.Truncate(posicionY));
        }
        public override string ToString()
        {
            return $"{identificador} {compania} ({origenX}, {origenY}) ({destinoX}, {destinoY}) {velocidad} ({posicionX}, {posicionY})";
        }

    }
}
