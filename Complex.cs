namespace Complex
{
    using System;

    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Constructor
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overload + operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Overload - operator
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // Overload * operator
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(
                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            );
        }

        // Overload / operator
        public static Complex operator /(Complex c1, Complex c2)
        {
            double denom = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new Complex(
                (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denom,
                (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denom
            );
        }

        // Overload == operator
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        // Overload != operator
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        // Override Equals and GetHashCode to ensure consistency with == and !=
        public override bool Equals(object obj)
        {
            if (obj is Complex other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imaginary.GetHashCode();
        }



        public static void Main()
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(1, 2);

            Complex sum = c1 + c2;
            Complex difference = c1 - c2;
            Complex product = c1 * c2;
            Complex quotient = c1 / c2;

            Console.WriteLine($"Sum: {sum}");           // Output: 4 + 6i
            Console.WriteLine($"Difference: {difference}"); // Output: -2 - 2i
            Console.WriteLine($"Product: {product}");   // Output: -5 + 10i
            Console.WriteLine($"Quotient: {quotient}"); // Output: 0.44 + 0.08i

            Console.WriteLine($"Equality: {c1 == c2}");  // Output: False
            Console.WriteLine($"Inequality: {c1 != c2}"); // Output: True
        }


    }
}
