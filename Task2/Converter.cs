using System;
using Microsoft.CSharp.RuntimeBinder;

namespace Task2
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public double result;

        public Converter(double usd, double eur, double rub)
        {
            this.eur = eur;
            this.usd = usd;
            this.rub = rub;
        }

        public double UAH_2_EUR(double uah)
        {
            result = uah * this.eur;
            return Math.Round((Double)result, 2); 
        }
        public double UAH_2_USD(double uah)
        {
            result = uah * this.usd;
            return Math.Round((Double)result, 2); 
        }
        public double UAH_2_RUB(double uah)
        {
            result = uah * this.rub;
            return Math.Round((Double)result, 2); 
        }
    }
}