using System;

namespace Temperatura
{
    public class Temperatura
    {
        public double TemperaturaGrados;

        public double CalcularCelcius(double Valor)
        {
           TemperaturaGrados = Math.Round((Valor * 1.8) + 32, 2);
            return TemperaturaGrados;
        }

        public double CalcularFahrenheit(double Valor)
        {
            TemperaturaGrados = Math.Round((Valor - 32) / 1.8, 2);
            return TemperaturaGrados;
        }
    }
}
