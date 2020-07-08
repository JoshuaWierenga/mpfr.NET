namespace System.Numerics.MPFR
{
    public enum ExceptionFlag
    {
        Underflow = 1,
        Overflow = 2,
        NotANumber = 4,
        Inexact = 8,
        ERange = 16,
        DivisionByZero = 32,
        AllFlags = 63
    }
}