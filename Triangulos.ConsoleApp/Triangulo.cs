using System;

namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        public string ReconhecerTipo(double X, double Y, double Z)
        {
            if (X == Y && Y == Z)            
                return "Equilátero";           
            else if(X == Y || Y == Z || Z == X)           
                return "Isósceles";            
            else           
                return "Escaleno";            
        }
    }
}