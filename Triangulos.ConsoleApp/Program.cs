using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Verificacoes verificacoes = new Verificacoes();
            Triangulo triangulo = new Triangulo();

            string tipo;
            bool validade;
            double X = 15;
            double Y = 10;
            double Z = 20;

            validade = verificacoes.VerificarValidade(X, Y, Z);
            if(validade == false)            
                Console.WriteLine("Triangulo Inválido");           
            else
            {
                tipo = triangulo.ReconhecerTipo(X, Y, Z);
                Console.WriteLine("Seu triângulo é: "+ tipo);
            }
            Console.ReadLine();
        }
    }
}