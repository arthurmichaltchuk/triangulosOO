using System;

namespace Triangulos.ConsoleApp
{
    public class Verificacoes
    {
        public bool VerificarValidade(double X , double Y , double Z)
        {
            if((X + Y) > Z && (X + Z) > Y && (Z + Y) > X)
                return true;
            else
                return false;
        }
    }
}