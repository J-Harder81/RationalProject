using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main method that creates a new object with type Rational, sets its fields to some values, and writes the object
            Rational r1 = new Rational(2, 3);
            Rational.WriteRational(r1);

            Rational r2 = new Rational(3, 4);
            Rational.WriteRational(r2);

            //Test the Negate method
            Rational r3 = new Rational(4, 5);
            Rational.Negate(r3);
            Rational.WriteRational(r3);

            //Test the Invert method
            Rational.Invert(r1);
            Rational.WriteRational(r1);

            //Test the ToDouble method
            Console.WriteLine(Rational.ToDouble(r2));

            //Test the Reduced modifier
            Rational r4 = new Rational(8, 12);
            Rational reduced = r4.Reduce();
            Rational.WriteRational(reduced);

            //Test the Add method
            Rational r5 = Rational.Add(r1, r2);
            Rational.WriteRational(r5);
        }
    }
}
