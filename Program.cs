using System;

namespace T09_Ejercicio10
{
    class Serie
    {
        private string titulo;
        private int numTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            titulo = "";
            numTemporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string tituloNew, string creadorNew)
        {
            titulo = tituloNew;
            creador = creadorNew;
            numTemporadas = 3;
            entregado = false;
            genero = "";
        }

        public Serie(string tituloNew, string creadorNew, int numTemporadasNew, string generoNew)
        {
            titulo = tituloNew;
            creador = creadorNew;
            numTemporadas = numTemporadasNew;
            genero = generoNew;
        }
    }
}
