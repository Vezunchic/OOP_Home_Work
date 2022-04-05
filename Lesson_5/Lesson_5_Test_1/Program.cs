using System;

namespace Lesson_5_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало");
            // Дробь из-за предстваления экземпляра в методе ToString(), ввиде дроби.
            RationalNumbers number1 = new RationalNumbers(2, 4);
            RationalNumbers number2 = new RationalNumbers(2, 2);
            Console.WriteLine($"\nПервое число:");
            Console.WriteLine($"Числитель :{number1.Numerator}\tЗнаменатель:{number1.Denominator}");
            Console.WriteLine($"\nВторое число:");
            Console.WriteLine($"Числитель:{number2.Numerator}\tЗнаменатель:{number2.Denominator}");
            Console.WriteLine($"\nОператор: +\t{number1 + number2}");
            Console.WriteLine($"Оператор: -\t{number1 - number2}");

            Console.WriteLine($"Оператор: *\t{number1 * number2}");
            Console.WriteLine($"Оператор: /\t{number1 / number2}");

            Console.WriteLine($"Сравнение 1го < 2го:\t{number1 < number2}");
            Console.WriteLine($"Сравнение 1го > 2го:\t{number1 > number2}");

            Console.WriteLine($"Сравнение 1го <= 2го:\t{number1 <= number2}");
            Console.WriteLine($"Сравнение 1го >= 2го:\t{number1 >= number2}");

            Console.WriteLine($"Оператор: ==\t{number1 == number2}");
            Console.WriteLine($"Оператор: !=\t{number1 != number2}");

            Console.WriteLine($"ToString(): {number1.ToString()}");
            Console.WriteLine($"Equals(): {number1.Equals(number2)}");

            float fractionNumber1 = (float)number1;
            int fractionNumber2 = (int)number2;
            Console.WriteLine($"Float:\t{fractionNumber1}");
            Console.WriteLine($"Int:\t{fractionNumber2}");
            Console.WriteLine("\nНажмите клавишу");
            
            Console.ReadKey();
        }
    }
    class RationalNumbers 
    {
        private int _numerator; //числитель     
        private int _denominator; // знаменатель

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }
        public RationalNumbers() { }
        public RationalNumbers(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        /// <summary>
        /// Дает возможность сравнивать экземпляры 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>

        public static bool operator <(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator > number2.Denominator && number1.Numerator <= number2.Numerator)
            {
                return true;
            }
            return false;
            
        }
        public static bool operator >(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator < number2.Denominator && number1.Numerator >= number2.Numerator)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Позволяет сравнивать экземпляры
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static bool operator <=(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator >= number2.Denominator && number1.Numerator <= number2.Numerator)
            {
                return true;
            }
            return false;

        }
        public static bool operator >=(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator <= number2.Denominator && number1.Numerator >= number2.Numerator)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Сложение и вычетание экземпляров
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static RationalNumbers operator +(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator == number2.Denominator)
            {
                return new RationalNumbers
                {
                    Numerator = number1.Numerator + number2.Numerator,
                    Denominator = number1.Denominator
                };

            }
            else
            {
                return new RationalNumbers
                {
                    Numerator = number1.Numerator * number2.Numerator + number2.Numerator * number1.Denominator,
                    Denominator = number1.Denominator * number2.Denominator
                };
            }
        }
        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.Denominator == number2.Denominator)
            {
                return new RationalNumbers
                {
                    Numerator = number1.Numerator - number2.Numerator,
                    Denominator = number1.Denominator
                };

            }
            else
            {
                return new RationalNumbers
                {
                    Numerator = number1.Numerator * number2.Numerator - number2.Numerator * number1.Denominator,
                    Denominator = number1.Denominator * number2.Denominator
                };
            }
        }
        /// <summary>
        /// Деление и умножение экземпляров
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>

        public static RationalNumbers operator *(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers { Numerator = number1.Numerator * number2.Numerator, Denominator = number1.Denominator * number2.Denominator };
        }
        public static RationalNumbers operator /(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers { Numerator = number1.Numerator * number2.Denominator, Denominator = number1.Denominator * number2.Numerator };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>

        public static bool operator ==(RationalNumbers number1, RationalNumbers number2)
        {
            return number1.Numerator == number2.Numerator && number1.Denominator == number2.Denominator;
        }
        public static bool operator !=(RationalNumbers number1, RationalNumbers number2)
        {
            return number1.Numerator != number2.Numerator || number1.Denominator != number2.Denominator;
        }
       public bool Equals(RationalNumbers obj)
        {

            if (this._numerator == obj._numerator && this._denominator == obj._denominator)
            {
                return true;
            }

            return false;
        }
        /* public override bool Equals(object obj)
         {
             if (obj == null) 
             { 
                 return false; 
             }
             if (obj is not RationalNumbers)
             {
                 return false;
             }
             var number2 = (RationalNumbers)obj;
             if (this._numerator == number2._numerator && this._denominator == number2._denominator)
             {
                 return true;
             }

             return false;
         }*/
        public override int GetHashCode()
        {
            return Numerator / Denominator;
 
        }
        public override string ToString()
        {

            return string.Format($"Дробь : { _numerator} / { _denominator}");
        }

        public static explicit operator float(RationalNumbers number)
        {
            float result = number.Numerator;
            return result / number.Denominator; 

        }
        public static explicit operator int(RationalNumbers number)
        {
            return number.Numerator / number.Denominator;
        }

    }
}
