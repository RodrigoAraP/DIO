using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Fundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a soma de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="x">Primeiro numero inteiro que sera somado com o proximo.</param>
        /// <param name="y"></param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Realiza a subtracao de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="x">Primeiro numero inteiro que sera subitraido com o proximo.</param>
        /// <param name="y"></param>
        /// <returns>Retorna a subtracao de x e y</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"Raiz Quadrada de {x} = {Math.Sqrt(x)}");
    }
    }
}