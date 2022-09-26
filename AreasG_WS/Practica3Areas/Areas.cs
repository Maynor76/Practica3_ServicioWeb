using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica3Areas
{
    public class Areas
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        public decimal Lado { get; set; }
        public decimal Triangulo(decimal Base1, decimal Altura1)
        {
            Base = Base1;
            Altura = Altura1;
            var resultado = (Base1 * Altura1) / 2;
            return resultado;
        }
        public decimal Cuadrado(decimal Lado1)
        {
            Lado = Lado1;
            var resultado = Lado1 * Lado1;
            return resultado;
        }
    }
}