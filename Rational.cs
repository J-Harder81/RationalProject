using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class Rational
    {
        public int numerator, denominator;
        //Parametric constructor to initialize the numerator and denominator
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //Default constructor setting the numerator to 0 and denominator to 1
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        //Method that takes a Rational object as an argument and outputs it in some reasonable format
        public static void WriteRational(Rational r)
        {
            Console.WriteLine($"{r.numerator}/{r.denominator}");
        }
        //Method called Negate that reverses the sign of a rational number
        public static void Negate(Rational r)
        {
            r.numerator = -r.numerator;
        }
        //Method called Invert that inverts the number by swapping the numerator and denominator
        public static void Invert(Rational r)
        {
            int temp = r.numerator;
            r.numerator = r.denominator;
            r.denominator = temp;
        }
        //Method called ToDouble that converts the rational number to a double and returns the result
        public static double ToDouble(Rational r)
        {
            return (double)r.numerator / r.denominator;
        }
        //Modifier named Reduce that reduces a rational number to its lowest terms
        public Rational Reduce()
        {
            int gcd = GCD(numerator, denominator);
            return new Rational(numerator / gcd, denominator / gcd);
        }
        //Method to determine the GCD of the numerator and denominator
        private static int GCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
        //Method called Add that takes two Rational numbers and returns a new Rational object
        public static Rational Add(Rational r1, Rational r2)
        {
            int newNumerator = (r1.numerator * r2.denominator) + (r2.numerator * r1.denominator);
            int newDenominator = r1.denominator * r2.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            return result.Reduce();
        }
    }
}
