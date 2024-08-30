using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        // Operator Oveloading
        // + Operator - Function public - Classic Member Method [Static]

        public static Complex operator +(Complex left , Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 + right?.Real ?? 0,
                Imag = left?.Imag ?? 0 + right?.Imag ?? 0
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 - right?.Real ?? 0,
                Imag = left?.Imag ?? 0 - right?.Imag ?? 0
            };
        }

        // ++ Operator
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            return complex;
        }
        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            return complex;
        }

        public static bool operator >(Complex left, Complex right)
        {
            if(left.Real == right.Real)
            {
                return left.Imag > right.Imag;
            }
            else
            {
                return left.Real > right.Real;
            }
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Imag < right.Imag;
            }
            else
            {
                return left.Real < right.Real;
            }
        }

        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real < right.Real)
            {
                return left.Imag >= right.Imag;
            }
            else
            {
                return left.Real >= right.Real;
            }
        }

        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real > right.Real)
            {
                return left.Imag <= right.Imag;
            }
            else
            {
                return left.Real <= right.Real;
            }
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real == right.Real && left.Imag == right.Imag;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || left.Imag != right.Imag;
        }

        //public static explicit operator string(Complex complex)
        //{
        //    return complex.ToString();
        //}

        public static implicit operator string(Complex complex)
        {
            return complex.ToString();
        }

        public static explicit operator int(Complex complex)
        {
            return complex.Real + complex.Imag;
        }



        public override string ToString()
        {
            return $"{Real} + {Imag}";
        }
    }
}
