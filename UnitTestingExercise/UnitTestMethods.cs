﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        // Create a Divide method that passes 2 integers

        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        public bool IsTrueCodersAwesome()
        {
            return true;
        }

        public string GiveMeAJ()
        {
            return "J";
        }


    }
}
