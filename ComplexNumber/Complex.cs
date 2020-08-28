using System;

namespace ComplexNumber
{
    public class ComplexNumber
    {
        public double real;
        public double imaginary;
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.real = realPart;
            this.imaginary = imaginaryPart;
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            var real = (a.real * b.real - a.imaginary * b.imaginary);
            var imaginary = (a.real * b.imaginary + a.imaginary * b.real);

            return new ComplexNumber(real, imaginary);
        }

    }
}
