﻿
namespace Polimorfismo_SobrecargaMetodos
{
    class Calculate
    {
        public int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }
        
        public int Sum(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
    }
}
