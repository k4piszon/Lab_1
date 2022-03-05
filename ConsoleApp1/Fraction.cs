using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    public class Fraction   //Utwórz klase ułamek
    {
        private double numerator { get; set; }         //Prywatna zmienna licznik
        private double denominator { get; set; }       //Prywatna zmienna mianownik
        
        public Fraction()                              // Konstruktor domyślny
        {
            numerator = 1;
            denominator = 2;
        }

        
        public Fraction(double x, double y)             // Konstruktor zwykły
        {
            numerator = x;
            denominator = y;
        }
        
        public Fraction(Fraction previousFraction)      //Konstruktor kopiujący
        {
            numerator = previousFraction.numerator;
            denominator = previousFraction.denominator;
        }

        public override string ToString()               //Dodaj metode ToString
        {
            return $"Numerator: {numerator}, denominator: {denominator}";
        }

        public static Fraction operator +(Fraction f1) => f1;
        public static Fraction operator -(Fraction f1) => new Fraction(-f1.numerator, f1.denominator);
        public static Fraction operator +(Fraction f1, Fraction f2) => new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        public static Fraction operator -(Fraction f1, Fraction f2) => new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);

    }
}


   

