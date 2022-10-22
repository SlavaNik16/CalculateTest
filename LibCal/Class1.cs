using System;

namespace LibCal
{
    public class Class1
    {
        public int Sum(int val1, int val2)
        {
            if (val1 > 50 || val1 < 0)
            {
                throw new ArgumentOutOfRangeException("val1",val1,
                    "Значение операнда 1 должно быть в пределах 0..50");
            }
            if (val2 < 50 || val2 > 100)
            {
                throw new ArgumentOutOfRangeException("val2", val2,
                    "Значение операнда 1 должно быть в пределах 50..100");
            }
            return val1 + val2;
        }
    }
}
