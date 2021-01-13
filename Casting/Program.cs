using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {



        static void Main(string[] args)
        {
            float myFloatValue = 10;
            int myIntValue = (int)myFloatValue;
            Console.WriteLine("myIntvalue is " + myIntValue);

            int myInt = 10;

            byte myByte = (byte)myInt;

            double myDouble = (double)myByte;

            //bool myBool = (bool)myDouble;

            string myString = "false";

            //myBool = (bool)myString;

            //myString = (string)myInt;

            myString = myInt.ToString();

            //myBool = (bool)myByte;

            //myByte = (byte)myBool;

            short myShort = (short)myInt;

            char myChar = 'x';

            //myString = (string)myChar;

            long myLong = (long)myInt;

            decimal myDecimal = (decimal)myLong;

            myString = myString + myInt + myByte + myDouble + myChar;


            long number = 139401930;
            string text = "Player score: " + number;
            //text = number; wont work, as only concatenation works like this

            int haloo = MyMethod(/*32*/ true);

            Console.WriteLine(haloo);

            Console.ReadLine();

        }
        public static int MyMethod(bool add3)
        {
            int value = 12;

            if (add3)
                value += 3;
            else
                value -= 2;

            return value;
        }

    }
}
