using System;

namespace Sprint01Library
{
    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
          
            for (int mod = numerator < denominator ? Math.Abs(numerator) : denominator; mod > 1; mod--)
            {
                if (numerator % mod == 0 && denominator % mod == 0)
                {
                    numerator /= mod;
                    denominator /= mod;
                    break;
                }
            }
            // TODO do some worke

            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static Fraction operator +(Fraction fraction)
           => fraction;

        public static Fraction operator -(Fraction fraction)
            => new Fraction(-fraction.numerator, fraction.denominator);

        public static Fraction operator +(Fraction left, Fraction right)
            => new Fraction(left.numerator * right.denominator + right.numerator * left.denominator, left.denominator * right.denominator);

        public static Fraction operator -(Fraction left, Fraction right)
             => new Fraction(left.numerator * right.denominator - right.numerator * left.denominator, left.denominator * right.denominator);

        public static Fraction operator !(Fraction fraction)
            => new Fraction(fraction.denominator, fraction.numerator);

        public static Fraction operator *(Fraction left, Fraction right)
            => new Fraction(left.numerator * right.numerator, left.denominator * right.denominator);

        public static Fraction operator /(Fraction left, Fraction right)
            => new Fraction(left.numerator * right.denominator, left.denominator * right.numerator);

        public static bool operator ==(Fraction left, Fraction right)
            => left.Equals(right);

        public static bool operator !=(Fraction left, Fraction right)
            => !(left == right);

        public override string ToString()
            => numerator + " / " + denominator;

        public override bool Equals(object obj)
            => obj is Fraction fraction
            && numerator == fraction.numerator
            && denominator == fraction.denominator;

        public override int GetHashCode()
            => HashCode.Combine(numerator, denominator);
    }
}
